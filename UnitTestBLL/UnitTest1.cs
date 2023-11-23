using Webshop.BLL.Phone;
using Webshop.DAL.Phone;

namespace UnitTestBLL
{
    public class UnitTest1
    {
        [Fact]
        public void Test_GetPhones_Function()
        {
            DummyPhoneDAL phoneDAL = new DummyPhoneDAL();
            PhoneService phoneservice = new PhoneService(phoneDAL);
            PhoneDTO exepectedPhone = new PhoneDTO
            {
                ID = 1,
                Brand = "test",
                Model = "test",
                Description = "test",
                Price = 800
            };

            Assert.NotEmpty(phoneservice.GetPhones());
            Assert.NotNull(phoneservice.GetPhones());
            Assert.IsType<List<Phone>>(phoneservice.GetPhones());

            Assert.Equal(exepectedPhone.ID, phoneDAL.allPhones[0].ID);
            Assert.Equal(exepectedPhone.Brand, phoneDAL.allPhones[0].Brand);
            Assert.Equal(exepectedPhone.Model, phoneDAL.allPhones[0].Model);
            Assert.Equal(exepectedPhone.Description, phoneDAL.allPhones[0].Description);
            Assert.Equal(exepectedPhone.Price, phoneDAL.allPhones[0].Price);
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
            phoneDAL.Phone = newModifiedPhone;


            Assert.Equal(newModifiedPhone, phoneDAL.Phone);
        }
}
}