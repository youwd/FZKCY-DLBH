
namespace DLBH
{
    partial class FormSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("图层");
            this.treeViewLayers = new System.Windows.Forms.TreeView();
            this.labelMapSelectionCount = new System.Windows.Forms.Label();
            this.labelLayerSelectionCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewLayers
            // 
            this.treeViewLayers.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewLayers.Location = new System.Drawing.Point(0, 0);
            this.treeViewLayers.Name = "treeViewLayers";
            treeNode2.Name = "节点0";
            treeNode2.Text = "图层";
            this.treeViewLayers.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeViewLayers.Size = new System.Drawing.Size(277, 948);
            this.treeViewLayers.TabIndex = 2;
            this.treeViewLayers.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // labelMapSelectionCount
            // 
            this.labelMapSelectionCount.AutoSize = true;
            this.labelMapSelectionCount.Location = new System.Drawing.Point(3, 0);
            this.labelMapSelectionCount.Name = "labelMapSelectionCount";
            this.labelMapSelectionCount.Size = new System.Drawing.Size(214, 24);
            this.labelMapSelectionCount.TabIndex = 4;
            this.labelMapSelectionCount.Text = "共选择了 0 个要素";
            // 
            // labelLayerSelectionCount
            // 
            this.labelLayerSelectionCount.AutoSize = true;
            this.labelLayerSelectionCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelLayerSelectionCount.Location = new System.Drawing.Point(626, 3);
            this.labelLayerSelectionCount.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelLayerSelectionCount.Name = "labelLayerSelectionCount";
            this.labelLayerSelectionCount.Size = new System.Drawing.Size(286, 41);
            this.labelLayerSelectionCount.TabIndex = 5;
            this.labelLayerSelectionCount.Text = "当前图层选择了 0 个要素";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(277, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(921, 948);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.8306F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.1694F));
            this.tableLayoutPanel2.Controls.Add(this.labelMapSelectionCount, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelLayerSelectionCount, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 901);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(915, 44);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 37;
            this.dataGridView.Size = new System.Drawing.Size(915, 892);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // FormSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 948);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.treeViewLayers);
            this.Name = "FormSelection";
            this.Text = "元素选择集";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSelection_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewLayers;
        private System.Windows.Forms.Label labelMapSelectionCount;
        private System.Windows.Forms.Label labelLayerSelectionCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}