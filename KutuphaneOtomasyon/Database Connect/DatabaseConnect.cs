using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KutuphaneOtomasyon.Database_Connect
{
    public class DatabaseConnect
    {
        public static SqlConnection dbConnection()
        {
            // veritabanı bağlantı 
            string connectionString = @"Data Source=DESKTOP-B6EP79G;Initial 
            Catalog=KutuphaneOtomasyon;Integrated Security=True;MultipleActiveResultSets=True";

            SqlConnection connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            return connection;
        }

    }

}
