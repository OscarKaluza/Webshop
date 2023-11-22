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
            }, phoneDAL.Phone);

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
            DummyPhoneDAL phoneDAL = new DummyPhoneDAL();
            PhoneService phoneService = new PhoneService(phoneDAL);

            Phone phoneToModify = new Phone
            {
                ID = 2,
                Brand = "test2",
                Model = "test2",
                Description = "test2",
                Price = 900
            };

            PhoneDTO newModifiedPhone = phoneService.ModifyPhone(phoneToModify);

			Assert.Equal(newModifiedPhone, phoneDAL.Phone);
        }

    }
}