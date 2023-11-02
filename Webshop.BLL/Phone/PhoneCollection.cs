using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL;
using Webshop.DAL.Phone;

namespace Webshop.BLL.Phone
{
    public class PhoneCollection
    {
        private List<Phone> phones = new List<Phone>();
        private PhoneDAL phoneDAL = new PhoneDAL();

        public List<Phone> GetPhones()
        {
            List<PhoneDTO> phoneDTOs = phoneDAL.RetrievePhones();

            foreach (var phoneDTO in phoneDTOs)
            {
                Phone phone = new Phone
                {
                    Brand = phoneDTO.Brand,
                    Model = phoneDTO.Model,
                    Price = phoneDTO.Price,
                    Description = phoneDTO.Description
                };
                phones.Add(phone);
            }

            return phones;
        }

        
        

    }
}
