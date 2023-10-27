using Microsoft.AspNetCore.Mvc;
using Webshop.BLL;
using Webshop.DAL;

namespace Webshop.Controllers
{
    public class PhoneController : Controller
    {
        Phone phone = new Phone();
        public IActionResult Phone()
        {
            phone.getPhones();
            return View();
        }

    }
}
