using Microsoft.AspNetCore.Mvc;
using Webshop.BLL.Phone;
using Webshop.DAL.Phone;
using Webshop.Models;

namespace Webshop.Controllers
{
    public class PhoneController : Controller
    {
        PhoneModel phoneModel = new PhoneModel();
        PhoneService phoneService = new PhoneService(new PhoneDAL());
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
            Phone newPhone = new Phone();
            newPhone.Brand = phoneModel.Brand;
            newPhone.Model = phoneModel.Model;
            newPhone.Description = phoneModel.Description;
            newPhone.Price = phoneModel.Price;

            phoneService.AddPhone(newPhone);

            return View("ValidationView");
        }

        [HttpPost]
        public ActionResult Delete(PhoneModel phoneModel)
        {
            Phone phoneToDelete = new Phone
            {
                ID = phoneModel.ID,
                Brand = phoneModel.Brand,
                Model = phoneModel.Model,
                Description = phoneModel.Description,
                Price = phoneModel.Price
            };

            phoneService.DeletePhone(phoneToDelete);

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
			Phone modifiedPhone = new Phone
			{
				ID = phoneModel.ID,
				Brand = phoneModel.Brand,
				Model = phoneModel.Model,
				Description = phoneModel.Description,
				Price = phoneModel.Price
			};

			phoneService.ModifyPhone(modifiedPhone);

            return RedirectToAction("ValidationView", phoneModel);
            
        }

    }

}

