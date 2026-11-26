using System.Text.RegularExpressions;
using PCInsuranceDomain.Data;

namespace PCInsuranceDomain.Tests;

public class ProcessGuidesTests
{
    static PCInsuranceDomain.Models.ProcessGuide ClaimGuide => ProcessGuides.For("claim-workflow")!;

    [Test]
    public void Claim_workflow_has_a_guide_and_other_slugs_do_not()
    {
        Assert.Multiple(() =>
        {
            Assert.That(ProcessGuides.For("claim-workflow"), Is.Not.Null);
            Assert.That(ProcessGuides.For("policy"), Is.Null);
            Assert.That(ProcessGuides.For("not-a-real-slug"), Is.Null);
        });
    }

    [Test]
    public void Every_guide_slug_is_a_catalog_item()
    {
        var guided = DomainCatalog.All.Where(i => ProcessGuides.For(i.Slug) is not null).Select(i => i.Slug);

        Assert.That(guided, Is.EqualTo(new[] { "claim-workflow" }));
    }

    [Test]
    public void Guide_has_an_intro_steps_and_diagrams()
    {
        Assert.Multiple(() =>
        {
            Assert.That(ClaimGuide.Intro, Is.Not.Empty);
            Assert.That(ClaimGuide.Steps, Has.Count.EqualTo(14));
            Assert.That(ClaimGuide.Diagrams, Has.Count.EqualTo(3));
        });
    }

    [Test]
    public void Every_step_fills_every_field()
    {
        foreach (var step in ClaimGuide.Steps)
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

    [Test]
    public void Phases_run_in_order_from_one_to_six_without_gaps()
    {
        var numbers = ClaimGuide.Steps
            .Select(s => int.Parse(Regex.Match(s.Phase, @"^Phase (\d+):").Groups[1].Value))
            .ToList();

        Assert.That(numbers.Distinct(), Is.EqualTo(new[] { 1, 2, 3, 4, 5, 6 }));
        Assert.That(numbers, Is.Ordered);
    }

    [Test]
    public void Diagrams_use_the_expected_mermaid_types_in_order()
    {
        var firstWords = ClaimGuide.Diagrams.Select(d => d.MermaidSource.TrimStart().Split(' ', '\n', '\r')[0]);

        Assert.That(firstWords, Is.EqualTo(new[] { "flowchart", "sequenceDiagram", "stateDiagram-v2" }));
    }

    [Test]
    public void Every_diagram_has_a_title_and_caption()
    {
        foreach (var diagram in ClaimGuide.Diagrams)
        {
            Assert.Multiple(() =>
            {
                Assert.That(diagram.Title, Is.Not.Empty);
                Assert.That(diagram.Caption, Is.Not.Empty, diagram.Title);
            });
        }
    }

    [Test]
    public void Flowchart_quotes_are_balanced()
    {
        var quotes = ClaimGuide.Diagrams[0].MermaidSource.Count(c => c == '"');

        Assert.That(quotes % 2, Is.EqualTo(0));
    }
}
