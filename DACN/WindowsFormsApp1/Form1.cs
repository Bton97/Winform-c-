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
            txt_ID.ForeColor = Color.Gray;
            txt_ID.Text = "Enter ID";
            this.txt_ID.Leave += new System.EventHandler(this.txt_ID_Leave);
            this.txt_ID.Enter += new System.EventHandler(this.txt_ID_Enter);

            txt_password.ForeColor = Color.Gray;
            txt_password.Text = "Enter Password";
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
        private void txt_ID_Leave(object sender, System.EventArgs e)
        {
            if (txt_ID.Text == "")
            {
                txt_ID.ForeColor = Color.Gray;
                txt_ID.Text = "Enter ID";
            }
        }
        private void txt_ID_Enter(object sender, System.EventArgs e)
        {
            if(txt_ID.Text == "Enter ID")
            {
                txt_ID.Text = "";
                txt_ID.ForeColor = Color.Black;
            }
        }
        private void txt_password_Leave(object sender, System.EventArgs e)
        { 
            if(txt_password.Text == "")
            {
                txt_password.Text = "Enter Password";
                txt_password.ForeColor = Color.Gray;
            }
        }
        private void txt_password_Enter(object sender, System.EventArgs e)
        {
            if(txt_password.Text == "Enter Password")
            {
                txt_password.Text = "";
                txt_password.ForeColor= Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "hung123" && txt_password.Text == "123456")
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu","Thông báo");
            }
        }

        private void LinkLabel_copyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox1 f2 = new AboutBox1();
            // Show another form.
            this.Close();
            f2.Show();
            f2.Location = this.Location;
        }

        private void linkLabel_qmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch(Exception) 
            {
                MessageBox.Show("Không thể truy cập!");
            }
        }
        private void VisitLink()
        {
            linkLabel_qmk.LinkVisited = true;
            System.Diagnostics.Process.Start("https://counter-strike-servers.net/password-reset/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

                Rectangle resolutionRect = System.Windows.Forms.Screen.FromControl(this).Bounds;
                if (this.Width >= resolutionRect.Width || this.Height >= resolutionRect.Height)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
        }
    }
}
