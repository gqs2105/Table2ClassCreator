namespace Table2ClassCreator
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.clbTable = new System.Windows.Forms.CheckedListBox();
            this.cmsForClbTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看表结构ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.预览表内容ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成类文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslSetting = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbCloseAllWindow = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1.SuspendLayout();
            this.cmsForClbTable.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1143, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel1.Text = "[0/100]";
            // 
            // clbTable
            // 
            this.clbTable.ContextMenuStrip = this.cmsForClbTable;
            this.clbTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.clbTable.FormattingEnabled = true;
            this.clbTable.Location = new System.Drawing.Point(0, 25);
            this.clbTable.Name = "clbTable";
            this.clbTable.Size = new System.Drawing.Size(240, 544);
            this.clbTable.TabIndex = 3;
            this.clbTable.DoubleClick += new System.EventHandler(this.clbTable_DoubleClick);
            this.clbTable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clbTable_MouseDown);
            // 
            // cmsForClbTable
            // 
            this.cmsForClbTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看表结构ToolStripMenuItem,
            this.预览表内容ToolStripMenuItem,
            this.生成类文件ToolStripMenuItem});
            this.cmsForClbTable.Name = "cmsForClbTable";
            this.cmsForClbTable.Size = new System.Drawing.Size(137, 70);
            // 
            // 查看表结构ToolStripMenuItem
            // 
            this.查看表结构ToolStripMenuItem.Name = "查看表结构ToolStripMenuItem";
            this.查看表结构ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.查看表结构ToolStripMenuItem.Text = "查看表结构";
            this.查看表结构ToolStripMenuItem.Click += new System.EventHandler(this.查看表结构ToolStripMenuItem_Click);
            // 
            // 预览表内容ToolStripMenuItem
            // 
            this.预览表内容ToolStripMenuItem.Name = "预览表内容ToolStripMenuItem";
            this.预览表内容ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.预览表内容ToolStripMenuItem.Text = "预览表内容";
            this.预览表内容ToolStripMenuItem.Click += new System.EventHandler(this.预览表内容ToolStripMenuItem_Click);
            // 
            // 生成类文件ToolStripMenuItem
            // 
            this.生成类文件ToolStripMenuItem.Name = "生成类文件ToolStripMenuItem";
            this.生成类文件ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.生成类文件ToolStripMenuItem.Text = "生成类文件";
            this.生成类文件ToolStripMenuItem.Click += new System.EventHandler(this.生成类文件ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslSetting,
            this.toolStripButton1,
            this.tsbCloseAllWindow,
            this.toolStripLabel1,
            this.tsbSaveAll,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1143, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslSetting
            // 
            this.tslSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslSetting.Image = ((System.Drawing.Image)(resources.GetObject("tslSetting.Image")));
            this.tslSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslSetting.Name = "tslSetting";
            this.tslSetting.Size = new System.Drawing.Size(84, 22);
            this.tslSetting.Text = "设置连接参数";
            this.tslSetting.Click += new System.EventHandler(this.tsmSetting_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(92, 22);
            this.toolStripButton1.Text = "读取所有表(名)";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbCloseAllWindow
            // 
            this.tsbCloseAllWindow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCloseAllWindow.Image = ((System.Drawing.Image)(resources.GetObject("tsbCloseAllWindow.Image")));
            this.tsbCloseAllWindow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCloseAllWindow.Name = "tsbCloseAllWindow";
            this.tsbCloseAllWindow.Size = new System.Drawing.Size(96, 22);
            this.tsbCloseAllWindow.Text = "关闭所有子窗口";
            this.tsbCloseAllWindow.Click += new System.EventHandler(this.tsbCloseAllWindow_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel1.Text = "测试";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // tsbSaveAll
            // 
            this.tsbSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSaveAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveAll.Image")));
            this.tsbSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveAll.Name = "tsbSaveAll";
            this.tsbSaveAll.Size = new System.Drawing.Size(60, 22);
            this.tsbSaveAll.Text = "全部保存";
            this.tsbSaveAll.Click += new System.EventHandler(this.tsbSaveAll_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel2.Text = "帮助";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 591);
            this.Controls.Add(this.clbTable);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "strDisplay";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cmsForClbTable.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckedListBox clbTable;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbCloseAllWindow;
        private System.Windows.Forms.ContextMenuStrip cmsForClbTable;
        private System.Windows.Forms.ToolStripMenuItem 查看表结构ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成类文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 预览表内容ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tslSetting;
        private System.Windows.Forms.ToolStripButton tsbSaveAll;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}

