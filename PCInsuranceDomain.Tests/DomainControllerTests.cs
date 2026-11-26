using Microsoft.AspNetCore.Mvc;
using PCInsuranceDomain.Controllers;
using PCInsuranceDomain.Data;
using PCInsuranceDomain.Models;

namespace PCInsuranceDomain.Tests;

public class DomainControllerTests
{
    readonly DomainController controller = new();

    [Test]
    public void Index_shows_every_catalog_item_under_the_Home_title()
    {
        var result = controller.Index() as ViewResult;

        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result!.Model, Is.SameAs(DomainCatalog.All));
            Assert.That(controller.ViewData["Title"], Is.EqualTo("Home"));
        });
    }

    [Test]
    public void Details_shows_the_requested_item_with_its_name_as_title()
    {
        var result = controller.Details("claim-workflow") as ViewResult;

        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(((DomainItem)result!.Model!).Slug, Is.EqualTo("claim-workflow"));
            Assert.That(controller.ViewData["Title"], Is.EqualTo("Claim Workflow"));
        });
    }

    [Test]
    public void Details_ignores_slug_case()
    {
        var result = controller.Details("INSURER") as ViewResult;

        Assert.That(((DomainItem)result!.Model!).Slug, Is.EqualTo("insurer"));
    }

    [TestCase("not-a-real-slug")]
    [TestCase("")]
    public void Details_returns_NotFound_for_unknown_slug(string slug)
    {
        Assert.That(controller.Details(slug), Is.TypeOf<NotFoundResult>());
    }

    [TestCaseSource(nameof(AllSlugs))]
    public void Details_resolves_for_every_catalog_slug(string slug)
    {
        Assert.That(controller.Details(slug), Is.TypeOf<ViewResult>());
    }

    static IEnumerable<string> AllSlugs() => DomainCatalog.All.Select(i => i.Slug);
}
