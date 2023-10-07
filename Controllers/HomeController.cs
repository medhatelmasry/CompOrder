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

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost]
    public IActionResult PlaceOrder(OrderEntity ordr)
    {
        if (ModelState.IsValid)
        {
            // OrderEntity order = new OrderEntity();
            // order.Email = Request.Form["Email"];
            // order.FirstName = Request.Form["FirstName"];
            // order.LastName = Request.Form["LastName"];
            // order.Street = Request.Form["street"];
            // order.City = Request.Form["city"];
            // order.Province = Request.Form["province"];
            // order.PostalCode = Request.Form["postalCode"];
            // order.Phone = Request.Form["phone"];
            // order.OrderType = Request.Form["orderType"];
            // order.NumberOfTickets = Convert.ToInt32(Request.Form["numberOfTickets"]);
            // order.PaymentType = Request.Form["paymentType"];
            // order.CardType = Request.Form["cardType"];
            // order.CardNumber = Request.Form["cardNumber"];
            // order.ExpiryMonth = Convert.ToInt32(Request.Form["expiryMonth"]);
            // order.ExpiryYear = Convert.ToInt32(Request.Form["expiryYear"]);

            // Console.WriteLine($"++++++++++++ {order.Email}");
            Console.WriteLine($"------------ {ordr.Email}");

            return View("OrderSummary", ordr); // pass the order object to the view
        }
        return View("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
