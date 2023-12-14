using MySql.Data.MySqlClient;
using Webshop.BLL.Phone;

namespace Webshop.DAL.Phone
{
    public class PhoneDAL : Iphone
    {
        private string connectionString = "Server=studmysql01.fhict.local; Port=3306;Database=dbi515670;User=dbi515670;Password=Tua1X#TbOS;";
        public List<PhoneDTO> RetrievePhones()
        {
            List<PhoneDTO> phoneDTOs = new List<PhoneDTO>();

            string sqlQuery = "SELECT ID, Brand, Model, Price, Description FROM phone;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(sqlQuery, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["ID"];
                            string brand = reader["Brand"].ToString();
                            string model = reader["Model"].ToString();
                            int price = (int)reader["Price"];
                            string description = reader["Description"].ToString();

                            PhoneDTO phoneDTO = new PhoneDTO
                            {
                                ID = id,
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

        public void AddPhoneInDatabase(PhoneDTO phone)
        {
            string sqlQuery = "INSERT INTO `phone`(Brand, Model, Description, Price) VALUES(@brand, @model, @description, @price)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@brand", phone.Brand);
                        command.Parameters.AddWithValue("@model", phone.Model);
                        command.Parameters.AddWithValue("@description", phone.Description);
                        command.Parameters.AddWithValue("@price", phone.Price);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        public bool DeletePhoneFromDatabase(PhoneDTO phone)
        {
            string sqlQuery = "DELETE FROM `phone` WHERE id = @id";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", phone.ID);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }

                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public void UpdatePhoneInDatabase(PhoneDTO phone)
        {
            string sqlQuery = "UPDATE `phone` SET Brand = @brand, Model = @model, Description = @description, Price = @price WHERE ID = @ID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ID", phone.ID);
                        command.Parameters.AddWithValue("@brand", phone.Brand);
                        command.Parameters.AddWithValue("@model", phone.Model);
                        command.Parameters.AddWithValue("@description", phone.Description);
                        command.Parameters.AddWithValue("@price", phone.Price);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }




    }
}