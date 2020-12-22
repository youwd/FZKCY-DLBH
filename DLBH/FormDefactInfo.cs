using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLBH
{
    public partial class FormDefactInfo : Form
    {
        public FormDefactInfo()
        {
            InitializeComponent();
        }

        public void UpdateData(DataGridViewRow selectData,int flagSelect)
        {
            //this.label2.Text = selectData.Cells[13].Value.ToString();
            //this.label4.Text = selectData.Cells[22].Value.ToString() + "-"+ selectData.Cells[23].Value.ToString();
            //this.label6.Text = selectData.Cells[5].Value.ToString();
            //this.label8.Text = selectData.Cells[7].Value.ToString();
            //this.label10.Text = selectData.Cells[9].Value.ToString();
            //this.label12.Text = selectData.Cells[10].Value.ToString();
            //this.label14.Text = selectData.Cells[12].Value.ToString();

            this.label2.Text = selectData.Cells[0].Value.ToString();
            this.label4.Text = selectData.Cells[1].Value.ToString();
            this.label6.Text = selectData.Cells[1].Value.ToString();
            this.label8.Text = selectData.Cells[1].Value.ToString();
            this.label10.Text = selectData.Cells[1].Value.ToString();
            this.label12.Text = selectData.Cells[1].Value.ToString();
            this.label14.Text = selectData.Cells[1].Value.ToString();

            //string lx = selectData.Cells[12].Value.ToString() == "雨水" ? "ys" : "ws";

            this.pictureBox1.ImageLocation = @"E:\壁纸\019a895ed87ea5a801206621a3fa40.jpg@1280w_1l_2o_100sh.jpg";
            //this.pictureBox1.ImageLocation = @"F:\科学调度项目图片文件整理\"+selectData.Cells[3].Value.ToString() + @"\" + selectData.Cells[20].Value.ToString().Split('/')[0];

        }

        private void FormDefactInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.formDefactInfo = null;
        }
    }
}
