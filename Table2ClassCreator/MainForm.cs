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
    public partial class MainForm : Form
    {
        ISqlHelper sql;
        public MainForm()
        {
            InitializeComponent();
        }

        #region 各种委托方法
        void setSqlHelper(ISqlHelper helper)
        {
            sql = helper;
        }
        #endregion

        #region clbTable 的相关方法(包括右键菜单)

        private void clbTable_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                Point p = e.Location;
                int index = clbTable.IndexFromPoint(p);
                clbTable.SelectedIndex = index;
            }
        }

        private void clbTable_DoubleClick(object sender, EventArgs e)
        {
            string tableName = (sender as CheckedListBox).Text;
            if (string.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("你没有选择任何表",
                    "出错了!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                //打开指定的 Form
            }
        }

        #region clbTable 的右键菜单相关方法
        private void 查看表结构ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tableName = clbTable.SelectedItem as string;
            string cmd = string.Format("SHOW COLUMNS FROM {0};", tableName);
            DataTable dt = sql.ExecuteDataTable(cmd);
            dt.TableName = tableName;
            dgvForm dgv = new dgvForm(dt);
            dgv.MdiParent = this;
            dgv.Show();
        }

        private void 生成类文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            string tableName = clbTable.SelectedItem as string;
            string cmd = string.Format("SELECT * FROM {0} LIMIT 1", tableName);
            DataTable dt = sql.ExecuteDataTable(cmd);
            string strDisplay = TableClassFileCreator.CreateString(dt);
            cmdTextDisplayForm dialog = new cmdTextDisplayForm(tableName, strDisplay);
            dialog.ShowDialog();
        }

        #endregion

        #endregion

        #region 工具栏的相关方法
        private void tsmSetting_Click(object sender, EventArgs e)
        {
            startupOption d = new startupOption();
            d.setConnection += new startupOption.SetConnection(setSqlHelper);
            d.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (sql == null) return;
            clbTable.Items.Clear();
            DataTable dt = sql.ExecuteDataTable("show tables;");
            foreach (DataRow dr in dt.Rows)
            {
                clbTable.Items.Add(dr[0]);
            }
        }

        private void tsbCloseAllWindow_Click(object sender, EventArgs e)
        {
            foreach(Form item in MdiChildren)
            {
                item.Close();
            }
        }

        #endregion

        private void 预览表内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tableName = clbTable.SelectedItem as string;
            string cmd = string.Format("SELECT * FROM {0} LIMIT 100;", tableName);
            DataTable dt = sql.ExecuteDataTable(cmd);
            dt.TableName = tableName;
            dgvForm dgv = new dgvForm(dt);
            dgv.MdiParent = this;
            dgv.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tsbSaveAll_Click(object sender, EventArgs e)
        {

        }
    }
}
