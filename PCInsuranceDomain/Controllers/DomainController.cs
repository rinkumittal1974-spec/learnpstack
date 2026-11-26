using Microsoft.AspNetCore.Mvc;
using PCInsuranceDomain.Data;
using PCInsuranceDomain.Models;

namespace PCInsuranceDomain.Controllers;

public class DomainController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Home";
        var items = DomainCatalog.All;
        return View(items);
    }

    public IActionResult Details(string id)
    {
        var item = DomainCatalog.FindBySlug(id);
        if (item is null)
        {
            return NotFound();
        }

        ViewData["Title"] = item.Name;
        return View(item);
    }
}
