using Microsoft.AspNetCore.Mvc;
using Webshop.BLL.Phone;
using Webshop.DAL;
using Webshop.Models;

namespace Webshop.Controllers
{
    public class PhoneController : Controller
    {
        PhoneModel phoneModel = new PhoneModel();
        public List<Phone> allPhoneList= new List<Phone>();

        public IActionResult Phone()
        {
            PhoneCollection phoneCollection = new PhoneCollection();

            allPhoneList = phoneCollection.getPhones();

            for (int i = 0; i < allPhoneList.Count; i++)
            {
                phoneModel.phones = allPhoneList;
            }

            return View(phoneModel);
        }

    }
}
