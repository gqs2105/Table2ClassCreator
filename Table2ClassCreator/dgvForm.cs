using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Table2ClassCreator
{
    public partial class dgvForm : Form
    {
        public dgvForm(DataTable datatable)
        {
            InitializeComponent();
            dataGridView1.DataSource = datatable;
            Text = datatable.TableName + " 表的结构";
        }

        private void dgvForm_Load(object sender, EventArgs e)
        {
            int width = 0, height = 0;
            foreach (DataGridViewColumn dc in dataGridView1.Columns)
            {
                width += dc.Width;
            }
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                height += dr.Height;
            }

            if (height > 370)
            {
                Width = width + 36;
                Height = 370;
            }
            else
            {
                Width = width + 20;
                Height = height + 80;
            }
            if(Width > MdiParent.Width - 280)
            {
                Width = MdiParent.Width - 280;
            }
        }
    }
}
