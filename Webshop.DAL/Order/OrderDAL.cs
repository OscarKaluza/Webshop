using MySql.Data.MySqlClient;
using System;
using Webshop.BLL.Order;

namespace Webshop.DAL.Order
{
    public class OrderDAL : IOrder
    {
        private string connectionString = "Server=studmysql01.fhict.local; Port=3306;Database=dbi515670;User=dbi515670;Password=Tua1X#TbOS;";
        public int RegisterOrder(int customerID, int total)
        {
            string sqlQuery = "INSERT INTO `orders`(`CustomerID`, `Total`) VALUES (@customerID, @total); SELECT LAST_INSERT_ID();";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    command.Parameters.AddWithValue("@Total", total);

                    int orderId = Convert.ToInt32(command.ExecuteScalar());

                    return orderId;
                }
            }
        }


        public void RegisterOrderDetails(int orderid, int phoneid, int quantity, int price)
        {
            string sqlQuery = "INSERT INTO `order_details`(`OrderID`, `PhoneID`, `Quantity`, `Price`) VALUES (@orderid, @phoneid, @quantity, @price)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@OrderID", orderid);
                    command.Parameters.AddWithValue("@PhoneID", phoneid);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Price", price);

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}