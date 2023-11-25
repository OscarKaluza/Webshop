using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.BLL.Order
{
    internal class OrderService : IOrder
    {
        public int RegisterOrder(int customerId, int total)
        {
            return customerId;
        }

        public void RegisterOrderDetails(int orderid, int phoneid, int quantity, int price)
        {

        }

        public void UpdateOrder()
        {

        }

    }
}
