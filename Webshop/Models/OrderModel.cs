using Microsoft.Extensions.Primitives;
using System.Drawing;
using Webshop.BLL.Phone;

namespace Webshop.Models
{
    public class OrderModel : Phone
    {
        public int CustomerID { get; set; }    
        public int Quantity { get; set; }
        public double Total { get; set; }
    }
}
