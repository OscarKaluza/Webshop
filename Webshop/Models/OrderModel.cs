using Microsoft.Extensions.Primitives;
using System.Drawing;
using Webshop.BLL.Phone;

namespace Webshop.Models
{
    public class OrderModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
