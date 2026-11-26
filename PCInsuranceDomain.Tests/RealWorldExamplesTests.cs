using PCInsuranceDomain.Data;

namespace PCInsuranceDomain.Tests;

public class RealWorldExamplesTests
{
    [Test]
    public void Every_catalog_item_has_examples()
    {
        var missing = DomainCatalog.All
            .Where(i => RealWorldExamples.For(i.Slug).Count == 0)
            .Select(i => i.Slug);

        Assert.That(missing, Is.Empty);
    }

    [Test]
    public void Every_example_has_a_name_and_a_note()
    {
        foreach (var item in DomainCatalog.All)
        {
            foreach (var example in RealWorldExamples.For(item.Slug))
            {
                Assert.Multiple(() =>
                {
                    Assert.That(example.Name, Is.Not.Empty, item.Slug);
                    Assert.That(example.Note, Is.Not.Empty, $"{item.Slug}: {example.Name}");
                });
            }
        }
    }

    [Test]
    public void Examples_within_one_item_are_not_repeated()
    {
        var repeated = DomainCatalog.All
            .Where(i => RealWorldExamples.For(i.Slug).Select(e => e.Name).Distinct().Count() != RealWorldExamples.For(i.Slug).Count)
            .Select(i => i.Slug);

        Assert.That(repeated, Is.Empty);
    }

    [Test]
    public void For_returns_the_known_examples_for_a_slug()
    {
        var names = RealWorldExamples.For("rating-agency").Select(e => e.Name);

        Assert.That(names, Is.EqualTo(new[] { "AM Best", "S&P Global Ratings", "Moody's", "Fitch Ratings" }));
    }

    [Test]
    public void For_returns_empty_for_unknown_slug()
    {
        Assert.That(RealWorldExamples.For("not-a-real-slug"), Is.Empty);
    }
}
