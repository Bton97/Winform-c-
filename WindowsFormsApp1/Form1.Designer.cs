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
            this.labelso1 = new System.Windows.Forms.Label();
            this.labelso2 = new System.Windows.Forms.Label();
            this.labelkq = new System.Windows.Forms.Label();
            this.txt_so2 = new System.Windows.Forms.TextBox();
            this.txt_so1 = new System.Windows.Forms.TextBox();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.cong_btn = new System.Windows.Forms.Button();
            this.tru_btn = new System.Windows.Forms.Button();
            this.nhan_btn = new System.Windows.Forms.Button();
            this.Del_btn = new System.Windows.Forms.Button();
            this.chia_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelso1
            // 
            this.labelso1.AutoSize = true;
            this.labelso1.Location = new System.Drawing.Point(84, 65);
            this.labelso1.Name = "labelso1";
            this.labelso1.Size = new System.Drawing.Size(45, 13);
            this.labelso1.TabIndex = 0;
            this.labelso1.Text = "so thu 1";
            this.labelso1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelso2
            // 
            this.labelso2.AutoSize = true;
            this.labelso2.Location = new System.Drawing.Point(84, 95);
            this.labelso2.Name = "labelso2";
            this.labelso2.Size = new System.Drawing.Size(47, 13);
            this.labelso2.TabIndex = 1;
            this.labelso2.Text = "So thu 2";
            // 
            // labelkq
            // 
            this.labelkq.AutoSize = true;
            this.labelkq.Location = new System.Drawing.Point(84, 231);
            this.labelkq.Name = "labelkq";
            this.labelkq.Size = new System.Drawing.Size(44, 13);
            this.labelkq.TabIndex = 2;
            this.labelkq.Text = "Ket qua";
            // 
            // txt_so2
            // 
            this.txt_so2.Location = new System.Drawing.Point(150, 95);
            this.txt_so2.Name = "txt_so2";
            this.txt_so2.Size = new System.Drawing.Size(115, 20);
            this.txt_so2.TabIndex = 3;
            this.txt_so2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_so2_KeyPress);
            // 
            // txt_so1
            // 
            this.txt_so1.Location = new System.Drawing.Point(150, 62);
            this.txt_so1.Name = "txt_so1";
            this.txt_so1.Size = new System.Drawing.Size(115, 20);
            this.txt_so1.TabIndex = 5;
            this.txt_so1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_so1_KeyPress);
            // 
            // txt_kq
            // 
            this.txt_kq.Location = new System.Drawing.Point(150, 231);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(115, 20);
            this.txt_kq.TabIndex = 6;
            // 
            // cong_btn
            // 
            this.cong_btn.Location = new System.Drawing.Point(53, 171);
            this.cong_btn.Name = "cong_btn";
            this.cong_btn.Size = new System.Drawing.Size(44, 37);
            this.cong_btn.TabIndex = 7;
            this.cong_btn.Text = "+";
            this.cong_btn.UseVisualStyleBackColor = true;
            this.cong_btn.Click += new System.EventHandler(this.cong_btn_Click);
            // 
            // tru_btn
            // 
            this.tru_btn.Location = new System.Drawing.Point(103, 171);
            this.tru_btn.Name = "tru_btn";
            this.tru_btn.Size = new System.Drawing.Size(42, 37);
            this.tru_btn.TabIndex = 11;
            this.tru_btn.Text = "-";
            this.tru_btn.UseVisualStyleBackColor = true;
            this.tru_btn.Click += new System.EventHandler(this.tru_btn_Click);
            // 
            // nhan_btn
            // 
            this.nhan_btn.Location = new System.Drawing.Point(151, 171);
            this.nhan_btn.Name = "nhan_btn";
            this.nhan_btn.Size = new System.Drawing.Size(42, 37);
            this.nhan_btn.TabIndex = 12;
            this.nhan_btn.Text = "*";
            this.nhan_btn.UseVisualStyleBackColor = true;
            this.nhan_btn.Click += new System.EventHandler(this.nhan_btn_Click);
            // 
            // Del_btn
            // 
            this.Del_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Del_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Del_btn.Location = new System.Drawing.Point(282, 171);
            this.Del_btn.Name = "Del_btn";
            this.Del_btn.Size = new System.Drawing.Size(55, 37);
            this.Del_btn.TabIndex = 13;
            this.Del_btn.Text = "Del";
            this.Del_btn.UseVisualStyleBackColor = false;
            this.Del_btn.Click += new System.EventHandler(this.Del_btn_Click);
            // 
            // chia_btn
            // 
            this.chia_btn.Location = new System.Drawing.Point(199, 171);
            this.chia_btn.Name = "chia_btn";
            this.chia_btn.Size = new System.Drawing.Size(42, 37);
            this.chia_btn.TabIndex = 14;
            this.chia_btn.Text = "/";
            this.chia_btn.UseVisualStyleBackColor = true;
            this.chia_btn.Click += new System.EventHandler(this.chia_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.chia_btn);
            this.Controls.Add(this.Del_btn);
            this.Controls.Add(this.nhan_btn);
            this.Controls.Add(this.tru_btn);
            this.Controls.Add(this.cong_btn);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.txt_so1);
            this.Controls.Add(this.txt_so2);
            this.Controls.Add(this.labelkq);
            this.Controls.Add(this.labelso2);
            this.Controls.Add(this.labelso1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelso1;
        private System.Windows.Forms.Label labelso2;
        private System.Windows.Forms.Label labelkq;
        private System.Windows.Forms.TextBox txt_so2;
        private System.Windows.Forms.TextBox txt_so1;
        private System.Windows.Forms.TextBox txt_kq;
        private System.Windows.Forms.Button cong_btn;
        private System.Windows.Forms.Button tru_btn;
        private System.Windows.Forms.Button nhan_btn;
        private System.Windows.Forms.Button Del_btn;
        private System.Windows.Forms.Button chia_btn;
    }
}

