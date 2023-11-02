using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webshop.BLL.Inventory;
using Webshop.BLL.Phone;
using Webshop.Models;

namespace Webshop.Controllers
{
    public class InventoryController : Controller
    {
        PhoneModel phoneModel = new PhoneModel();
        PhoneCollection phoneCollection = new PhoneCollection();
        private List<Phone> allPhoneList = new List<Phone>();

        public ActionResult Inventory()
        {
            return View();
        }

        public ActionResult AddPhoneView()
        {
            return View("AddPhone");
        }

        public ActionResult ModifyPhoneView()
        {
            return View("ModifyPhone");
        }

        public ActionResult DeletePhoneView()
        {
            allPhoneList = phoneCollection.GetPhones();

            for (int i = 0; i < allPhoneList.Count; i++)
            {
                phoneModel.phones = allPhoneList;
            }

            return View("DeletePhone", phoneModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddPhone(InventoryModel phoneModel)
        {
            Inventory phone = new Inventory(phoneModel.Brand, phoneModel.Model, phoneModel.Description, phoneModel.Price);
            phone.AddPhone();
            
            return View("ValidationView");
        }

        [HttpPost]
        public ActionResult DeletePhone()
        {
            return View("ValidationView");
        }
        
    }
}
