using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AutoService
{
    class DataBase
    {

        string connectionString;
        SqlConnection connection;

        public void OpenConnection()
        {
            connectionString = @"Data Source=SQLDEM\SQLDEM;Initial Catalog=pr1-22-vodyannikoves_ISRPO;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public List<Payment> GetPayments()
        {
            OpenConnection();
            int count = GetStrings("Payment");
            List<Payment> payments = new List<Payment>();
            for (int i = 0; i < count; ++i)
            {
                string sqlExp = "Select * From Payment Where PaymentID = " + i.ToString();
                SqlCommand command = new SqlCommand(sqlExp, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string Name = reader.GetString(reader.GetOrdinal("Name"));
                    int Count = reader.GetInt32(reader.GetOrdinal("Count"));
                    double Cost = reader.GetDouble(reader.GetOrdinal("Cost"));
                    string Destination = reader.GetString(reader.GetOrdinal("Destination"));
                    string Date = reader.GetString(reader.GetOrdinal("Date"));
                    string Category = reader.GetString(reader.GetOrdinal("CattID"));
                    Category = GetCategory(Category);
                    payments.Add(new Payment(Name, Category, Destination, Count, Cost, Date));
                }
            }
            return payments;
        }

        public string GetCategory(string CattID)
        {
            string sqlExp = "Select * From Category Where CattID = " + CattID;
            SqlCommand command = new SqlCommand(sqlExp, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader.GetString(reader.GetOrdinal("Name"));
        }

        public bool Login(string Login, string Password)
        {
            OpenConnection();
            string sqlExp = "Select * From Client Where Login = '" + Login + "' and Password = '" + Password + "'";
            SqlCommand command = new SqlCommand(sqlExp, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader.HasRows ? true : false;
        }


        public int GetStrings(string Table)
        {
            string sqlExp = "Select * From " + Table;
            SqlCommand command = new SqlCommand(sqlExp, connection);
            return (int)command.ExecuteScalar();
        }



        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
