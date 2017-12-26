using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SQLHelper
{
    public class MySqlHelper : ISqlHelper
    {
        MySqlConnection con;

        public MySqlHelper(SqlInfo sqlInfo)
        {
            con = new MySqlConnection();
            con.ConnectionString = string.Format("server={0};port={1};user id={2};password={3};database={4};",
                sqlInfo.Server,
                sqlInfo.Port,
                sqlInfo.UserId,
                sqlInfo.Password,
                sqlInfo.Database);
        }

        public DataTable ExecuteDataTable(string cmdText)
        {
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmdText, con))
            {
                adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public int ExecuteNonQuery(string cmdText)
        {
            int result = 0;
            MySqlCommand com = new MySqlCommand(cmdText, con);
            try
            {
                if (!string.IsNullOrEmpty(cmdText))
                    result = com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "错误!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                result = -1;
            }
            return result;
        }

        public bool TestConnection()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (MySqlException e)
            {                
                throw e;
            }
        }        
    }
}
