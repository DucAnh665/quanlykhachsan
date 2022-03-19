﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuanLy_KhachSan.timkiem
{
    public partial class Search_phong : Form
    {
        int last = 0;
        int index = 0;
        public static string chuoi = "Select  * From Phong";
        public Search_phong()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(chuoi, data_gridview);
            Namecolumn();
        }

        private void Namecolumn()
        {

            data_gridview.Columns[0].HeaderText = "Mã phòng"; data_gridview.Columns[0].Width = 130;
            data_gridview.Columns[1].HeaderText = "Tên phòng"; data_gridview.Columns[1].Width = 130;
            data_gridview.Columns[2].HeaderText = "Loại phòng"; data_gridview.Columns[2].Width = 120;
            data_gridview.Columns[3].HeaderText = "Mô tả"; data_gridview.Columns[3].Width = 120;
            data_gridview.Columns[4].HeaderText = "Số người tối đa"; data_gridview.Columns[4].Width = 140;
        
            data_gridview.Columns[5].HeaderText = "Trạng Thái"; data_gridview.Columns[5].Width = 120;
            int sc = data_gridview.Rows.Count;
            index = 0;
            last = sc - 1;
            lbl_solg.Text = "Số lượng bản ghi : " + (sc - 1);
          
        }
        private void Search_phong_Load(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

            string tukhoa = txt_search.Text;
            String chuoi1 = "";
            if (String.Compare(cb_luachon.Text, "Mã phòng", true) == 0 || cb_luachon.SelectedItem == null)
            {
                chuoi1 = "Select * from Phong where MaPhong like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cb_luachon.Text, "Tên phòng", true) == 0)
            {
                chuoi1 = "Select * from Phong where TenPhong like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cb_luachon.Text, "Loại phòng", true) == 0)
            {
                chuoi1 = "Select * from Phong where loaiphong like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cb_luachon.Text, "Mô tả phòng", true) == 0)
            {
                chuoi1 = "Select * from Phong where Mota like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cb_luachon.Text, "Số người tối đa", true) == 0)
            {
                chuoi1 = "Select * from Phong where songtoida like N'%" + tukhoa + "%'";
            }
          
            else
            {
                chuoi1 = "Select * from Phong where trangthai like N'%" + tukhoa + "%'";
            }

            chuoiketnoi.timkiem(chuoi1, data_gridview);
            Namecolumn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_tenfile.Text == "")
            {
                MessageBox.Show("Bạn hãy đặt tên cho file trước khi xuất Excel ! ", "Thông báo ", MessageBoxButtons.OK);
                txt_tenfile.Focus();
            }
            else
            {
                string ngaythang = txt_ngaythang.Value.ToString();
                string tenbang = "THÔNG TIN PHÒNG";
                string solg = lbl_solg.Text.Trim();
                string tenfile = txt_tenfile.Text.Trim();
                string duongdan = @"C:\Users\T\Desktop\Hotel_manager\excel\quanly\";
                hamhotro.Xuat_Excel.xuat1(data_gridview, duongdan, solg, tenfile, tenbang, ngaythang);
                string mofile = duongdan + tenfile + ".xlsx";
                Process.Start(@"" + mofile);

            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
