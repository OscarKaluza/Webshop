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

        // GET: InventoryController
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
            allPhoneList = phoneCollection.createPhoneList();

            for (int i = 0; i < allPhoneList.Count; i++)
            {
                phoneModel.phones = allPhoneList;
            }

            return View("DeletePhone", phoneModel);
        }


        // POST: InventoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddPhone(InventoryModel phoneModel)
        {
            Inventory phone = new Inventory(phoneModel.Brand, phoneModel.Model, phoneModel.Description, phoneModel.Price);
            phone.AddPhone();
            
            return View("ValidationView");
        }

        // GET: InventoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InventoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InventoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InventoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        [HttpPost]
        public ActionResult DeletePhone()
        {
            return View("ValidationView");
        }
        
    }
}
