﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLy_KhachSan
{
    public partial class Main_chinh : Form
    {
        public Main_chinh()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            dangnhap.Login a = new dangnhap.Login();
           
            a.Show();
            this.Hide();
        }

        private void Registratuion_Click(object sender, EventArgs e)
        {

            dangnhap.Registration a1 = new dangnhap.Registration();
            
            a1.Show();
            this.Hide();
        }

        private void lbform_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String tt = "";
            tt += "Phần mềm : Quản lý Khách sạn \n";
            tt += "\n ";
            tt += "version : 1.1";
            tt += "\n\n";
            tt += " Học phần : Thực tập Lập trình .net";
            tt += "\t";
            tt += " ____Bài tập lớn____ ";
            tt += "\n";
            tt += "\nSinh viên thực hiện : ";
            tt += "\n- Phạm Đức Hiệp ";
            tt += "\n- Bùi thu hương ";
            tt += "\n- Trần thị huyền ";
            tt += "\nversion : 1.1 @ năm 2020  \n\n";
           
            MessageBox.Show("" + tt, "Thông tin phần mềm", MessageBoxButtons.OK);
        }

        private void đăngNhậpHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap.Login a = new dangnhap.Login();

            a.Show();
            this.Hide();
        }

        private void đăngKýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap.Registration a1 = new dangnhap.Registration();

            a1.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
              
                this.Close();
            }
        }
    }
}
