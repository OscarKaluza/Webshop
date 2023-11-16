using Org.BouncyCastle.Asn1;
using Webshop.BLL.Phone;
using Webshop.DAL.Phone;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace UnitTestBLL
{
    public class UnitTest1
    {
        [Fact]
        public void check_if_getphone_list_is_not_empty()
        {
            PhoneService phoneservice = new PhoneService(new DummyPhoneDAL());

            Assert.NotEmpty(phoneservice.GetPhones());
        }

        [Fact]
        public void check_if_phone_list_returns_phones()
        {
            PhoneService phoneservice = new PhoneService(new DummyPhoneDAL());

            var result = phoneservice.GetPhones();

            Assert.IsType<List<Phone>>(result);
        }


        [Fact]

        public void check_if_phone_is_being_added()
        {
            PhoneService phoneservice = new PhoneService(new DummyPhoneDAL());
            Phone newTestPhone = new Phone();

            newTestPhone.Brand = "test";
            newTestPhone.Model = "test";
            newTestPhone.Description = "test";
            newTestPhone.Price = 2;


            phoneservice.AddPhone(newTestPhone);

            Assert.

        }
        

    }
}