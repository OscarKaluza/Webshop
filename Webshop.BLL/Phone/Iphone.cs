using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.BLL.Phone;

namespace Webshop.BLL.Phone
{
    public interface Iphone
    {
        public List<PhoneDTO> RetrievePhones();
        public void AddPhoneInDatabase(PhoneDTO phone);
        public bool DeletePhoneFromDatabase(PhoneDTO phone);
        public void UpdatePhoneInDatabase(PhoneDTO phone);

    }
}
