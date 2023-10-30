using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL;

namespace Webshop.BLL.Phone
{
    public class PhoneCollection
    {
        private List<Phone> phones = new List<Phone>();

        public List<Phone> getPhones()
        {
            PhoneDAL phoneDAL = new PhoneDAL();
            List<string> phoneBrands = phoneDAL.GetPhoneBrands();
            List<string> phoneModels = phoneDAL.GetPhoneModels();
            List<int> phonePrices = phoneDAL.GetPhonePrices();
            List<string> phoneDescription = phoneDAL.getPhoneDescription();

            for (int i = 0; i < phoneBrands.Count; i++)
            {
                Phone phone = new Phone();

                phone.Brand = phoneBrands[i];
                phone.Model = phoneModels[i];
                phone.Price = phonePrices[i];
                phone.Description = phoneDescription[i];

                phones.Add(phone);
            }

            return phones;
        }
    }
}
