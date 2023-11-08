using Webshop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace Webshop.Controllers
{
    public class OrderController : Controller
    {
        public OrderModel ordermodel { get; set; }

        public IActionResult Index(OrderModel ordermodel)
        {
            return View(ordermodel);
        }

        [HttpPost]
        public string Order2(string Brand)
        {
            return new string($"Your phone has been ordered\n" +
                              $"Brand: {Brand}\n" +
                              $"Model: ");
        }


        [HttpPost]
        public IActionResult Order(string brand, OrderModel ordermodel)
        {
            ordermodel.Brand = brand;

            return RedirectToAction("Index", ordermodel);
        }
    }
}
