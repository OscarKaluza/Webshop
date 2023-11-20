using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.BLL.Phone;

namespace Webshop.DAL.Phone
{
    public class DummyPhoneDAL : IphoneDAL
    {
        public List<PhoneDTO> phones { get; set; }
        public PhoneDTO InsertedPhone { get; set; }

        public List<PhoneDTO> RetrievePhones()
        {
            phones = new List<PhoneDTO>();
            return phones;
        }

        public void AddPhoneInDatabase(PhoneDTO phonedto)
        {
            phonedto.ID = 1;
            phonedto.Brand = "test";
            phonedto.Model = "test";
            phonedto.Description = "test";
            phonedto.Price = 800;
            InsertedPhone = phonedto;
        }

        public bool DeletePhoneFromDatabase(int id) 
        {
            return true;
        }

        public bool UpdatePhoneInDatabase(int id, string brand, string model, string description, int price)
        {
            return true;
        }


    }
}
