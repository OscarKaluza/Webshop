using Webshop.BLL.Order;
using Webshop.BLL.Phone;

namespace Webshop.Models
{
    public class PhoneModel
    {
        public List<Phone> phones { get; set; }
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

    }
}
