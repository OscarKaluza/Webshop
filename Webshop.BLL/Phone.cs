using Webshop.DAL;

namespace Webshop.BLL
{
    public class Phone
    {
        public string Brand;
        private string Model;
        private string Description;
        private int Price;

        public List<Phone> getPhones()
        {
            PhoneDAL phoneDAL = new PhoneDAL();
            List<string> phoneBrands = phoneDAL.GetPhoneBrands();
            List<string> phoneModels = phoneDAL.GetPhoneBrands();
            List<Phone> phones = new List<Phone>();

            foreach (string phoneBrand in phoneBrands)
            {
                Phone phone = new Phone { Brand = phoneBrand};
                phones.Add(phone);
            }

            return phones;
        }

        public List<String> getBrandList()
        {
            PhoneDAL phoneDAL = new PhoneDAL();
            List<String> phoneBrands = phoneDAL.GetPhoneBrands();

            return phoneBrands;
        }

        public List<String> getModelList()
        {
            PhoneDAL phoneDAL = new PhoneDAL();
            List<String> phoneModels = phoneDAL.GetPhoneModels();

            return phoneModels;
        }

        public List<int> getPhonePrices()
        {
            PhoneDAL phoneDAL = new PhoneDAL();
            List<int> phonePrice = phoneDAL.GetPhonePrices();

            return phonePrice;
        }

        public List<String> getDescriptionList()
        {
            PhoneDAL phoneDAL = new PhoneDAL();
            List<String> phoneDescriptions = phoneDAL.getPhoneDescription();

            return phoneDescriptions;
        }

    }
}
