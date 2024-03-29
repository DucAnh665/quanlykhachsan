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
    public partial class Search_nhanvien : Form
    {
        public static string chuoi = "Select  * From Nhanvien";
        int index = 0;
        int last = 0;
        public Search_nhanvien()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(chuoi, data_gridview);
            Namecolumn();
        }
        private void Namecolumn()
        {

            data_gridview.Columns[0].HeaderText = "Mã nhân viên"; data_gridview.Columns[0].Width = 130;
            data_gridview.Columns[1].HeaderText = "Tên nhân viên"; data_gridview.Columns[1].Width = 130;
            data_gridview.Columns[2].HeaderText = "Ngày sinh"; data_gridview.Columns[2].Width = 100;
            data_gridview.Columns[3].HeaderText = "Giới tính"; data_gridview.Columns[3].Width = 120;
            data_gridview.Columns[4].HeaderText = "Số điện thoại"; data_gridview.Columns[4].Width = 120;
            data_gridview.Columns[5].HeaderText = "Số CMTND"; data_gridview.Columns[5].Width = 120;
            data_gridview.Columns[6].HeaderText = "Email"; data_gridview.Columns[6].Width = 120;
            int sc = data_gridview.Rows.Count;
            index = 0;
            last = sc - 1;
            lbl_solg.Text = "Số lượng bản ghi : " + (sc - 1);

        }
        private void Search_nhanvien_Load(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txt_search.Text;
            String chuoi1 = "";
            if (cb_luachon.Text == "Mã nhân viên" || cb_luachon.SelectedItem == null)
            {
                chuoi1 = "Select * from Nhanvien where Manv like N'%" + tukhoa + "%'";
            }
            else if (cb_luachon.SelectedItem == "Tên nhân viên")
            {
                chuoi1 = "Select * from Nhanvien where Tennv like N'%" + tukhoa + "%'";
            }
            else if (cb_luachon.SelectedItem == "giới tính")
            {
                chuoi1 = "Select * from Nhanvien where gioitinh like N'%" + tukhoa + "%'";
            }
            else if (cb_luachon.SelectedItem == "số điện thoại")
            {
                chuoi1 = "Select * from Nhanvien where sdt like N'%" + tukhoa + "%'";
            }
            else
            {
                chuoi1 = "Select * from Nhanvien where cmnd like N'%" + tukhoa + "%'";
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
            string tenbang = "THÔNG TIN NHÂN VIÊN";
            string solg = lbl_solg.Text.Trim();
            string tenfile = txt_tenfile.Text.Trim();
            string duongdan = @"C:\Users\T\Desktop\Hotel_manager\excel\quanly\";
            hamhotro.Xuat_Excel.xuat1(data_gridview, duongdan, solg, tenfile,tenbang,ngaythang);
            string mofile = duongdan + tenfile+".xlsx";
            Process.Start(@""+mofile);

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
