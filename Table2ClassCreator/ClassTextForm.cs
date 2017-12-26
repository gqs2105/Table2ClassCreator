using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Table2ClassCreator
{
    public partial class ClassTextForm : Form
    {
        public delegate int ExecuteCmdText(string cmdText);
        public ExecuteCmdText executeCmdText;
        string tableName;
        public ClassTextForm(string tableName, string cmdText)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            rtbDisplay.Text = cmdText;
            lTips.Visible = false;
            this.tableName = tableName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbDisplay.Text);
            lTips.Visible = true;
            Thread th = new Thread(new ThreadStart(setTipsVisible));
            th.Start();
        }

        void setTipsVisible()
        {
            Thread.Sleep(3000);
            lTips.Visible = false;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "c#文件 (*.cs)|文本文件 (*.txt)";
            sfd.FileName = tableName + ".cs";            
            if(sfd.ShowDialog()==DialogResult.OK)
            {
                string fullName = sfd.FileName;
                StreamWriter myStream = new StreamWriter(sfd.FileName);
                myStream.Write(rtbDisplay.Text);
                myStream.Flush();
                myStream.Close();
            }
        }
    }
}
