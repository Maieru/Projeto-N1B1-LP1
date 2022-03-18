using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_N1B1_LP1.DAO
{
    public static class ConexaoDB
    {
        public static SqlConnection GetDbConnection()
        {
            string connectionString = "data source=LOCALHOST; database=TrabalhoLP1N1B1; user id=sa; password=123456";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}
