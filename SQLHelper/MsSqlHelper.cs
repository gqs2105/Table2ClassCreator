using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQLHelper
{
    class MsSqlHelper : ISqlHelper
    {
        SqlConnection sqlcon = new SqlConnection();
        public MsSqlHelper(SqlInfo sqlinfo)
        {
            int i = 0;
        }

        public DataTable ExecuteDataTable(string cmdText)
        {
            throw new NotImplementedException();
        }

        public int ExecuteNonQuery(string cmdText)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = sqlcon;
            com.CommandText = "SELECT * FROM TABLE";
            return com.ExecuteNonQuery();
        }

        public bool TestConnection()
        {
            SqlCommand com = new SqlCommand();
            com.Connection = sqlcon;
            com.CommandText = "SELECT * FROM TABLE";
            com.ExecuteNonQuery();
            throw new NotImplementedException();
        }
    }
}
