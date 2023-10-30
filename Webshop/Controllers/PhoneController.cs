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
            List<String> modelList = phone.getModelList();
            List<int> priceList = phone.getPhonePrices();
            List<String> descriptionList = phone.getDescriptionList();


            for (int i = 0; i < phoneList.Count; i++)
            {
                phoneModel.Brands = phoneList;
            }

            for (int i = 0; i < modelList.Count; i++)
            {
                phoneModel.Models = modelList;
            }

            for (int i = 0; i < priceList.Count; i++)
            {
                phoneModel.Prices = priceList;
            }

            for (int i = 0; i < descriptionList.Count; i++)
            {
                phoneModel.Descriptions = descriptionList;
            }


            return View(phoneModel);
        }

    }
}
