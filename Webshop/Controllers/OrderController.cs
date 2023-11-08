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
        public string Order2(int ID)
        {
            // Not working
            return new string($"Phone with ID {ID} has been ordered");
        }


        [HttpPost]
        public IActionResult Order(int ID, OrderModel ordermodel)
        {
            ordermodel.ID = ID;

            return RedirectToAction("Index", ordermodel);
        }
    }
}
