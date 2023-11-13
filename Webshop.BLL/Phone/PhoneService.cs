using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL.Phone;

namespace Webshop.BLL.Phone
{
    public class PhoneService
    {
        Phone phone = new Phone();
        PhoneDAL phoneDAL = new PhoneDAL();
        private List<Phone> phones = new List<Phone>();

        public PhoneService(string brand, string model, string description, int price)
        {
            phone.Brand = brand;
            phone.Model = model;
            phone.Description = description;
            phone.Price = price;
        }

        public PhoneService() { }

        public List<Phone> GetPhones()
        {
            List<PhoneDTO> phoneDTOs = phoneDAL.RetrievePhones();

            foreach (var phoneDTO in phoneDTOs)
            {
                Phone phone = new Phone
                {
                    ID = phoneDTO.ID,
                    Brand = phoneDTO.Brand,
                    Model = phoneDTO.Model,
                    Price = phoneDTO.Price,
                    Description = phoneDTO.Description
                };
                phones.Add(phone);
            }

            return phones;
        }

        public void AddPhone()
        {

            phoneDAL.AddPhoneInDatabase(phone.Brand, phone.Model, phone.Description, phone.Price);
        }

        public void DeletePhone(int id)
        {
            phoneDAL.DeletePhoneFromDatabase(id);
        }

        public void ModifyPhone(int id, string brand, string model, string description, int price)
        {
            phoneDAL.UpdatePhoneInDatabase(id, brand, model, description, price);
        }

    }
}
