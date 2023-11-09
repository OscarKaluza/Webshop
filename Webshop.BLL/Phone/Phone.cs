using Webshop.DAL;
using Webshop.DAL.Phone;

namespace Webshop.BLL.Phone
{
    public class Phone
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
