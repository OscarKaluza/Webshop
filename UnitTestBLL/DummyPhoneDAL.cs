using Webshop.BLL.Phone;

namespace Webshop.DAL.Phone
{
	public class DummyPhoneDAL : Iphone
	{
		public List<PhoneDTO> AllPhones { get; private set; }
		public PhoneDTO Phone { get; set; }

        public List<PhoneDTO> RetrievePhones()
		{
			AllPhones = new List<PhoneDTO>();
			PhoneDTO phone = new PhoneDTO
			{
				ID = 1,
				Brand = "test",
				Model = "test",
				Description = "test",
				Price = 800
			};

            AllPhones.Add(phone);

            return AllPhones;
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
			AllPhones = new List<PhoneDTO>
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

			var phoneToDelete = AllPhones.FirstOrDefault(p => p.ID == phone.ID);

			if (phoneToDelete != null)
			{
				AllPhones.Remove(phoneToDelete);
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
