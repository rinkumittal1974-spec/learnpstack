using PCInsuranceDomain.Data;

namespace PCInsuranceDomain.Tests;

public class WorkedExamplesTests
{
    [Test]
    public void Only_insurance_math_has_worked_examples()
    {
        var withExamples = DomainCatalog.All.Where(i => WorkedExamples.For(i.Slug).Count > 0).Select(i => i.Slug);

        Assert.That(withExamples, Is.EqualTo(new[] { "insurance-math" }));
    }

    [Test]
    public void Every_worked_example_fills_every_field()
    {
        foreach (var example in WorkedExamples.For("insurance-math"))
        {
            Assert.Multiple(() =>
            {
                Assert.That(example.Title, Is.Not.Empty);
                Assert.That(example.Formula, Is.Not.Empty, example.Title);
                Assert.That(example.Scenario, Is.Not.Empty, example.Title);
                Assert.That(example.Lines, Is.Not.Empty, example.Title);
                Assert.That(example.Lines.All(l => l.Label != "" && l.Value != ""), Is.True, example.Title);
                Assert.That(example.Answer, Is.Not.Empty, example.Title);
                Assert.That(example.Takeaway, Is.Not.Empty, example.Title);
            });
        }
    }

    [Test]
    public void Combined_ratio_example_ends_at_98_percent()
    {
        var example = WorkedExamples.For("insurance-math").Single(e => e.Title == "Loss ratio, expense ratio, and combined ratio");

        Assert.That(example.Lines.Single(l => l.Label.StartsWith("Combined ratio")).Value, Is.EqualTo("98%"));
    }

    [Test]
    public void For_returns_empty_for_unknown_slug()
    {
        Assert.That(WorkedExamples.For("not-a-real-slug"), Is.Empty);
    }
}
