using Microsoft.AspNetCore.Mvc;
using Webshop.BLL.Phone;
using Webshop.Models;

namespace Webshop.Controllers
{
    public class PhoneController : Controller
    {
        PhoneModel phoneModel = new PhoneModel();
        PhoneCollection phoneCollection = new PhoneCollection();

        public IActionResult Index()
        {
            phoneModel.phones = phoneCollection.GetPhones();

            return View(phoneModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ManagerModel phoneModel)
        {
            PhoneManager phone = new PhoneManager(phoneModel.Brand, phoneModel.Model, phoneModel.Description, phoneModel.Price);
            phone.AddPhone();

            return View("ValidationView");
        }

    }
}
