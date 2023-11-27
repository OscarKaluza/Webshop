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
        IOrder Repo;
        public OrderService(IOrder repo)
        {
            Repo = repo;
        }
        public int RegisterOrder(int customerId, int total)
        {
            int orderID = Repo.RegisterOrder(customerId, total);
            return orderID;
        }

        public void RegisterOrderDetails(int orderid, int phoneid, int quantity, int price)
        {
            Repo.RegisterOrderDetails(orderid, phoneid, quantity, price);
        }

    }
}
