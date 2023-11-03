namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.grp_1 = new System.Windows.Forms.GroupBox();
            this.du_lich = new System.Windows.Forms.CheckBox();
            this.di_ms = new System.Windows.Forms.CheckBox();
            this.choi_tt = new System.Windows.Forms.CheckBox();
            this.xem_phim = new System.Windows.Forms.CheckBox();
            this.nghe_nhac = new System.Windows.Forms.CheckBox();
            this.grp_2 = new System.Windows.Forms.GroupBox();
            this.Purple_btn = new System.Windows.Forms.RadioButton();
            this.Pink_btn = new System.Windows.Forms.RadioButton();
            this.Yellow_btn = new System.Windows.Forms.RadioButton();
            this.White_btn = new System.Windows.Forms.RadioButton();
            this.Red_btn = new System.Windows.Forms.RadioButton();
            this.sothich_btn = new System.Windows.Forms.Button();
            this.Mauthich_btn = new System.Windows.Forms.Button();
            this.grp_1.SuspendLayout();
            this.grp_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_1
            // 
            this.grp_1.BackColor = System.Drawing.Color.SkyBlue;
            this.grp_1.Controls.Add(this.du_lich);
            this.grp_1.Controls.Add(this.di_ms);
            this.grp_1.Controls.Add(this.choi_tt);
            this.grp_1.Controls.Add(this.xem_phim);
            this.grp_1.Controls.Add(this.nghe_nhac);
            this.grp_1.ForeColor = System.Drawing.Color.DarkCyan;
            this.grp_1.Location = new System.Drawing.Point(22, 24);
            this.grp_1.Name = "grp_1";
            this.grp_1.Size = new System.Drawing.Size(165, 197);
            this.grp_1.TabIndex = 0;
            this.grp_1.TabStop = false;
            this.grp_1.Text = "Sở thích";
            // 
            // du_lich
            // 
            this.du_lich.AutoSize = true;
            this.du_lich.Location = new System.Drawing.Point(6, 127);
            this.du_lich.Name = "du_lich";
            this.du_lich.Size = new System.Drawing.Size(70, 17);
            this.du_lich.TabIndex = 4;
            this.du_lich.Text = "Đi du lịch";
            this.du_lich.UseVisualStyleBackColor = true;
            // 
            // di_ms
            // 
            this.di_ms.AutoSize = true;
            this.di_ms.Location = new System.Drawing.Point(6, 104);
            this.di_ms.Name = "di_ms";
            this.di_ms.Size = new System.Drawing.Size(84, 17);
            this.di_ms.TabIndex = 3;
            this.di_ms.Text = "Đi Mua Sắm";
            this.di_ms.UseVisualStyleBackColor = true;
            // 
            // choi_tt
            // 
            this.choi_tt.AutoSize = true;
            this.choi_tt.Location = new System.Drawing.Point(6, 81);
            this.choi_tt.Name = "choi_tt";
            this.choi_tt.Size = new System.Drawing.Size(89, 17);
            this.choi_tt.TabIndex = 2;
            this.choi_tt.Text = "Chơi thể thao";
            this.choi_tt.UseVisualStyleBackColor = true;
            // 
            // xem_phim
            // 
            this.xem_phim.AutoSize = true;
            this.xem_phim.Location = new System.Drawing.Point(6, 58);
            this.xem_phim.Name = "xem_phim";
            this.xem_phim.Size = new System.Drawing.Size(73, 17);
            this.xem_phim.TabIndex = 1;
            this.xem_phim.Text = "Xem Phim";
            this.xem_phim.UseVisualStyleBackColor = true;
            // 
            // nghe_nhac
            // 
            this.nghe_nhac.AutoSize = true;
            this.nghe_nhac.Location = new System.Drawing.Point(6, 35);
            this.nghe_nhac.Name = "nghe_nhac";
            this.nghe_nhac.Size = new System.Drawing.Size(79, 17);
            this.nghe_nhac.TabIndex = 0;
            this.nghe_nhac.Text = "Nghe nhạc";
            this.nghe_nhac.UseVisualStyleBackColor = true;
            // 
            // grp_2
            // 
            this.grp_2.BackColor = System.Drawing.Color.SkyBlue;
            this.grp_2.Controls.Add(this.Purple_btn);
            this.grp_2.Controls.Add(this.Pink_btn);
            this.grp_2.Controls.Add(this.Yellow_btn);
            this.grp_2.Controls.Add(this.White_btn);
            this.grp_2.Controls.Add(this.Red_btn);
            this.grp_2.ForeColor = System.Drawing.Color.DarkCyan;
            this.grp_2.Location = new System.Drawing.Point(259, 24);
            this.grp_2.Name = "grp_2";
            this.grp_2.Size = new System.Drawing.Size(151, 197);
            this.grp_2.TabIndex = 1;
            this.grp_2.TabStop = false;
            this.grp_2.Tag = "";
            this.grp_2.Text = "Màu bạn thích";
            // 
            // Purple_btn
            // 
            this.Purple_btn.AutoSize = true;
            this.Purple_btn.Location = new System.Drawing.Point(18, 126);
            this.Purple_btn.Name = "Purple_btn";
            this.Purple_btn.Size = new System.Drawing.Size(44, 17);
            this.Purple_btn.TabIndex = 4;
            this.Purple_btn.TabStop = true;
            this.Purple_btn.Text = "Tím";
            this.Purple_btn.UseVisualStyleBackColor = true;
            // 
            // Pink_btn
            // 
            this.Pink_btn.AutoSize = true;
            this.Pink_btn.Location = new System.Drawing.Point(17, 103);
            this.Pink_btn.Name = "Pink_btn";
            this.Pink_btn.Size = new System.Drawing.Size(51, 17);
            this.Pink_btn.TabIndex = 3;
            this.Pink_btn.TabStop = true;
            this.Pink_btn.Text = "Hồng";
            this.Pink_btn.UseVisualStyleBackColor = true;
            // 
            // Yellow_btn
            // 
            this.Yellow_btn.AutoSize = true;
            this.Yellow_btn.Location = new System.Drawing.Point(17, 81);
            this.Yellow_btn.Name = "Yellow_btn";
            this.Yellow_btn.Size = new System.Drawing.Size(50, 17);
            this.Yellow_btn.TabIndex = 2;
            this.Yellow_btn.TabStop = true;
            this.Yellow_btn.Text = "Vàng";
            this.Yellow_btn.UseVisualStyleBackColor = true;
            // 
            // White_btn
            // 
            this.White_btn.AutoSize = true;
            this.White_btn.Location = new System.Drawing.Point(17, 58);
            this.White_btn.Name = "White_btn";
            this.White_btn.Size = new System.Drawing.Size(53, 17);
            this.White_btn.TabIndex = 1;
            this.White_btn.TabStop = true;
            this.White_btn.Text = "Trắng";
            this.White_btn.UseVisualStyleBackColor = true;
            // 
            // Red_btn
            // 
            this.Red_btn.AutoSize = true;
            this.Red_btn.Location = new System.Drawing.Point(17, 34);
            this.Red_btn.Name = "Red_btn";
            this.Red_btn.Size = new System.Drawing.Size(39, 17);
            this.Red_btn.TabIndex = 0;
            this.Red_btn.TabStop = true;
            this.Red_btn.Text = "Đỏ";
            this.Red_btn.UseVisualStyleBackColor = true;
            // 
            // sothich_btn
            // 
            this.sothich_btn.BackColor = System.Drawing.Color.Gray;
            this.sothich_btn.ForeColor = System.Drawing.Color.Purple;
            this.sothich_btn.Location = new System.Drawing.Point(46, 266);
            this.sothich_btn.Name = "sothich_btn";
            this.sothich_btn.Size = new System.Drawing.Size(128, 23);
            this.sothich_btn.TabIndex = 2;
            this.sothich_btn.Text = "Sở thích của bạn";
            this.sothich_btn.UseVisualStyleBackColor = false;
            this.sothich_btn.Click += new System.EventHandler(this.sothich_btn_Click);
            // 
            // Mauthich_btn
            // 
            this.Mauthich_btn.BackColor = System.Drawing.Color.Gray;
            this.Mauthich_btn.ForeColor = System.Drawing.Color.Purple;
            this.Mauthich_btn.Location = new System.Drawing.Point(282, 266);
            this.Mauthich_btn.Name = "Mauthich_btn";
            this.Mauthich_btn.Size = new System.Drawing.Size(128, 23);
            this.Mauthich_btn.TabIndex = 3;
            this.Mauthich_btn.Text = "Màu bạn thích";
            this.Mauthich_btn.UseVisualStyleBackColor = false;
            this.Mauthich_btn.Click += new System.EventHandler(this.Mauthich_btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(454, 313);
            this.Controls.Add(this.Mauthich_btn);
            this.Controls.Add(this.sothich_btn);
            this.Controls.Add(this.grp_2);
            this.Controls.Add(this.grp_1);
            this.Name = "Form2";
            this.Text = "Khảo sát";
            this.grp_1.ResumeLayout(false);
            this.grp_1.PerformLayout();
            this.grp_2.ResumeLayout(false);
            this.grp_2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_1;
        private System.Windows.Forms.GroupBox grp_2;
        private System.Windows.Forms.CheckBox du_lich;
        private System.Windows.Forms.CheckBox di_ms;
        private System.Windows.Forms.CheckBox choi_tt;
        private System.Windows.Forms.CheckBox xem_phim;
        private System.Windows.Forms.CheckBox nghe_nhac;
        private System.Windows.Forms.RadioButton Purple_btn;
        private System.Windows.Forms.RadioButton Pink_btn;
        private System.Windows.Forms.RadioButton Yellow_btn;
        private System.Windows.Forms.RadioButton White_btn;
        private System.Windows.Forms.RadioButton Red_btn;
        private System.Windows.Forms.Button sothich_btn;
        private System.Windows.Forms.Button Mauthich_btn;
    }
}