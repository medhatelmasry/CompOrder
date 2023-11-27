using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Comp1170mvc.Models;

namespace Comp1170mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult PlaceOrder(OrderEntity ordr)
    {
        if (ModelState.IsValid)
        {
            //Console.WriteLine($"------------ {ordr.Email}");
            return View("OrderSummary", ordr); // pass the order object to the view
        }
        return View("Index");
    }

    [HttpPost]
    public IActionResult Contact(Contact contact)
    {
        if (ModelState.IsValid)
        {
            //Console.WriteLine($"------------ {ordr.Email}");
            return View("Contact", contact); // pass the contact object to the view
        }
        return View("Index");
    }

    [HttpPost]
    public IActionResult Zodiac(Zodiac zodiac)
    {
        if (ModelState.IsValid)
        {
            return View("Zodiac", zodiac); // pass the zodiac object to the view
        }
        return View("Index");
    }

    [HttpPost]
    public IActionResult Address(Address address)
    {
        if (ModelState.IsValid)
        {
            return View("Address", address); // pass the address object to the view
        }
        return View("Index");
    }
    [HttpPost]
    public IActionResult ContactSales(ContactSales contactSales)
    {
        if (ModelState.IsValid)
        {
            return View("ContactSales", contactSales); // pass the contact sales object to the view
        }
        return View("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
