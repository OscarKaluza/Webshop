using Microsoft.AspNetCore.Mvc;
using Webshop.BLL;
using Webshop.DAL;
using Webshop.Models;

namespace Webshop.Controllers
{
    public class PhoneController : Controller
    {
        Phone phone = new Phone();
        PhoneModel phoneModel = new PhoneModel();
        public IActionResult Phone()
        {
            List<String> phoneList = phone.getBrandList();

            for (int i = 0; i < phoneList.Count; i++)
            {
                phoneModel.Brands = phoneList;
            }

            return View(phoneModel);
        }

    }
}
