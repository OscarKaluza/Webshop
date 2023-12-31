﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.BLL.Phone;

namespace Webshop.BLL.Phone
{
    public class PhoneService
    {
        private List<Phone> Phones = new List<Phone>();
        Iphone Iphone;

        public PhoneService(Iphone phone) 
        { 
            Iphone = phone;
        }

        public List<Phone> GetPhones()
        {
            List<PhoneDTO> phoneDTOs = Iphone.RetrievePhones();

            foreach (var phoneDTO in phoneDTOs)
            {
                Phone phone = new Phone
                {
                    ID = phoneDTO.ID,
                    Brand = phoneDTO.Brand,
                    Model = phoneDTO.Model,
                    Price = phoneDTO.Price,
                    Description = phoneDTO.Description
                };
                Phones.Add(phone);
            }

            return Phones;
        }

        public void AddPhone(Phone phone)
        {
            if (phone.Price < 0)
            {
                throw new InvalidOperationException("Price cannot be less then 0");
            }

            PhoneDTO newPhone = new PhoneDTO
            {
                Brand = phone.Brand,
                Model = phone.Model,
                Description = phone.Description,
                Price = phone.Price 
            };

            Iphone.AddPhoneInDatabase(newPhone);
        }

        public bool DeletePhone(Phone phone)
        {
            PhoneDTO phoneToDelete = new PhoneDTO
            {
                ID = phone.ID,
                Brand = phone.Brand,
                Model = phone.Model,
                Description = phone.Description,
                Price = phone.Price
            };

            if (Iphone.DeletePhoneFromDatabase(phoneToDelete))
            {
                return true;
            }

            return false;
        }

        public PhoneDTO ModifyPhone(Phone phone)
        {
            if (phone.Price < 0)
            {
                throw new InvalidOperationException("Price cannot be less then 0");
            }

            PhoneDTO modifiedPhone = new PhoneDTO
			{
				ID = phone.ID,
				Brand = phone.Brand,
				Model = phone.Model,
				Description = phone.Description,
				Price = phone.Price
			};

            Iphone.UpdatePhoneInDatabase(modifiedPhone);
            return modifiedPhone;
        }

    }
}
