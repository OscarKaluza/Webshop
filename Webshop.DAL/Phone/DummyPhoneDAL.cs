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
        public PhoneDTO InsertedPhone { get; set; }
        public List<PhoneDTO> phones { get; set; }
        public int deletedphone {  get; set; }

        public void AddPhoneInDatabase(PhoneDTO phone)
        {
            InsertedPhone = phone;
        }

        public List<PhoneDTO> RetrievePhones()
        {
            return phones;
        }

        public void DeletePhoneFromDatabase(int id) 
        {
        }

        public void UpdatePhoneInDatabase(int ID, string brand, string model, string description, int price)
        {
        }


    }
}
