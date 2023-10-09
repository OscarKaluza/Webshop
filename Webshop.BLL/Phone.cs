using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.BLL
{
    public class Phone
    {
        private static int LastAssignedId = 0;
        public int ID { get; set; }
        private string Brand { get; set; }
        private string Model { get; set; }
        private string Description { get; set; }
        private int Price { get; set; }

        public Phone(string brand, string model, string description, int price)
        {
            this.ID = ++LastAssignedId;
            this.Brand = brand;
            this.Model = model;
            this.Description = description;
            this.Price = price;
        }


    }
}
