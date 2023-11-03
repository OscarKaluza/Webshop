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
        public ActionResult ManagerIndex()
        {
            return View();
        }

        public ActionResult AddPhoneView()
        {
            return View();
        }

        public ActionResult ModifyPhoneView()
        {
            return View();
        }

        public ActionResult DeletePhoneView()
        {
            phoneModel.phones = phoneCollection.GetPhones();

            return View(phoneModel);
        }

        public ActionResult ValidationView()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PhoneModel phoneModel)
        {
            PhoneManager phone = new PhoneManager(phoneModel.Brand, phoneModel.Model, phoneModel.Description, phoneModel.Price);
            phone.AddPhone();

            return View("ValidationView");
        }

        [HttpPost]
        public ActionResult Delete(PhoneModel phoneModel)
        {

            PhoneManager phoneManager = new PhoneManager();
            phoneManager.DeletePhone(phoneModel.ID);

            return View("ValidationView");
        }

    }

}

