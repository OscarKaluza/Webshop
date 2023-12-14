using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.BLL.Order
{
    public interface IOrder
    {
        public int RegisterOrder(int customerID, int total, int phoneid, int quantity, double price);
    }
}
