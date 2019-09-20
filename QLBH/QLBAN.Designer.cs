namespace QLBH
{
    partial class QLBAN
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numsl = new System.Windows.Forms.NumericUpDown();
            this.tbdongia = new System.Windows.Forms.TextBox();
            this.cbloaihang = new System.Windows.Forms.ComboBox();
            this.cbtenhang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbmacthd = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgvhienthihd = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpngaylaphd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbghichu = new System.Windows.Forms.TextBox();
            this.tbmahd = new System.Windows.Forms.TextBox();
            this.btthanhtoan = new System.Windows.Forms.Button();
            this.btthemhd = new System.Windows.Forms.Button();
            this.btthemcthd = new System.Windows.Forms.Button();
            this.cbmaban = new System.Windows.Forms.ComboBox();
            this.qLBHmohinh3lopDataSet = new QLBH.QLBHmohinh3lopDataSet();
            this.hANGHOATableAdapter = new QLBH.QLBHmohinh3lopDataSetTableAdapters.HANGHOATableAdapter();
            this.hANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbchuyenban = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btchuyenban = new System.Windows.Forms.Button();
            this.tbketquaktban = new System.Windows.Forms.TextBox();
            this.btquaylai = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsl)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvhienthihd)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHmohinh3lopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.numsl);
            this.panel2.Controls.Add(this.tbdongia);
            this.panel2.Controls.Add(this.cbloaihang);
            this.panel2.Controls.Add(this.cbtenhang);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbmacthd);
            this.panel2.Location = new System.Drawing.Point(449, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 185);
            this.panel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Loại Hàng";
            // 
            // numsl
            // 
            this.numsl.Location = new System.Drawing.Point(179, 162);
            this.numsl.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numsl.Name = "numsl";
            this.numsl.Size = new System.Drawing.Size(60, 20);
            this.numsl.TabIndex = 18;
            this.numsl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numsl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbdongia
            // 
            this.tbdongia.Location = new System.Drawing.Point(179, 130);
            this.tbdongia.Name = "tbdongia";
            this.tbdongia.Size = new System.Drawing.Size(100, 20);
            this.tbdongia.TabIndex = 17;
            // 
            // cbloaihang
            // 
            this.cbloaihang.FormattingEnabled = true;
            this.cbloaihang.Location = new System.Drawing.Point(179, 62);
            this.cbloaihang.Name = "cbloaihang";
            this.cbloaihang.Size = new System.Drawing.Size(100, 21);
            this.cbloaihang.TabIndex = 16;
            this.cbloaihang.SelectedIndexChanged += new System.EventHandler(this.Cbloaihang_SelectedIndexChanged);
            // 
            // cbtenhang
            // 
            this.cbtenhang.FormattingEnabled = true;
            this.cbtenhang.Location = new System.Drawing.Point(179, 95);
            this.cbtenhang.Name = "cbtenhang";
            this.cbtenhang.Size = new System.Drawing.Size(100, 21);
            this.cbtenhang.TabIndex = 15;
            this.cbtenhang.SelectedIndexChanged += new System.EventHandler(this.Cbtenhang_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "SL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã CTHD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã sản phẩm";
            // 
            // tbmacthd
            // 
            this.tbmacthd.Location = new System.Drawing.Point(179, 23);
            this.tbmacthd.Name = "tbmacthd";
            this.tbmacthd.Size = new System.Drawing.Size(100, 20);
            this.tbmacthd.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgvhienthihd);
            this.panel5.Location = new System.Drawing.Point(12, 110);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(732, 166);
            this.panel5.TabIndex = 5;
            // 
            // dtgvhienthihd
            // 
            this.dtgvhienthihd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvhienthihd.Location = new System.Drawing.Point(0, 3);
            this.dtgvhienthihd.Name = "dtgvhienthihd";
            this.dtgvhienthihd.Size = new System.Drawing.Size(729, 160);
            this.dtgvhienthihd.TabIndex = 0;
            this.dtgvhienthihd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgvhienthihd_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtpngaylaphd);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbghichu);
            this.panel3.Controls.Add(this.tbmahd);
            this.panel3.Location = new System.Drawing.Point(15, 307);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 165);
            this.panel3.TabIndex = 2;
            // 
            // dtpngaylaphd
            // 
            this.dtpngaylaphd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaylaphd.Location = new System.Drawing.Point(119, 84);
            this.dtpngaylaphd.Name = "dtpngaylaphd";
            this.dtpngaylaphd.Size = new System.Drawing.Size(96, 20);
            this.dtpngaylaphd.TabIndex = 14;
            this.dtpngaylaphd.Value = new System.DateTime(2019, 6, 7, 10, 22, 59, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ghi Chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngày Lập HD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // tbghichu
            // 
            this.tbghichu.Location = new System.Drawing.Point(302, 33);
            this.tbghichu.Name = "tbghichu";
            this.tbghichu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbghichu.Size = new System.Drawing.Size(100, 20);
            this.tbghichu.TabIndex = 4;
            this.tbghichu.Text = "0";
            // 
            // tbmahd
            // 
            this.tbmahd.Location = new System.Drawing.Point(119, 31);
            this.tbmahd.Name = "tbmahd";
            this.tbmahd.Size = new System.Drawing.Size(100, 20);
            this.tbmahd.TabIndex = 0;
            // 
            // btthanhtoan
            // 
            this.btthanhtoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthanhtoan.Location = new System.Drawing.Point(594, 72);
            this.btthanhtoan.Name = "btthanhtoan";
            this.btthanhtoan.Size = new System.Drawing.Size(115, 32);
            this.btthanhtoan.TabIndex = 6;
            this.btthanhtoan.Text = "Thanh Toán";
            this.btthanhtoan.UseVisualStyleBackColor = true;
            this.btthanhtoan.Click += new System.EventHandler(this.Btthanhtoan_Click);
            // 
            // btthemhd
            // 
            this.btthemhd.BackColor = System.Drawing.Color.Gray;
            this.btthemhd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthemhd.Location = new System.Drawing.Point(143, 498);
            this.btthemhd.Name = "btthemhd";
            this.btthemhd.Size = new System.Drawing.Size(168, 42);
            this.btthemhd.TabIndex = 5;
            this.btthemhd.Text = "Thêm Hóa Đơn";
            this.btthemhd.UseVisualStyleBackColor = false;
            this.btthemhd.Click += new System.EventHandler(this.Btthemhd_Click);
            // 
            // btthemcthd
            // 
            this.btthemcthd.BackColor = System.Drawing.Color.Gray;
            this.btthemcthd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthemcthd.Location = new System.Drawing.Point(511, 498);
            this.btthemcthd.Name = "btthemcthd";
            this.btthemcthd.Size = new System.Drawing.Size(160, 42);
            this.btthemcthd.TabIndex = 9;
            this.btthemcthd.Text = "Thêm CTHD";
            this.btthemcthd.UseVisualStyleBackColor = false;
            this.btthemcthd.Click += new System.EventHandler(this.Btthemcthd_Click);
            // 
            // cbmaban
            // 
            this.cbmaban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmaban.FormattingEnabled = true;
            this.cbmaban.Location = new System.Drawing.Point(190, 42);
            this.cbmaban.Name = "cbmaban";
            this.cbmaban.Size = new System.Drawing.Size(121, 21);
            this.cbmaban.TabIndex = 10;
            this.cbmaban.SelectedIndexChanged += new System.EventHandler(this.Cbmaban_SelectedIndexChanged);
            // 
            // qLBHmohinh3lopDataSet
            // 
            this.qLBHmohinh3lopDataSet.DataSetName = "QLBHmohinh3lopDataSet";
            this.qLBHmohinh3lopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hANGHOATableAdapter
            // 
            this.hANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // hANGHOABindingSource
            // 
            this.hANGHOABindingSource.DataMember = "HANGHOA";
            this.hANGHOABindingSource.DataSource = this.qLBHmohinh3lopDataSet;
            // 
            // cbchuyenban
            // 
            this.cbchuyenban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbchuyenban.FormattingEnabled = true;
            this.cbchuyenban.Location = new System.Drawing.Point(488, 42);
            this.cbchuyenban.Name = "cbchuyenban";
            this.cbchuyenban.Size = new System.Drawing.Size(104, 21);
            this.cbchuyenban.TabIndex = 13;
            this.cbchuyenban.SelectedIndexChanged += new System.EventHandler(this.Cbchuyenban_SelectedIndexChanged);
            this.cbchuyenban.SelectionChangeCommitted += new System.EventHandler(this.Cbchuyenban_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Chọn Bàn";
            // 
            // btchuyenban
            // 
            this.btchuyenban.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btchuyenban.Location = new System.Drawing.Point(357, 26);
            this.btchuyenban.Name = "btchuyenban";
            this.btchuyenban.Size = new System.Drawing.Size(115, 37);
            this.btchuyenban.TabIndex = 15;
            this.btchuyenban.Text = "Chuyển Bàn";
            this.btchuyenban.UseVisualStyleBackColor = true;
            this.btchuyenban.Click += new System.EventHandler(this.Btchuyenban_Click);
            // 
            // tbketquaktban
            // 
            this.tbketquaktban.Location = new System.Drawing.Point(471, 80);
            this.tbketquaktban.Name = "tbketquaktban";
            this.tbketquaktban.Size = new System.Drawing.Size(121, 20);
            this.tbketquaktban.TabIndex = 16;
            this.tbketquaktban.Visible = false;
            // 
            // btquaylai
            // 
            this.btquaylai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btquaylai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btquaylai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btquaylai.Location = new System.Drawing.Point(2, 2);
            this.btquaylai.Name = "btquaylai";
            this.btquaylai.Size = new System.Drawing.Size(119, 26);
            this.btquaylai.TabIndex = 17;
            this.btquaylai.Text = "Quay lại";
            this.btquaylai.UseVisualStyleBackColor = true;
            this.btquaylai.Click += new System.EventHandler(this.Btquaylai_Click);
            // 
            // QLBAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(756, 550);
            this.Controls.Add(this.btquaylai);
            this.Controls.Add(this.tbketquaktban);
            this.Controls.Add(this.btchuyenban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbchuyenban);
            this.Controls.Add(this.cbmaban);
            this.Controls.Add(this.btthemcthd);
            this.Controls.Add(this.btthemhd);
            this.Controls.Add(this.btthanhtoan);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Name = "QLBAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Hàng";
            this.Load += new System.EventHandler(this.QLBAN_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsl)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvhienthihd)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHmohinh3lopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtgvhienthihd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbmahd;
        private System.Windows.Forms.Button btthanhtoan;
        private System.Windows.Forms.Button btthemhd;
        private System.Windows.Forms.TextBox tbmacthd;
        private System.Windows.Forms.Button btthemcthd;
        private System.Windows.Forms.TextBox tbghichu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmaban;
        private System.Windows.Forms.ComboBox cbtenhang;
        private System.Windows.Forms.ComboBox cbloaihang;
        private System.Windows.Forms.TextBox tbdongia;
        private QLBHmohinh3lopDataSet qLBHmohinh3lopDataSet;
        private QLBHmohinh3lopDataSetTableAdapters.HANGHOATableAdapter hANGHOATableAdapter;
        private System.Windows.Forms.NumericUpDown numsl;
        private System.Windows.Forms.DateTimePicker dtpngaylaphd;
        private System.Windows.Forms.BindingSource hANGHOABindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbchuyenban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btchuyenban;
        private System.Windows.Forms.TextBox tbketquaktban;
        private System.Windows.Forms.Button btquaylai;
    }
}