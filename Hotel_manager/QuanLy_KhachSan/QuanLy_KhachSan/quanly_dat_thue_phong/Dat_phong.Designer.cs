﻿namespace QuanLy_KhachSan.quanly_dat_thue_phong
{
    partial class Dat_phong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dat_phong));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_ngaydat = new System.Windows.Forms.DateTimePicker();
            this.txt_id_nv = new System.Windows.Forms.ComboBox();
            this.txt_id_khach = new System.Windows.Forms.ComboBox();
            this.lb_nhanvien = new System.Windows.Forms.Label();
            this.lb_phong = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_khach = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_song = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_id_phong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id_hd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cb_luachon = new System.Windows.Forms.ComboBox();
            this.TK = new System.Windows.Forms.Label();
            this.data_phong = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.data_datphong = new System.Windows.Forms.DataGridView();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSet1 = new QuanLy_KhachSan.DataSet1();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienTableAdapter = new QuanLy_KhachSan.DataSet1TableAdapters.NhanvienTableAdapter();
            this.khachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachhangTableAdapter = new QuanLy_KhachSan.DataSet1TableAdapters.KhachhangTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_phong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_datphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(427, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Đặt phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_ngaydat);
            this.groupBox2.Controls.Add(this.txt_id_nv);
            this.groupBox2.Controls.Add(this.txt_id_khach);
            this.groupBox2.Controls.Add(this.lb_nhanvien);
            this.groupBox2.Controls.Add(this.lb_phong);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lb_khach);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_song);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_id_phong);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.id_hd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Controls.Add(this.cb_luachon);
            this.groupBox2.Controls.Add(this.TK);
            this.groupBox2.Controls.Add(this.data_phong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(938, 331);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin dữ liệu  bảng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(747, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 18);
            this.label12.TabIndex = 61;
            // 
            // txt_ngaydat
            // 
            this.txt_ngaydat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ngaydat.Location = new System.Drawing.Point(605, 254);
            this.txt_ngaydat.Name = "txt_ngaydat";
            this.txt_ngaydat.Size = new System.Drawing.Size(142, 24);
            this.txt_ngaydat.TabIndex = 60;
            // 
            // txt_id_nv
            // 
            this.txt_id_nv.DataSource = this.nhanvienBindingSource;
            this.txt_id_nv.DisplayMember = "Manv";
            this.txt_id_nv.FormattingEnabled = true;
            this.txt_id_nv.Location = new System.Drawing.Point(606, 218);
            this.txt_id_nv.Name = "txt_id_nv";
            this.txt_id_nv.Size = new System.Drawing.Size(141, 26);
            this.txt_id_nv.TabIndex = 59;
            this.txt_id_nv.ValueMember = "Tennv";
            this.txt_id_nv.TextChanged += new System.EventHandler(this.txt_id_nv_TextChanged);
            // 
            // txt_id_khach
            // 
            this.txt_id_khach.DataSource = this.khachhangBindingSource;
            this.txt_id_khach.DisplayMember = "MaKh";
            this.txt_id_khach.FormattingEnabled = true;
            this.txt_id_khach.Location = new System.Drawing.Point(99, 279);
            this.txt_id_khach.Name = "txt_id_khach";
            this.txt_id_khach.Size = new System.Drawing.Size(181, 26);
            this.txt_id_khach.TabIndex = 59;
            this.txt_id_khach.ValueMember = "Tenkh";
            this.txt_id_khach.TextChanged += new System.EventHandler(this.txt_id_khach_TextChanged);
            // 
            // lb_nhanvien
            // 
            this.lb_nhanvien.AutoSize = true;
            this.lb_nhanvien.Location = new System.Drawing.Point(753, 226);
            this.lb_nhanvien.Name = "lb_nhanvien";
            this.lb_nhanvien.Size = new System.Drawing.Size(45, 18);
            this.lb_nhanvien.TabIndex = 58;
            this.lb_nhanvien.Text = "Tên : ";
            // 
            // lb_phong
            // 
            this.lb_phong.AutoSize = true;
            this.lb_phong.Location = new System.Drawing.Point(296, 260);
            this.lb_phong.Name = "lb_phong";
            this.lb_phong.Size = new System.Drawing.Size(45, 18);
            this.lb_phong.TabIndex = 58;
            this.lb_phong.Text = "Tên : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(471, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 18);
            this.label10.TabIndex = 56;
            this.label10.Text = "Ngày đặt phòng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 18);
            this.label8.TabIndex = 56;
            this.label8.Text = "Mã nhân viên :";
            // 
            // lb_khach
            // 
            this.lb_khach.AutoSize = true;
            this.lb_khach.Location = new System.Drawing.Point(296, 290);
            this.lb_khach.Name = "lb_khach";
            this.lb_khach.Size = new System.Drawing.Size(45, 18);
            this.lb_khach.TabIndex = 58;
            this.lb_khach.Text = "Tên : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 56;
            this.label5.Text = "Mã khách";
            // 
            // txt_song
            // 
            this.txt_song.Location = new System.Drawing.Point(606, 287);
            this.txt_song.Name = "txt_song";
            this.txt_song.Size = new System.Drawing.Size(141, 24);
            this.txt_song.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(471, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 18);
            this.label11.TabIndex = 56;
            this.label11.Text = "Số lượng người";
            // 
            // txt_id_phong
            // 
            this.txt_id_phong.Location = new System.Drawing.Point(99, 248);
            this.txt_id_phong.Name = "txt_id_phong";
            this.txt_id_phong.Size = new System.Drawing.Size(181, 24);
            this.txt_id_phong.TabIndex = 57;
            this.txt_id_phong.TextChanged += new System.EventHandler(this.txt_id_phong_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 56;
            this.label3.Text = "Mã phòng";
            // 
            // id_hd
            // 
            this.id_hd.Location = new System.Drawing.Point(99, 218);
            this.id_hd.Name = "id_hd";
            this.id_hd.Size = new System.Drawing.Size(181, 24);
            this.id_hd.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 56;
            this.label2.Text = "ID hóa đơn";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(358, 39);
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
            "Mã phòng",
            "Tên phòng",
            "Loại phòng",
            "Mô tả phòng",
            "Số người tối đa",
            "Giá phòng",
            "Trạng thái"});
            this.cb_luachon.Location = new System.Drawing.Point(142, 37);
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
            this.TK.Location = new System.Drawing.Point(6, 41);
            this.TK.Name = "TK";
            this.TK.Size = new System.Drawing.Size(144, 20);
            this.TK.TabIndex = 55;
            this.TK.Text = "Tìm kiếm phòng :";
            // 
            // data_phong
            // 
            this.data_phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_phong.Location = new System.Drawing.Point(6, 69);
            this.data_phong.Name = "data_phong";
            this.data_phong.Size = new System.Drawing.Size(917, 136);
            this.data_phong.TabIndex = 0;
            this.data_phong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_phong_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(747, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 61;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.data_datphong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 452);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 215);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng đặt";
            // 
            // data_datphong
            // 
            this.data_datphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_datphong.Location = new System.Drawing.Point(10, 23);
            this.data_datphong.Name = "data_datphong";
            this.data_datphong.Size = new System.Drawing.Size(913, 182);
            this.data_datphong.TabIndex = 0;
            this.data_datphong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_datphong_CellClick);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(777, 396);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(173, 39);
            this.btn_thoat.TabIndex = 63;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(525, 398);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(199, 39);
            this.btn_delete.TabIndex = 62;
            this.btn_delete.Text = "Hủy đặt phòng";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(225, 398);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(231, 39);
            this.btn_sua.TabIndex = 62;
            this.btn_sua.Text = "Sửa thông tin đặt";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QuanLy_KhachSan.Properties.Resources.Custom_Icon_Design_Flatastic_1_Add_1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 39);
            this.button1.TabIndex = 62;
            this.button1.Text = "Đặt phòng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataMember = "Nhanvien";
            this.nhanvienBindingSource.DataSource = this.dataSet1;
            // 
            // nhanvienTableAdapter
            // 
            this.nhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // khachhangBindingSource
            // 
            this.khachhangBindingSource.DataMember = "Khachhang";
            this.khachhangBindingSource.DataSource = this.dataSet1;
            // 
            // khachhangTableAdapter
            // 
            this.khachhangTableAdapter.ClearBeforeFill = true;
            // 
            // Dat_phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 677);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dat_phong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn Hoa Mai";
            this.Load += new System.EventHandler(this.Dat_phong_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_phong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_datphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_khach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id_phong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id_hd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cb_luachon;
        private System.Windows.Forms.Label TK;
        private System.Windows.Forms.DataGridView data_phong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker txt_ngaydat;
        private System.Windows.Forms.ComboBox txt_id_nv;
        private System.Windows.Forms.ComboBox txt_id_khach;
        private System.Windows.Forms.Label lb_nhanvien;
        private System.Windows.Forms.Label lb_phong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_song;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView data_datphong;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_thoat;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private DataSet1TableAdapters.NhanvienTableAdapter nhanvienTableAdapter;
        private System.Windows.Forms.BindingSource khachhangBindingSource;
        private DataSet1TableAdapters.KhachhangTableAdapter khachhangTableAdapter;
    }
}