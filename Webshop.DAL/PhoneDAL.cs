using MySql.Data.MySqlClient;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.DAL
{
    public class PhoneDAL
    {
        private string connectionString = "Server=studmysql01.fhict.local; Port=3306;Database=dbi515670;User=dbi515670;Password=Tua1X#TbOS;";


        public List<PhoneDTO> RetrievePhones()
        {
            List<PhoneDTO> phoneDTOs = new List<PhoneDTO>();

            string sqlQuery = "SELECT Brand, Model, Price, Description FROM phone;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(sqlQuery, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string brand = reader["Brand"].ToString();
                            string model = reader["Model"].ToString();
                            int price = (int)reader["Price"];
                            string description = reader["Description"].ToString();

                            PhoneDTO phoneDTO = new PhoneDTO
                            {
                                Brand = brand,
                                Model = model,
                                Price = price,
                                Description = description
                            };

                            phoneDTOs.Add(phoneDTO);
                        }
                    }
                }
            }

            return phoneDTOs;
        }


    }
}
