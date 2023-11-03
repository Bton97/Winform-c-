namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_password = new System.Windows.Forms.TextBox();
            this.backgr_login = new System.Windows.Forms.GroupBox();
            this.linkLabel_qmk = new System.Windows.Forms.LinkLabel();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LinkLabel_copyright = new System.Windows.Forms.LinkLabel();
            this.backgr_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ID
            // 
            this.txt_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_ID.Location = new System.Drawing.Point(109, 34);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(223, 20);
            this.txt_ID.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_password
            // 
            this.txt_password.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_password.Location = new System.Drawing.Point(109, 69);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(223, 20);
            this.txt_password.TabIndex = 2;
            // 
            // backgr_login
            // 
            this.backgr_login.BackColor = System.Drawing.Color.Chocolate;
            this.backgr_login.Controls.Add(this.linkLabel_qmk);
            this.backgr_login.Controls.Add(this.label_pass);
            this.backgr_login.Controls.Add(this.label_ID);
            this.backgr_login.Controls.Add(this.button1);
            this.backgr_login.Controls.Add(this.txt_ID);
            this.backgr_login.Controls.Add(this.txt_password);
            this.backgr_login.Location = new System.Drawing.Point(1486, 145);
            this.backgr_login.Name = "backgr_login";
            this.backgr_login.Padding = new System.Windows.Forms.Padding(0);
            this.backgr_login.Size = new System.Drawing.Size(388, 184);
            this.backgr_login.TabIndex = 6;
            this.backgr_login.TabStop = false;
            // 
            // linkLabel_qmk
            // 
            this.linkLabel_qmk.AutoSize = true;
            this.linkLabel_qmk.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel_qmk.Location = new System.Drawing.Point(275, 100);
            this.linkLabel_qmk.Margin = new System.Windows.Forms.Padding(3);
            this.linkLabel_qmk.Name = "linkLabel_qmk";
            this.linkLabel_qmk.Size = new System.Drawing.Size(86, 13);
            this.linkLabel_qmk.TabIndex = 6;
            this.linkLabel_qmk.TabStop = true;
            this.linkLabel_qmk.Text = "Quên mật khẩu?";
            this.linkLabel_qmk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_qmk_LinkClicked);
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.Location = new System.Drawing.Point(3, 66);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(97, 22);
            this.label_pass.TabIndex = 5;
            this.label_pass.Text = "Password";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(35, 31);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(29, 22);
            this.label_ID.TabIndex = 4;
            this.label_ID.Text = "ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(134, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // LinkLabel_copyright
            // 
            this.LinkLabel_copyright.AutoSize = true;
            this.LinkLabel_copyright.BackColor = System.Drawing.Color.Goldenrod;
            this.LinkLabel_copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel_copyright.Location = new System.Drawing.Point(1787, 851);
            this.LinkLabel_copyright.Name = "LinkLabel_copyright";
            this.LinkLabel_copyright.Size = new System.Drawing.Size(87, 22);
            this.LinkLabel_copyright.TabIndex = 7;
            this.LinkLabel_copyright.TabStop = true;
            this.LinkLabel_copyright.Text = "Copyright";
            this.LinkLabel_copyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_copyright_LinkClicked);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.cs21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 761);
            this.Controls.Add(this.LinkLabel_copyright);
            this.Controls.Add(this.backgr_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(16, 39);
            this.Name = "Form1";
            this.Text = "Đăng nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.backgr_login.ResumeLayout(false);
            this.backgr_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.GroupBox backgr_login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.LinkLabel LinkLabel_copyright;
        private System.Windows.Forms.LinkLabel linkLabel_qmk;
    }
}

