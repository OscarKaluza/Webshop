using Microsoft.AspNetCore.Mvc;
using Webshop.BLL;
using Webshop.DAL;

namespace Webshop.Controllers
{
    public class PhoneController : Controller
    {
        public IActionResult Phone()
        {
            return View();
        }

    }
}
