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
    public partial class FormDisease : Form
    {
        //public DataGridViewRow selectData;
        public FormDisease()
        {
            InitializeComponent();
        }

        public void UpdateData(DataGridViewRow selectData) {
            //this.label2.Text = selectData.Cells[6].Value.ToString();
            //this.label4.Text = selectData.Cells[7].Value.ToString();
            //this.label6.Text = selectData.Cells[8].Value.ToString();
            //this.label8.Text = selectData.Cells[12].Value.ToString();
            //this.label10.Text = selectData.Cells[9].Value.ToString();
            //this.label12.Text = selectData.Cells[10].Value.ToString();
            //this.label14.Text = selectData.Cells[11].Value.ToString();
            //this.label16.Text = selectData.Cells[19].Value.ToString();
            //this.label18.Text = selectData.Cells[20].Value.ToString();
            //this.label20.Text = selectData.Cells[21].Value.ToString();

            this.label2.Text = selectData.Cells[0].Value.ToString();
            this.label4.Text = selectData.Cells[1].Value.ToString();
            this.label6.Text = selectData.Cells[2].Value.ToString();
            this.label8.Text = selectData.Cells[3].Value.ToString();
            this.label10.Text = selectData.Cells[4].Value.ToString();
            this.label12.Text = selectData.Cells[5].Value.ToString();
            this.label14.Text = selectData.Cells[5].Value.ToString();
            this.label16.Text = selectData.Cells[5].Value.ToString();
            this.label18.Text = selectData.Cells[5].Value.ToString();
            this.label20.Text = selectData.Cells[5].Value.ToString();


            this.pictureBox1.ImageLocation = @"E:\壁纸\019a895ed87ea5a801206621a3fa40.jpg@1280w_1l_2o_100sh.jpg";
            this.pictureBox2.ImageLocation = @"E:\壁纸\019a895ed87ea5a801206621a3fa40.jpg@1280w_1l_2o_100sh.jpg";
            this.pictureBox3.ImageLocation = @"E:\壁纸\019a895ed87ea5a801206621a3fa40.jpg@1280w_1l_2o_100sh.jpg";
            this.pictureBox4.ImageLocation = @"E:\壁纸\019a895ed87ea5a801206621a3fa40.jpg@1280w_1l_2o_100sh.jpg";
            this.pictureBox5.ImageLocation = @"E:\壁纸\019a895ed87ea5a801206621a3fa40.jpg@1280w_1l_2o_100sh.jpg";
            this.pictureBox6.ImageLocation = @"E:\壁纸\019a895ed87ea5a801206621a3fa40.jpg@1280w_1l_2o_100sh.jpg";
            //this.pictureBox1.ImageLocation = @"D:\DATA\pic\"+ selectData.Cells[2].Value.ToString() + selectData.Cells[3].Value.ToString() + @"\" + selectData.Cells[13].Value.ToString().Split('/')[0];
            //this.pictureBox2.ImageLocation = @"D:\DATA\pic\" + selectData.Cells[2].Value.ToString() + selectData.Cells[3].Value.ToString() + @"\" + selectData.Cells[14].Value.ToString().Split('/')[0];
            //this.pictureBox3.ImageLocation = @"D:\DATA\pic\" + selectData.Cells[2].Value.ToString() + selectData.Cells[3].Value.ToString() + @"\" + selectData.Cells[15].Value.ToString().Split('/')[0];
            //this.pictureBox4.ImageLocation = @"D:\DATA\pic\" + selectData.Cells[2].Value.ToString() + selectData.Cells[3].Value.ToString() + @"\" + selectData.Cells[16].Value.ToString().Split('/')[0];
            //this.pictureBox5.ImageLocation = @"D:\DATA\pic\" + selectData.Cells[2].Value.ToString() + selectData.Cells[3].Value.ToString() + @"\" + selectData.Cells[17].Value.ToString().Split('/')[0];
            //this.pictureBox6.ImageLocation = @"D:\DATA\pic\" + selectData.Cells[2].Value.ToString() + selectData.Cells[3].Value.ToString() + @"\" + selectData.Cells[18].Value.ToString().Split('/')[0];

        }

        private void FormDisease_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.formDisease = null;
        }
    }
}
