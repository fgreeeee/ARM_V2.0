using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ARM_V2._0
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TBM1C6HF\SQLEXPRESS;Initial Catalog = Bank; Integrated Security=true");


        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }

    }
}
    