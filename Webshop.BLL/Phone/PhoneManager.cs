using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL.Phone;

namespace Webshop.BLL.Phone
{
    public class PhoneManager
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public PhoneManager(string brand, string model, string description, int price)
        {
            Brand = brand;
            Model = model;
            Description = description;
            Price = price;
        }

        public PhoneManager() { }

        public void AddPhone()
        {
            PhoneDAL phoneDAL = new PhoneDAL();

            phoneDAL.AddPhoneInDatabase(Brand, Model, Description, Price);
        }

        public void DeletePhone(int id)
        {
            PhoneDAL phoneDAl = new PhoneDAL();
            phoneDAl.DeletePhoneFromDatabase(id);
        }

    }
}
