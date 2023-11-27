﻿using Webshop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using ZstdSharp.Unsafe;
using Webshop.DAL.Order;
using Webshop.BLL.Order;


namespace Webshop.Controllers
{
    public class OrderController : Controller
    {
        public OrderModel ordermodel { get; set; }
        OrderDAL orderdal { get; set; } 


        public IActionResult Index(OrderModel ordermodel)
        {
            return View(ordermodel);
        }

        [HttpPost]
        public string Order2(OrderModel orderModel)
        {
            OrderService orderservice = new OrderService(new OrderDAL());

            orderModel.Quantity = 1;
            orderModel.Total = orderModel.Price * orderModel.Quantity;

            int orderid = orderservice.RegisterOrder(1, orderModel.Total);
            orderservice.RegisterOrderDetails(orderid, orderModel.ID, 1, orderModel.Price);

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
