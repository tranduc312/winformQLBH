namespace QLBH
{
    partial class ManHinhChinh
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btqltaikhoan = new System.Windows.Forms.Button();
            this.bthoadon = new System.Windows.Forms.Button();
            this.btqlsanpham = new System.Windows.Forms.Button();
            this.btqlban = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.btqltaikhoan);
            this.panel2.Controls.Add(this.bthoadon);
            this.panel2.Controls.Add(this.btqlsanpham);
            this.panel2.Controls.Add(this.btqlban);
            this.panel2.Location = new System.Drawing.Point(384, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 322);
            this.panel2.TabIndex = 1;
            // 
            // btqltaikhoan
            // 
            this.btqltaikhoan.BackColor = System.Drawing.Color.DarkKhaki;
            this.btqltaikhoan.Location = new System.Drawing.Point(3, 243);
            this.btqltaikhoan.Name = "btqltaikhoan";
            this.btqltaikhoan.Size = new System.Drawing.Size(161, 76);
            this.btqltaikhoan.TabIndex = 3;
            this.btqltaikhoan.Text = "Quản Lý Tài Khoản";
            this.btqltaikhoan.UseVisualStyleBackColor = false;
            this.btqltaikhoan.Click += new System.EventHandler(this.Btqltaikhoan_Click);
            // 
            // bthoadon
            // 
            this.bthoadon.BackColor = System.Drawing.Color.DarkKhaki;
            this.bthoadon.Location = new System.Drawing.Point(0, 161);
            this.bthoadon.Name = "bthoadon";
            this.bthoadon.Size = new System.Drawing.Size(161, 76);
            this.bthoadon.TabIndex = 2;
            this.bthoadon.Text = "Quản Lý Hóa Đơn";
            this.bthoadon.UseVisualStyleBackColor = false;
            this.bthoadon.Click += new System.EventHandler(this.Bthoadon_Click);
            // 
            // btqlsanpham
            // 
            this.btqlsanpham.BackColor = System.Drawing.Color.DarkKhaki;
            this.btqlsanpham.Location = new System.Drawing.Point(0, 82);
            this.btqlsanpham.Name = "btqlsanpham";
            this.btqlsanpham.Size = new System.Drawing.Size(161, 76);
            this.btqlsanpham.TabIndex = 1;
            this.btqlsanpham.Text = "Quản Lý Sản Phẩm";
            this.btqlsanpham.UseVisualStyleBackColor = false;
            this.btqlsanpham.Click += new System.EventHandler(this.Btqlsanpham_Click);
            // 
            // btqlban
            // 
            this.btqlban.BackColor = System.Drawing.Color.DarkKhaki;
            this.btqlban.Location = new System.Drawing.Point(0, 0);
            this.btqlban.Name = "btqlban";
            this.btqlban.Size = new System.Drawing.Size(161, 76);
            this.btqlban.TabIndex = 0;
            this.btqlban.Text = "Quản Lý Bán Hàng";
            this.btqlban.UseVisualStyleBackColor = false;
            this.btqlban.Click += new System.EventHandler(this.Btqlban_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.adminToolStripMenuItem.Text = "admin";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.đăngXuấtToolStripMenuItem.Text = "đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.ĐăngXuấtToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.ThốngKêToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLBH.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(0, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(552, 346);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn Hình Chính";
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bthoadon;
        private System.Windows.Forms.Button btqlsanpham;
        private System.Windows.Forms.Button btqlban;
        private System.Windows.Forms.Button btqltaikhoan;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
    }
}