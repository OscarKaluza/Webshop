using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.BLL.Phone;

namespace Webshop.BLL.Order
{
    public class OrderService : IOrder
    {
        IOrder Repository;
        public OrderService(IOrder repo)
        {
            Repository = repo;
        }
        public int RegisterOrder(int customerId, double total, int phoneid, int quantity, double price)
        {
            int orderID = Repository.RegisterOrder(customerId, total, phoneid, quantity, price);
            return orderID;
        }

    }
}
