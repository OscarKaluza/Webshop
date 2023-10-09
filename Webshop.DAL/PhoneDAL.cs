using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.DAL
{
    public class PhoneDAL
    {
        public string connectionString = "";

        public void AddPhone(int id, string brand, string model, string description, int price)
        {
            //Phone phone = new Phone(1, "Samsung", "fjdsg", "ITUH", 21);
            string sqlQuery = "";

            int test = id;
        }


    }
}
