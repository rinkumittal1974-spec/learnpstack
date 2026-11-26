using PCInsuranceDomain.Data;
using PCInsuranceDomain.Models;

namespace PCInsuranceDomain.Tests;

public class DomainCatalogTests
{
    [Test]
    public void Slugs_are_unique_ignoring_case()
    {
        var duplicates = DomainCatalog.All
            .GroupBy(i => i.Slug, StringComparer.OrdinalIgnoreCase)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key);

        Assert.That(duplicates, Is.Empty);
    }

    [Test]
    public void Every_related_slug_resolves_to_an_item()
    {
        var dangling = DomainCatalog.All
            .SelectMany(i => i.RelatedSlugs.Select(r => (From: i.Slug, To: r)))
            .Where(link => DomainCatalog.FindBySlug(link.To) is null)
            .Select(link => $"{link.From} -> {link.To}");

        Assert.That(dangling, Is.Empty);
    }

    [Test]
    public void No_item_relates_to_itself()
    {
        var selfLinks = DomainCatalog.All.Where(i => i.RelatedSlugs.Contains(i.Slug)).Select(i => i.Slug);

        Assert.That(selfLinks, Is.Empty);
    }

    [Test]
    public void Every_item_has_content_for_each_detail_section()
    {
        foreach (var item in DomainCatalog.All)
        {
            Assert.Multiple(() =>
            {
                Assert.That(item.Name, Is.Not.Empty, item.Slug);
                Assert.That(item.Icon, Is.Not.Empty, item.Slug);
                Assert.That(item.Accent, Is.Not.Empty, item.Slug);
                Assert.That(item.Tagline, Is.Not.Empty, item.Slug);
                Assert.That(item.Overview, Is.Not.Empty, item.Slug);
                Assert.That(item.Responsibilities, Is.Not.Empty, item.Slug);
                Assert.That(item.KeyTerms, Is.Not.Empty, item.Slug);
            });
        }
    }

    [Test]
    public void Every_category_is_populated()
    {
        var empty = Enum.GetValues<DomainCategory>().Where(c => !DomainCatalog.All.Any(i => i.Category == c));

        Assert.That(empty, Is.Empty);
    }

    [Test]
    public void Every_accent_has_a_css_class()
    {
        var css = File.ReadAllText(SiteCssPath());
        var missing = DomainCatalog.All.Select(i => i.Accent).Distinct().Where(a => !css.Contains($".accent-{a} "));

        Assert.That(missing, Is.Empty);
    }

    static string SiteCssPath()
    {
        for (var dir = new DirectoryInfo(TestContext.CurrentContext.TestDirectory); dir is not null; dir = dir.Parent)
        {
            var candidate = Path.Combine(dir.FullName, "PCInsuranceDomain", "wwwroot", "css", "site.css");
            if (File.Exists(candidate))
                return candidate;
        }
        throw new FileNotFoundException("site.css not found above the test directory");
    }

    [TestCase("policy")]
    [TestCase("POLICY")]
    [TestCase("Policy")]
    public void FindBySlug_matches_regardless_of_case(string slug)
    {
        Assert.That(DomainCatalog.FindBySlug(slug)?.Name, Is.EqualTo("Policy"));
    }

    [TestCase("")]
    [TestCase("not-a-real-slug")]
    public void FindBySlug_returns_null_for_unknown_slug(string slug)
    {
        Assert.That(DomainCatalog.FindBySlug(slug), Is.Null);
    }

    [Test]
    public void New_items_are_registered_under_the_right_category()
    {
        Assert.Multiple(() =>
        {
            Assert.That(DomainCatalog.FindBySlug("claim-workflow")!.Category, Is.EqualTo(DomainCategory.BusinessEntity));
            Assert.That(DomainCatalog.FindBySlug("restoration-contractor")!.Category, Is.EqualTo(DomainCategory.Stakeholder));
            Assert.That(DomainCatalog.FindBySlug("policy-lifecycle")!.Category, Is.EqualTo(DomainCategory.BusinessEntity));
            Assert.That(DomainCatalog.FindBySlug("insurance-math")!.Category, Is.EqualTo(DomainCategory.BusinessEntity));
            Assert.That(DomainCatalog.FindBySlug("homeowners")!.Category, Is.EqualTo(DomainCategory.LineOfBusiness));
        });
    }

    [Test]
    public void New_items_are_linked_from_the_pages_that_lead_to_them()
    {
        Assert.Multiple(() =>
        {
            Assert.That(DomainCatalog.FindBySlug("claim")!.RelatedSlugs, Does.Contain("claim-workflow"));
            Assert.That(DomainCatalog.FindBySlug("claims-vendors")!.RelatedSlugs, Does.Contain("restoration-contractor"));
            Assert.That(DomainCatalog.FindBySlug("policy")!.RelatedSlugs, Does.Contain("policy-lifecycle"));
            Assert.That(DomainCatalog.FindBySlug("premium")!.RelatedSlugs, Does.Contain("insurance-math"));
            Assert.That(DomainCatalog.FindBySlug("coverage")!.RelatedSlugs, Does.Contain("homeowners"));
        });
    }

    [Test]
    public void CategoryLabel_names_the_category_in_plain_words()
    {
        Assert.Multiple(() =>
        {
            Assert.That(DomainCatalog.FindBySlug("policy")!.CategoryLabel, Is.EqualTo("Business Entity"));
            Assert.That(DomainCatalog.FindBySlug("insurer")!.CategoryLabel, Is.EqualTo("Key Stakeholder"));
            Assert.That(DomainCatalog.FindBySlug("cyber")!.CategoryLabel, Is.EqualTo("Line of Business"));
        });
    }
}
