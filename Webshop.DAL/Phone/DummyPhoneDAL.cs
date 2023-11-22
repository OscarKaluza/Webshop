using Webshop.BLL.Phone;

namespace Webshop.DAL.Phone
{
	public class DummyPhoneDAL : IphoneDAL
	{
		public List<PhoneDTO> allPhones { get; set; }
		public PhoneDTO Phone { get; set; }

		public List<PhoneDTO> RetrievePhones()
		{
			allPhones = new List<PhoneDTO>();
			Phone = new PhoneDTO();
		
			allPhones.Add(Phone);
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

		public void UpdatePhoneInDatabase(PhoneDTO phone)
		{
			phone.ID = 1;
			phone.Brand = "test";
			phone.Model = "test";
			phone.Description = "test";
			phone.Price = 800;
			Phone = phone;
		}

	}
}
