using Webshop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using ZstdSharp.Unsafe;
using Webshop.DAL.Order;

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
        public string Order2(OrderModel orderModel)
        {
            return new string($"Your phone has been ordered\n" +
                              $"Brand: {orderModel.Brand}\n" +
                              $"Model: {orderModel.Model}\n" +
                              $"Total: {orderModel.Price}");
        }


        [HttpPost]
        public IActionResult Order(OrderModel ordermodel)
        {
            return RedirectToAction("Index", ordermodel);
        }
    }
}
