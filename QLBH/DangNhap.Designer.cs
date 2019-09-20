namespace QLBH
{
    partial class DangNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btthoat = new System.Windows.Forms.Button();
            this.btdangnhap = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbmatkhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbtaikhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bthienthimk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btthoat);
            this.panel1.Controls.Add(this.btdangnhap);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 154);
            this.panel1.TabIndex = 0;
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(280, 109);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(81, 27);
            this.btthoat.TabIndex = 3;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.Btthoat_Click);
            // 
            // btdangnhap
            // 
            this.btdangnhap.Location = new System.Drawing.Point(135, 109);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(81, 27);
            this.btdangnhap.TabIndex = 2;
            this.btdangnhap.Text = "Đăng Nhập";
            this.btdangnhap.UseVisualStyleBackColor = true;
            this.btdangnhap.Click += new System.EventHandler(this.Btdangnhap_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bthienthimk);
            this.panel3.Controls.Add(this.tbmatkhau);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(2, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 51);
            this.panel3.TabIndex = 1;
            // 
            // tbmatkhau
            // 
            this.tbmatkhau.Location = new System.Drawing.Point(165, 12);
            this.tbmatkhau.Name = "tbmatkhau";
            this.tbmatkhau.Size = new System.Drawing.Size(162, 20);
            this.tbmatkhau.TabIndex = 2;
            this.tbmatkhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbtaikhoan);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 51);
            this.panel2.TabIndex = 0;
            // 
            // tbtaikhoan
            // 
            this.tbtaikhoan.Location = new System.Drawing.Point(167, 14);
            this.tbtaikhoan.Name = "tbtaikhoan";
            this.tbtaikhoan.Size = new System.Drawing.Size(162, 20);
            this.tbtaikhoan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài Khoản";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::QLBH.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 386);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bthienthimk
            // 
            this.bthienthimk.Location = new System.Drawing.Point(333, 12);
            this.bthienthimk.Name = "bthienthimk";
            this.bthienthimk.Size = new System.Drawing.Size(99, 22);
            this.bthienthimk.TabIndex = 3;
            this.bthienthimk.Text = "Hiển thị mật khẩu";
            this.bthienthimk.UseVisualStyleBackColor = true;
            this.bthienthimk.Click += new System.EventHandler(this.Bthienthimk_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 550);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbmatkhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbtaikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btdangnhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bthienthimk;
    }
}

