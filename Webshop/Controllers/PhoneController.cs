using Microsoft.AspNetCore.Mvc;
using Webshop.BLL.Phone;
using Webshop.Models;

namespace Webshop.Controllers
{
    public class PhoneController : Controller
    {
        PhoneModel phoneModel = new PhoneModel();
        PhoneService phoneService = new PhoneService();

        public IActionResult Index()
        {
            phoneModel.phones = phoneService.GetPhones();

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
            phoneModel.phones = phoneService.GetPhones();

            return View(phoneModel);
        }

        public ActionResult DeletePhoneView()
        {
            phoneModel.phones = phoneService.GetPhones();

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
            phoneService.AddPhone(phoneModel.Brand, phoneModel.Model, phoneModel.Description, phoneModel.Price);

            return View("ValidationView");
        }

        [HttpPost]
        public ActionResult Delete(PhoneModel phoneModel)
        {

            phoneService.DeletePhone(phoneModel.ID);

            return View("ValidationView");
        }

        [HttpPost]

        public ActionResult Edit(PhoneModel phoneModel)
        {
            return View("EditPhoneView", phoneModel);
        }

        [HttpPost]
        public ActionResult Modify(PhoneModel phoneModel)
        {
            phoneService.ModifyPhone(phoneModel.ID, phoneModel.Brand, phoneModel.Model, phoneModel.Description, phoneModel.Price);

            return RedirectToAction("ValidationView", phoneModel);
            
        }

    }

}

