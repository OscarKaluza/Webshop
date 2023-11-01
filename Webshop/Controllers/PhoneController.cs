using Microsoft.AspNetCore.Mvc;
using Webshop.BLL.Phone;
using Webshop.Models;

namespace Webshop.Controllers
{
    public class PhoneController : Controller
    {
        PhoneModel phoneModel = new PhoneModel();
        PhoneCollection phoneCollection = new PhoneCollection();
        private List<Phone> allPhoneList = new List<Phone>();

        public IActionResult Phone()
        {
            allPhoneList = phoneCollection.createPhoneList();

            for (int i = 0; i < allPhoneList.Count; i++)
            {
                phoneModel.phones = allPhoneList;
            }

            return View(phoneModel);
        }

    }
}
