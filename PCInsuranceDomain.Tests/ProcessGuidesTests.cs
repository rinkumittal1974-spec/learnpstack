using System.Text.RegularExpressions;
using PCInsuranceDomain.Data;
using PCInsuranceDomain.Models;

namespace PCInsuranceDomain.Tests;

public class ProcessGuidesTests
{
    static readonly string[] GuideSlugs = { "claim-workflow", "policy-lifecycle" };

    static ProcessGuide Guide(string slug) => ProcessGuides.For(slug)!;

    [Test]
    public void Only_workflow_topics_have_a_guide()
    {
        Assert.Multiple(() =>
        {
            Assert.That(ProcessGuides.For("policy"), Is.Null);
            Assert.That(ProcessGuides.For("not-a-real-slug"), Is.Null);
        });
    }

    [Test]
    public void Every_guide_slug_is_a_catalog_item()
    {
        var guided = DomainCatalog.All.Where(i => ProcessGuides.For(i.Slug) is not null).Select(i => i.Slug);

        Assert.That(guided, Is.EqualTo(GuideSlugs));
    }

    [TestCase("claim-workflow", 14, new[] { "flowchart", "sequenceDiagram", "stateDiagram-v2" })]
    [TestCase("policy-lifecycle", 12, new[] { "flowchart", "stateDiagram-v2" })]
    public void Guide_has_the_expected_steps_and_diagram_types(string slug, int stepCount, string[] diagramTypes)
    {
        var guide = Guide(slug);
        var firstWords = guide.Diagrams.Select(d => d.MermaidSource.TrimStart().Split(' ', '\n', '\r')[0]);

        Assert.Multiple(() =>
        {
            Assert.That(guide.Intro, Is.Not.Empty);
            Assert.That(guide.Steps, Has.Count.EqualTo(stepCount));
            Assert.That(firstWords, Is.EqualTo(diagramTypes));
        });
    }

    [TestCaseSource(nameof(GuideSlugs))]
    public void Every_step_fills_every_field(string slug)
    {
        foreach (var step in Guide(slug).Steps)
        {
            Assert.Multiple(() =>
            {
                Assert.That(step.Phase, Is.Not.Empty, step.Title);
                Assert.That(step.Title, Is.Not.Empty);
                Assert.That(step.Actor, Is.Not.Empty, step.Title);
                Assert.That(step.Timeframe, Is.Not.Empty, step.Title);
                Assert.That(step.Summary, Is.Not.Empty, step.Title);
                Assert.That(step.Details, Is.Not.Empty, step.Title);
            });
        }
    }

    [TestCaseSource(nameof(GuideSlugs))]
    public void Phases_run_in_order_from_one_without_gaps(string slug)
    {
        var numbers = Guide(slug).Steps
            .Select(s => int.Parse(Regex.Match(s.Phase, @"^Phase (\d+):").Groups[1].Value))
            .ToList();

        Assert.That(numbers.Distinct(), Is.EqualTo(Enumerable.Range(1, numbers.Max())));
        Assert.That(numbers, Is.Ordered);
    }

    [TestCaseSource(nameof(GuideSlugs))]
    public void Every_diagram_has_a_title_caption_and_balanced_quotes(string slug)
    {
        foreach (var diagram in Guide(slug).Diagrams)
        {
            Assert.Multiple(() =>
            {
                Assert.That(diagram.Title, Is.Not.Empty);
                Assert.That(diagram.Caption, Is.Not.Empty, diagram.Title);
                Assert.That(diagram.MermaidSource.Count(c => c == '"') % 2, Is.EqualTo(0), diagram.Title);
            });
        }
    }
}
