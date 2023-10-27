using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL;

namespace Webshop.BLL
{
    public class Phone
    {
        public string Brand;

        public List<Phone> getPhones()
        {
            PhoneDAL phoneDAL = new PhoneDAL();
            List<string> phoneBrands = phoneDAL.GetPhoneBrands();
            List<Phone> phones = new List<Phone>();

            foreach (string phoneBrand in phoneBrands)
            {
                Phone phone = new Phone { Brand = phoneBrand };
                phones.Add(phone);
            }

            return phones;
        }

    }
}
