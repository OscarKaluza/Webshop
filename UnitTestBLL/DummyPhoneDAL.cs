using Webshop.BLL.Phone;

namespace Webshop.DAL.Phone
{
	public class DummyPhoneDAL : Iphone
	{
		public List<PhoneDTO> allPhones { get; set; }
		public PhoneDTO Phone { get; set; }

        public List<PhoneDTO> RetrievePhones()
		{
			allPhones = new List<PhoneDTO>();
			PhoneDTO phone = new PhoneDTO
			{
				ID = 1,
				Brand = "test",
				Model = "test",
				Description = "test",
				Price = 800
			};

            allPhones.Add(phone);


            return allPhones;
		}

		public void AddPhoneInDatabase(PhoneDTO phonedto)
		{
			phonedto.ID = 1;
			phonedto.Brand = "test";
			phonedto.Model = "test";
			phonedto.Description = "test";
			phonedto.Price = 800;
			Phone = phonedto;
		}

		public bool DeletePhoneFromDatabase(PhoneDTO phone)
		{
			allPhones = new List<PhoneDTO>
			{
				new PhoneDTO
				{
					ID = 1,
					Brand = "test",
					Model = "test",
					Description = "test",
					Price = 800
				}
			};

			var phoneToDelete = allPhones.FirstOrDefault(p => p.ID == phone.ID);

			if (phoneToDelete != null)
			{
				allPhones.Remove(phoneToDelete);
				return true;
			}

			return false;
		}

		public void UpdatePhoneInDatabase(PhoneDTO existingPhone)
		{
            existingPhone = new PhoneDTO
			{
				ID = 1,
				Brand = "test",
				Model = "test",
				Description = "test",
				Price = 800
			};

			Phone = existingPhone;
		}

	}
}
