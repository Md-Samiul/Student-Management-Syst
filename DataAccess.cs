using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Framework
{
    public class DataAccess
    {
        string connectionString = "Data Source=Hafiz-PC;Initial Catalog=StudentDB;Integrated Security=True";
        public void Execute(SqlCommand command)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            command.Connection = connection;
            connection.Open();


            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable Query(SqlCommand query)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            query.Connection = connection;
            SqlDataAdapter da = new SqlDataAdapter(query);
            connection.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();

            return dt;
        }
    }
}
