using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.BLL.Order
{
    public interface IOrder
    {
        public int RegisterOrder(int customerID, int total);
        public void RegisterOrderDetails(int orderid, int phoneid, int quantity, int price);
        public void UpdateOrder();
    }
}
