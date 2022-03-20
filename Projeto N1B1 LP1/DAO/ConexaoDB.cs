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
            // Connection String Kauan
            //string connectionString = "server = .\\SQLexpress; database=TrabalhoLP1N1B1; integrated security = true";
            
            string connectionString = "server = LOCALHOST; database=TrabalhoLP1N1B1; integrated security = true";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}
