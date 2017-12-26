using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLHelper;

namespace Table2ClassCreator
{
    public partial class startupOption : Form
    {
        public delegate void SetConnection(ISqlHelper helper);
        public SetConnection setConnection;
        public startupOption()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            SqlInfo sqlinfo = new SqlInfo(SqlType.MYSQL);
            sqlinfo.Server = tbServer.Text.Trim();
            sqlinfo.Port = Convert.ToInt32(tbPort.Text);
            sqlinfo.UserId = tbName.Text.Trim();
            sqlinfo.Password = tbPwd.Text;
            sqlinfo.Database = tbDb.Text;

            ISqlHelper mangos = SqlHelperCreator.Create(sqlinfo);
            try
            {
                if (mangos.TestConnection())
                    MessageBox.Show("连接成功!");
                setConnection(mangos);
                Close();
                Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNoDbConnection_Click(object sender, EventArgs e)
        {

        }
    }
}
