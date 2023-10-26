using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL;

namespace Webshop.BLL
{
    public class Inventory
    {
        private static int LastAssignedId = 0;
        public int ID { get; set; }
        private string Brand { get; set; }
        private string Model { get; set; }
        private string Description { get; set; }
        private int Price { get; set; }

        public Inventory(string brand, string model, string description, int price)
        {
            this.ID = ++LastAssignedId;
            this.Brand = brand;
            this.Model = model;
            this.Description = description;
            this.Price = price;
        }

        public void AddPhone()
        {
            InventoryDAL phoneDAL = new InventoryDAL();

            phoneDAL.AddPhoneInDatabase(ID, Brand, Model, Description, Price);
        }


    }
}
