using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_so1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            { 
                e.Handled = true;  
            }
        }

        private void txt_so2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void cong_btn_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txt_so1.Text) + Convert.ToInt32(txt_so2.Text);
            txt_kq.Text = result.ToString();
        }

        private void tru_btn_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txt_so1.Text) - Convert.ToInt32(txt_so2.Text);
            txt_kq.Text = result.ToString();
        }

        private void nhan_btn_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txt_so1.Text) * Convert.ToInt32(txt_so2.Text);
            txt_kq.Text = result.ToString();
        }

        private void chia_btn_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txt_so1.Text) / Convert.ToInt32(txt_so2.Text);
            txt_kq.Text = result.ToString();
        }

        private void Del_btn_Click(object sender, EventArgs e)
        {
            txt_so1.Clear();
            txt_so2.Clear();
            txt_kq.Clear();
        }
    }
}
