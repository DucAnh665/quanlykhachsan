﻿namespace QuanLy_KhachSan.quanly
{
    partial class Customer_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Manager));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.truoc = new System.Windows.Forms.Button();
            this.dau = new System.Windows.Forms.Button();
            this.sau = new System.Windows.Forms.Button();
            this.cuoi = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cb_luachon = new System.Windows.Forms.ComboBox();
            this.TK = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_nhaplai = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.lbl_solg = new System.Windows.Forms.Label();
            this.data_gridview = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_cmtnd = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_gridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.truoc);
            this.groupBox2.Controls.Add(this.dau);
            this.groupBox2.Controls.Add(this.sau);
            this.groupBox2.Controls.Add(this.cuoi);
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Controls.Add(this.cb_luachon);
            this.groupBox2.Controls.Add(this.TK);
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.btn_nhaplai);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.lbl_solg);
            this.groupBox2.Controls.Add(this.data_gridview);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(993, 393);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin dữ liệu  bảng";
            // 
            // truoc
            // 
            this.truoc.Location = new System.Drawing.Point(61, 37);
            this.truoc.Name = "truoc";
            this.truoc.Size = new System.Drawing.Size(46, 26);
            this.truoc.TabIndex = 57;
            this.truoc.Text = "<";
            this.truoc.UseVisualStyleBackColor = true;
            this.truoc.Click += new System.EventHandler(this.truoc_Click);
            // 
            // dau
            // 
            this.dau.Location = new System.Drawing.Point(9, 37);
            this.dau.Name = "dau";
            this.dau.Size = new System.Drawing.Size(46, 26);
            this.dau.TabIndex = 56;
            this.dau.Text = "<<";
            this.dau.UseVisualStyleBackColor = true;
            this.dau.Click += new System.EventHandler(this.dau_Click);
            // 
            // sau
            // 
            this.sau.Location = new System.Drawing.Point(113, 37);
            this.sau.Name = "sau";
            this.sau.Size = new System.Drawing.Size(50, 26);
            this.sau.TabIndex = 58;
            this.sau.Text = ">";
            this.sau.UseVisualStyleBackColor = true;
            this.sau.Click += new System.EventHandler(this.sau_Click);
            // 
            // cuoi
            // 
            this.cuoi.Location = new System.Drawing.Point(169, 37);
            this.cuoi.Name = "cuoi";
            this.cuoi.Size = new System.Drawing.Size(51, 26);
            this.cuoi.TabIndex = 59;
            this.cuoi.Text = ">>";
            this.cuoi.UseVisualStyleBackColor = true;
            this.cuoi.Click += new System.EventHandler(this.cuoi_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(604, 37);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(189, 24);
            this.txt_search.TabIndex = 54;
            this.txt_search.Text = "Nhập từ khóa....";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // cb_luachon
            // 
            this.cb_luachon.FormattingEnabled = true;
            this.cb_luachon.Items.AddRange(new object[] {
            "Mã khách",
            "Tên Khách",
            "giới tính",
            "số điện thoại",
            "Chứng minh nhân dân"});
            this.cb_luachon.Location = new System.Drawing.Point(399, 37);
            this.cb_luachon.Name = "cb_luachon";
            this.cb_luachon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_luachon.Size = new System.Drawing.Size(199, 26);
            this.cb_luachon.TabIndex = 53;
            this.cb_luachon.Text = "-- Lựa chọn trường tìm kiếm--";
            // 
            // TK
            // 
            this.TK.AutoSize = true;
            this.TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TK.Location = new System.Drawing.Point(263, 41);
            this.TK.Name = "TK";
            this.TK.Size = new System.Drawing.Size(130, 20);
            this.TK.TabIndex = 55;
            this.TK.Text = "Tìm kiếm theo :";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(801, 268);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(173, 45);
            this.btn_thoat.TabIndex = 52;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_nhaplai
            // 
            this.btn_nhaplai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhaplai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_nhaplai.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhaplai.Image")));
            this.btn_nhaplai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhaplai.Location = new System.Drawing.Point(801, 213);
            this.btn_nhaplai.Name = "btn_nhaplai";
            this.btn_nhaplai.Size = new System.Drawing.Size(173, 49);
            this.btn_nhaplai.TabIndex = 51;
            this.btn_nhaplai.Text = "Nhập lại";
            this.btn_nhaplai.UseVisualStyleBackColor = true;
            this.btn_nhaplai.Click += new System.EventHandler(this.btn_nhaplai_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(801, 164);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(173, 43);
            this.btn_xoa.TabIndex = 49;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_them.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(801, 69);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(173, 40);
            this.btn_them.TabIndex = 47;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(801, 112);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(173, 46);
            this.btn_sua.TabIndex = 48;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // lbl_solg
            // 
            this.lbl_solg.AutoSize = true;
            this.lbl_solg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_solg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_solg.Location = new System.Drawing.Point(6, 356);
            this.lbl_solg.Name = "lbl_solg";
            this.lbl_solg.Size = new System.Drawing.Size(199, 20);
            this.lbl_solg.TabIndex = 46;
            this.lbl_solg.Text = "Số lượng bản ghi...........";
            // 
            // data_gridview
            // 
            this.data_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gridview.Location = new System.Drawing.Point(6, 69);
            this.data_gridview.Name = "data_gridview";
            this.data_gridview.Size = new System.Drawing.Size(789, 275);
            this.data_gridview.TabIndex = 0;
            this.data_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_gridview_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.rb_nu);
            this.groupBox1.Controls.Add(this.rb_nam);
            this.groupBox1.Controls.Add(this.txt_date);
            this.groupBox1.Controls.Add(this.txt_tennv);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_cmtnd);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_manv);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 201);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(217, 168);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(45, 22);
            this.rb_nu.TabIndex = 3;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(142, 168);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(58, 22);
            this.rb_nam.TabIndex = 3;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // txt_date
            // 
            this.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_date.Location = new System.Drawing.Point(142, 119);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(161, 24);
            this.txt_date.TabIndex = 2;
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(142, 77);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(161, 24);
            this.txt_tennv.TabIndex = 1;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(531, 121);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(161, 24);
            this.txt_email.TabIndex = 1;
            // 
            // txt_cmtnd
            // 
            this.txt_cmtnd.Location = new System.Drawing.Point(531, 77);
            this.txt_cmtnd.Name = "txt_cmtnd";
            this.txt_cmtnd.Size = new System.Drawing.Size(161, 24);
            this.txt_cmtnd.TabIndex = 1;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(531, 34);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(161, 24);
            this.txt_sdt.TabIndex = 1;
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(142, 34);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(161, 24);
            this.txt_manv.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số CMTND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(431, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quản lý khách";
            // 
            // Customer_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 692);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn Hoa Mai";
            this.Load += new System.EventHandler(this.Customer_Manager_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_gridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button truoc;
        private System.Windows.Forms.Button dau;
        private System.Windows.Forms.Button sau;
        private System.Windows.Forms.Button cuoi;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cb_luachon;
        private System.Windows.Forms.Label TK;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_nhaplai;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label lbl_solg;
        private System.Windows.Forms.DataGridView data_gridview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.RadioButton rb_nam;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_cmtnd;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}