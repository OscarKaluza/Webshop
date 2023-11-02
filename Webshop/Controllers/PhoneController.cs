using Microsoft.AspNetCore.Mvc;
using Webshop.BLL.Phone;
using Webshop.Models;

namespace Webshop.Controllers
{
    public class PhoneController : Controller
    {
        PhoneModel phoneModel = new PhoneModel();
        PhoneCollection phoneCollection = new PhoneCollection();

        public IActionResult Phone()
        {
            phoneModel.phones = phoneCollection.GetPhones();

            return View(phoneModel);
        }

    }
}
