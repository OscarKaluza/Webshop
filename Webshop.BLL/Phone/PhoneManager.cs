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
        Phone phone = new Phone();

        public PhoneManager(string brand, string model, string description, int price)
        {
            phone.Brand = brand;
            phone.Model = model;
            phone.Description = description;
            phone.Price = price;
        }

        public PhoneManager() { }

        public void AddPhone()
        {
            PhoneDAL phoneDAL = new PhoneDAL();

            phoneDAL.AddPhoneInDatabase(phone.Brand, phone.Model, phone.Description, phone.Price);
        }

        public void DeletePhone(int id)
        {
            PhoneDAL phoneDAl = new PhoneDAL();
            phoneDAl.DeletePhoneFromDatabase(id);
        }

    }
}
