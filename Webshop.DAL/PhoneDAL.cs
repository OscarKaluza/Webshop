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

            string sqlQuery = "SELECT DISTINCT Brand FROM phone;";

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

    }
}
