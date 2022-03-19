using Projeto_N1B1_LP1.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_N1B1_LP1.DAO
{
    public static class HelperDAO
    {
        public static void ExecuteSQL(string sql, SqlParameter[] sqlParameters)
        {
            using (var connection = ConexaoDB.GetDbConnection())
            {
                using (var sqlCommand = new SqlCommand(sql, connection))
                {
                    sqlCommand.Parameters.AddRange(sqlParameters);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public static DataTable ExecuteSelect(string sql, SqlParameter[] parameters = null)
        {
            using (var connection = ConexaoDB.GetDbConnection())
            {
                using (var adapter = new SqlDataAdapter(sql, connection))
                {
                    DataTable table = new DataTable();

                    if (parameters != null)
                        adapter.SelectCommand.Parameters.AddRange(parameters);

                    adapter.Fill(table);
                    return table;
                }
            }
        }
    }
}
