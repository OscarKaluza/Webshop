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
            DummyPhoneDAL phoneDAL = new DummyPhoneDAL();
            PhoneService phoneservice = new PhoneService(phoneDAL);

            phoneservice.AddPhone(new Phone
            {
                Brand = "test",
                Model = "test",
                Description = "test",
                Price = 800
            });
     
            Assert.Equal(new PhoneDTO
            {
                ID = 1,
                Brand = "test",
                Model = "test",
                Description = "test",
                Price = 800
            }, phoneDAL.InsertedPhone);

        }

        [Fact]
        public void Check_If_Phone_Is_Successfully_Deleted()
        {
            DummyPhoneDAL phoneDAL = new DummyPhoneDAL();
            PhoneService phoneService = new PhoneService(phoneDAL);

            phoneService.DeletePhone(new Phone
            {
				ID = 1,
				Brand = "test",
				Model = "test",
				Description = "test",
				Price = 800
			});
            Assert.Empty(phoneDAL.allPhones);
        }


        [Fact]
        public void check_if_phone_is_modified_succesfully()
        {
            PhoneService phoneService = new PhoneService(new DummyPhoneDAL());
            Phone newTestPhone = new Phone();

            newTestPhone.ID = 1;
            newTestPhone.Brand = "Test";
            newTestPhone.Model = "Test";
            newTestPhone.Description = "Test";
            newTestPhone.Price = 800;

            Assert.True(phoneService.ModifyPhone(newTestPhone.ID, newTestPhone.Brand, newTestPhone.Model, newTestPhone.Description, newTestPhone.Price));
        }

		
	}
}