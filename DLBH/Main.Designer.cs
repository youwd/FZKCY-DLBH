
namespace DLBH
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDLBH = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDZQX = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDuanZQX = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelMapSelectionCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.查询ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1444, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewDoc,
            this.OpenDoc,
            this.SaveDoc,
            this.退出ToolStripMenuItem,
            this.Exit});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(82, 35);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // NewDoc
            // 
            this.NewDoc.Name = "NewDoc";
            this.NewDoc.Size = new System.Drawing.Size(359, 44);
            this.NewDoc.Text = "新建";
            this.NewDoc.Click += new System.EventHandler(this.NewDoc_Click);
            // 
            // OpenDoc
            // 
            this.OpenDoc.Name = "OpenDoc";
            this.OpenDoc.Size = new System.Drawing.Size(359, 44);
            this.OpenDoc.Text = "打开";
            this.OpenDoc.Click += new System.EventHandler(this.OpenDoc_Click);
            // 
            // SaveDoc
            // 
            this.SaveDoc.Name = "SaveDoc";
            this.SaveDoc.Size = new System.Drawing.Size(359, 44);
            this.SaveDoc.Text = "保存";
            this.SaveDoc.Click += new System.EventHandler(this.SaveDoc_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(356, 6);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(359, 44);
            this.Exit.Text = "退出";
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchDLBH,
            this.searchDZQX,
            this.searchDuanZQX,
            this.clearSelect});
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(82, 35);
            this.查询ToolStripMenuItem.Text = "查询";
            // 
            // searchDLBH
            // 
            this.searchDLBH.Name = "searchDLBH";
            this.searchDLBH.Size = new System.Drawing.Size(291, 44);
            this.searchDLBH.Text = "道路病害卡";
            this.searchDLBH.Click += new System.EventHandler(this.searchDLBH_Click);
            // 
            // searchDZQX
            // 
            this.searchDZQX.Name = "searchDZQX";
            this.searchDZQX.Size = new System.Drawing.Size(291, 44);
            this.searchDZQX.Text = "点状缺陷";
            this.searchDZQX.Click += new System.EventHandler(this.searchDZQX_Click);
            // 
            // searchDuanZQX
            // 
            this.searchDuanZQX.Name = "searchDuanZQX";
            this.searchDuanZQX.Size = new System.Drawing.Size(291, 44);
            this.searchDuanZQX.Text = "段状缺陷";
            this.searchDuanZQX.Click += new System.EventHandler(this.searchDuanZQX_Click);
            // 
            // clearSelect
            // 
            this.clearSelect.Name = "clearSelect";
            this.clearSelect.Size = new System.Drawing.Size(291, 44);
            this.clearSelect.Text = "清空查询状态";
            this.clearSelect.Click += new System.EventHandler(this.clearSelect_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.labelMapSelectionCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 839);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1444, 41);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 31);
            this.toolStripStatusLabel1.Text = "   ";
            // 
            // labelMapSelectionCount
            // 
            this.labelMapSelectionCount.Margin = new System.Windows.Forms.Padding(20, 6, 0, 4);
            this.labelMapSelectionCount.Name = "labelMapSelectionCount";
            this.labelMapSelectionCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelMapSelectionCount.Size = new System.Drawing.Size(28, 31);
            this.labelMapSelectionCount.Text = "  ";
            this.labelMapSelectionCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axToolbarControl1.Location = new System.Drawing.Point(0, 39);
            this.axToolbarControl1.Margin = new System.Windows.Forms.Padding(4);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(1444, 28);
            this.axToolbarControl1.TabIndex = 2;
            this.axToolbarControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IToolbarControlEvents_Ax_OnMouseDownEventHandler(this.axToolbarControl1_OnMouseDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5537F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.4463F));
            this.tableLayoutPanel1.Controls.Add(this.axTOCControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.axMapControl1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 67);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1444, 772);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTOCControl1.Location = new System.Drawing.Point(4, 4);
            this.axTOCControl1.Margin = new System.Windows.Forms.Padding(4);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(317, 764);
            this.axTOCControl1.TabIndex = 0;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(329, 4);
            this.axMapControl1.Margin = new System.Windows.Forms.Padding(4);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(1111, 764);
            this.axMapControl1.TabIndex = 1;
            this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl1_OnMouseDown);
            this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 641);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 37;
            this.dataGridView.Size = new System.Drawing.Size(1444, 198);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(587, 652);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 880);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "道路病害查询分析系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewDoc;
        private System.Windows.Forms.ToolStripMenuItem OpenDoc;
        private System.Windows.Forms.ToolStripMenuItem SaveDoc;
        private System.Windows.Forms.ToolStripSeparator 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchDLBH;
        private System.Windows.Forms.ToolStripMenuItem searchDZQX;
        private System.Windows.Forms.ToolStripMenuItem searchDuanZQX;
        private System.Windows.Forms.ToolStripMenuItem clearSelect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private System.Windows.Forms.ToolStripStatusLabel labelMapSelectionCount;
        private System.Windows.Forms.DataGridView dataGridView;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
    }
}

