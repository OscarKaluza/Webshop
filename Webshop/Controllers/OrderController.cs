using Webshop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace Webshop.Controllers
{
    public class OrderController : Controller
    {
        public OrderModel ordermodel { get; set; }
        public IActionResult Index()
        {
            return View();
        }

        public string Order()
        {
            // Not working
            return new string($"Phone with ID {ordermodel.ID} has been ordered");
        }

        [HttpPost]
        public IActionResult Order(int ID)
        {
            ordermodel = new OrderModel();
            ordermodel.ID = ID;

            return View("Index");
        }
    }
}
