using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum_week_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_hasil.Text = listB_data.SelectedItem.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            listB_data.Items.Add(txtBox_data.Text);
        }

        private void listB_data_Click(object sender, EventArgs e)
        {

        }

        private void cekB_aktif_CheckedChanged(object sender, EventArgs e)
        {
            if (cekB_aktif.Checked == true)
            {

                
            }
            else
            {
                lbl_hasil.ForeColor = Color.Black;
            }
        }

        private void Rbtn_merah_CheckedChanged(object sender, EventArgs e)
        {
            if (cekB_aktif.Checked == true)
            {
                
                lbl_hasil.ForeColor = Color.Red;
                
            }
            else
            {
                lbl_hasil.ForeColor = Color.Black;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            listB_data.Items.Clear();
            lbl_hasil.Text = "  ";
            lbl_hasil.ForeColor = Color.Black;
            cekB_aktif.Checked = false;
            txtBox_data.Text = " ";
        }

        private void Rbtn_biru_CheckedChanged(object sender, EventArgs e)
        {
            if (cekB_aktif.Checked == true)
            {
                lbl_hasil.ForeColor = Color.Blue;
            }
            else
            {
                lbl_hasil.ForeColor = Color.Black;
            }
        }
    }
}
