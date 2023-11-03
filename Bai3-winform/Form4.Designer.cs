namespace Bai3_winform
{
    partial class Form4
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
            button_In = new Button();
            button_Xoa = new Button();
            button_Stop = new Button();
            lbl_KQ = new Label();
            SuspendLayout();
            // 
            // button_In
            // 
            button_In.Cursor = Cursors.Hand;
            button_In.Location = new Point(61, 154);
            button_In.Name = "button_In";
            button_In.Size = new Size(75, 23);
            button_In.TabIndex = 0;
            button_In.Text = "In Mảng";
            button_In.UseVisualStyleBackColor = true;
            button_In.UseWaitCursor = true;
            button_In.Click += button_In_Click;
            // 
            // button_Xoa
            // 
            button_Xoa.BackColor = SystemColors.Control;
            button_Xoa.Cursor = Cursors.Hand;
            button_Xoa.Location = new Point(222, 154);
            button_Xoa.Name = "button_Xoa";
            button_Xoa.Size = new Size(75, 23);
            button_Xoa.TabIndex = 1;
            button_Xoa.Text = "Xoá";
            button_Xoa.UseVisualStyleBackColor = true;
            button_Xoa.UseWaitCursor = true;
            button_Xoa.Click += button_Xoa_Click;
            // 
            // button_Stop
            // 
            button_Stop.Cursor = Cursors.Hand;
            button_Stop.Location = new Point(388, 154);
            button_Stop.Name = "button_Stop";
            button_Stop.Size = new Size(75, 23);
            button_Stop.TabIndex = 2;
            button_Stop.Text = "Dừng";
            button_Stop.UseVisualStyleBackColor = true;
            button_Stop.UseWaitCursor = true;
            button_Stop.Click += button_Stop_Click;
            // 
            // lbl_KQ
            // 
            lbl_KQ.AutoSize = true;
            lbl_KQ.BackColor = Color.LightSalmon;
            lbl_KQ.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_KQ.ForeColor = Color.Black;
            lbl_KQ.Location = new Point(133, 33);
            lbl_KQ.Name = "lbl_KQ";
            lbl_KQ.Size = new Size(63, 25);
            lbl_KQ.TabIndex = 3;
            lbl_KQ.Text = "label1";
            lbl_KQ.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 225);
            Controls.Add(lbl_KQ);
            Controls.Add(button_Stop);
            Controls.Add(button_Xoa);
            Controls.Add(button_In);
            Name = "Form4";
            Text = "Bài 8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_In;
        private Button button_Xoa;
        private Button button_Stop;
        private Label lbl_KQ;
    }
}