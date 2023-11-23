using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.BLL.Phone
{
    public class PhoneDTO
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is PhoneDTO))
                return false;

            var other = (PhoneDTO)obj;
            return ID == other.ID && Brand == other.Brand && Model == other.Model && Description == other.Description && Price == other.Price;
        }
    }
}
