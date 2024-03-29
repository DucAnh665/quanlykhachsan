﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuanLy_KhachSan.quanly
{
    public partial class Customer_Manager : Form
    {
        int index = 0;
        int last = 0;
        public static string chuoi = "Select  * From Khachhang";
        public Customer_Manager()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(chuoi, data_gridview);
            Namecolumn();
        }
        private void Namecolumn()
        {

            data_gridview.Columns[0].HeaderText = "Mã khách"; data_gridview.Columns[0].Width = 130;
            data_gridview.Columns[1].HeaderText = "Tên khách"; data_gridview.Columns[1].Width = 130;
            data_gridview.Columns[2].HeaderText = "Ngày sinh"; data_gridview.Columns[2].Width = 100;
            data_gridview.Columns[3].HeaderText = "Giới tính"; data_gridview.Columns[3].Width = 120;
            data_gridview.Columns[4].HeaderText = "Số điện thoại"; data_gridview.Columns[4].Width = 120;
            data_gridview.Columns[5].HeaderText = "Số CMTND"; data_gridview.Columns[5].Width = 120;
            data_gridview.Columns[6].HeaderText = "Email"; data_gridview.Columns[6].Width = 120;
            int sc = data_gridview.Rows.Count;
            index = 0;
            last = sc - 1;
            lbl_solg.Text = "Số lượng bản ghi : " + (sc - 1);
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
        }

        private void PopulateData(int curow)
        {
            string gt = "";

            txt_manv.Text = data_gridview.Rows[curow].Cells[0].Value.ToString();
            txt_tennv.Text = data_gridview.Rows[curow].Cells[1].Value.ToString();
            txt_date.Text = data_gridview.Rows[curow].Cells[2].Value.ToString();
            gt = data_gridview.Rows[curow].Cells[3].Value.ToString();
            if (String.Compare(gt, "Nam") == 0)
                rb_nam.Checked = true;
            else
                rb_nu.Checked = true;
            txt_sdt.Text = data_gridview.Rows[curow].Cells[4].Value.ToString();
            txt_cmtnd.Text = data_gridview.Rows[curow].Cells[5].Value.ToString();
            txt_email.Text = data_gridview.Rows[curow].Cells[6].Value.ToString();

            txt_manv.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;

        }
        // Hàm check Gmail
        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        public void Clear()
        {
            txt_manv.Enabled = true;
            txt_tennv.Text = "";
            txt_email.Text = "";
            txt_cmtnd.Text = "";
            txt_sdt.Text = "";
            txt_manv.Text = "";
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;

            txt_manv.Focus();

        }
        // them click
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_manv.Text == "" || txt_tennv.Text == "" || txt_sdt.Text == "" || txt_email.Text == "" || txt_cmtnd.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string manv = txt_manv.Text.Trim();
                if (manv.Length > 15)
                {
                    MessageBox.Show("mã sách quá dài ! chỉ nhập nhiều nhất 15 ký tự", "Error", MessageBoxButtons.OK);
                    txt_manv.Text = "";
                    txt_manv.Focus();

                }
                else
                {
                    if (isEmail(txt_email.Text) == false)
                    {

                        MessageBox.Show("Mail không chính xác , vui lòng kiểm tra lại !", "Error", MessageBoxButtons.OK);
                        txt_email.Text = "";
                        txt_email.Focus();
                    }
                    else
                    {
                        string gt = "";
                        if (rb_nam.Checked == true)
                            gt = "Nam";
                        else
                            gt = "Nữ";

                        string sql = "Select count(*) from Khachhang where MaKh ='" + manv + "'";
                        string sql1 = "Insert into Khachhang values(N'" + txt_manv.Text + "',";
                        sql1 += "N'" + txt_tennv.Text + "','" + txt_date.Text + "',N'" + gt.Trim() + "','" + txt_sdt.Text + "','" + txt_cmtnd.Text + "',";
                        sql1 += "'" + txt_email.Text + "' )";
                        chuoiketnoi.them(sql1);
                        chuoiketnoi.Chuoiketnoi(chuoi, data_gridview);
                        Namecolumn();
                        

                    }

                }
            }
        }

        private void Customer_Manager_Load(object sender, EventArgs e)
        {

        }

        private void data_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            index = data_gridview.CurrentRow.Index;
            PopulateData(index);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            
            string gt = "";
            if (rb_nam.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            if (isEmail(txt_email.Text) == false)
            {

                MessageBox.Show("Mail không chính xác , vui lòng kiểm tra lại !", "Error", MessageBoxButtons.OK);
                txt_email.Text = "";
                txt_email.Focus();
            }
            else
            {
                string sql = "Update Khachhang set Tenkh = N'" + txt_tennv.Text + "',";
                sql += "Ngaysinh = N'" + txt_date.Text + "',";
                sql += "gioitinh = N'" + gt.Trim() + "',sdt = '" + txt_sdt.Text + "',Cmnd='" + txt_cmtnd.Text + "',Email='" + txt_email.Text + "'";
                sql += "where MaKh = '" + txt_manv.Text + "'";
                chuoiketnoi.Sua(sql);
                chuoiketnoi.Chuoiketnoi(chuoi, data_gridview);
                Namecolumn();
                Clear();
            }
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from Khachhang where Makh = N'" + txt_manv.Text + "'";
            chuoiketnoi.Xoa(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, data_gridview);
            Namecolumn();

            Clear();
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dau_Click(object sender, EventArgs e)
        {
            index = 0;
            PopulateData(index);
            data_gridview.CurrentCell = data_gridview.Rows[index].Cells[0];
        }

        private void truoc_Click(object sender, EventArgs e)
        {
            index--;
            index = index < 0 ? 0 : index;
            PopulateData(index);
            data_gridview.CurrentCell = data_gridview.Rows[index].Cells[0];
        }

        private void sau_Click(object sender, EventArgs e)
        {

            index = index + 1;
            if (index >= last)
            {
                index = 0;

                PopulateData(index);
                data_gridview.CurrentCell = data_gridview.Rows[index].Cells[0];
            }
            else
            {
                PopulateData(index);
                data_gridview.CurrentCell = data_gridview.Rows[index].Cells[0];
            }
        }

        private void cuoi_Click(object sender, EventArgs e)
        {
            index = last - 1;
            PopulateData(index);
            data_gridview.CurrentCell = data_gridview.Rows[index].Cells[0];
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txt_search.Text;
            String chuoi1 = "";
            if (cb_luachon.Text == "Mã khách" || cb_luachon.SelectedItem == null)
            {
                chuoi1 = "Select * from Khachhang where Makh like N'%" + tukhoa + "%'";
            }
            else if (cb_luachon.SelectedItem == "Tên Khách")
            {
                chuoi1 = "Select * from Khachhang where Tenkh like N'%" + tukhoa + "%'";
            }
            else if (cb_luachon.SelectedItem == "giới tính")
            {
                chuoi1 = "Select * from Khachhang where gioitinh like N'%" + tukhoa + "%'";
            }
            else if (cb_luachon.SelectedItem == "số điện thoại")
            {
                chuoi1 = "Select * from Khachhang where sdt like N'%" + tukhoa + "%'";
            }
            else
            {
                chuoi1 = "Select * from Khachhang where cmnd like N'%" + tukhoa + "%'";
            }

            chuoiketnoi.timkiem(chuoi1, data_gridview);
            Namecolumn();
        }
    }
}
