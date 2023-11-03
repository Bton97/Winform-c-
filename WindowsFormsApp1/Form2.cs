using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void sothich_btn_Click(object sender, EventArgs e)
        {
            string str = "";
            if (di_ms.Checked == true)
            {
                str = di_ms.Text + "\n";
            }
            if(nghe_nhac.Checked == true)
            {
                str = str + nghe_nhac.Text + "\n";
            }
            if (choi_tt.Checked == true)
            {
                str = str + choi_tt.Text + "\n";
            }
            if(xem_phim.Checked == true)
            {
                str = str + xem_phim.Text + "\n";
            }
            if(du_lich.Checked == true)
            {
                str = str + du_lich.Text + "\n";
            }
            if(str.Length > 0)
            {
                MessageBox.Show("Sở thích của mày là: \n" + str);
            }
            else
            {
                MessageBox.Show("M đéo chọn cmg hết!\n Ngưng phí thgian");
            }
        }

        private void Mauthich_btn_Click(object sender, EventArgs e)
        {
            string str = "";
            if (Red_btn.Checked == true) 
            {
                str = Red_btn.Text + "\n";
            }
            if(Pink_btn.Checked == true)
            {
                str = Pink_btn.Text + "\n";
            }
            if(Purple_btn.Checked == true)
            {
                str=Purple_btn.Text + "\n";
            }
            if(White_btn.Checked == true)
            {
                str = White_btn.Text + "\n";
            }
            if(Yellow_btn.Checked == true)
            {
                str =   Yellow_btn.Text + "\n";
            }
            if (str.Length > 0)
            {
                MessageBox.Show("Màu m thích là: \n" + str);
            }
            else
            {
                MessageBox.Show("M đ có màu nào thích cả!\n Nhàm chán vl");
            }
        }
    }
}
