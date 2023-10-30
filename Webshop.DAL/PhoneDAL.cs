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

        public List<string> GetPhoneBrands()
        {
            List<string> brands = new List<string>();

            string sqlQuery = "SELECT Brand FROM phone;";

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
                            brands.Add(brand);
                        }
                    }
                }
            }

            return brands;
        }

        public List<string> GetPhoneModels()
        {
            List<string> models = new List<string>();

            string sqlQuery = "SELECT Model FROM phone;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(sqlQuery, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string model = reader["Model"].ToString();
                            models.Add(model);
                        }
                    }
                }
            }

            return models;
        }

        public List<int> GetPhonePrices()
        {
            List<int> prices = new List<int>();

            string sqlQuery = "SELECT Price FROM phone;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(sqlQuery, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int price = (int)reader["Price"];
                            prices.Add(price);
                        }
                    }
                }
            }

            return prices;
        }

        public List<string> getPhoneDescription()
        {
            List<string> description = new List<string>();

            string sqlQuery = "SELECT description FROM phone;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(sqlQuery, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string descriptions = reader["Description"].ToString();
                            description.Add(descriptions);
                        }
                    }
                }
            }

            return description;
        }


    }
}
