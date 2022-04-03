﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_2.AllClass;


namespace QL_2.forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public int mark = 0;
        
        private void Login_Load(object sender, EventArgs e)
        {
            guna2ToggleSwitch1.Checked = Properties.Settings.Default.check;
            guna2TextBox_taikhoan.Text = Properties.Settings.Default.taikhoan;
        }


        private void guna2Button1_submit_Click_1(object sender, EventArgs e)
        {
            if(guna2ToggleSwitch1.Checked == true)
            {
                Properties.Settings.Default.taikhoan = guna2TextBox_taikhoan.Text;
                Properties.Settings.Default.check = guna2ToggleSwitch1.Checked;
                Properties.Settings.Default.Save();
                guna2ToggleSwitch1.Checked = Properties.Settings.Default.check;
                guna2TextBox_taikhoan.Text = Properties.Settings.Default.taikhoan;
            }
            else
            {
                Properties.Settings.Default.taikhoan = "";
                Properties.Settings.Default.check = guna2ToggleSwitch1.Checked;
                Properties.Settings.Default.Save();
                guna2TextBox_taikhoan.Text = Properties.Settings.Default.taikhoan;
                guna2ToggleSwitch1.Checked = Properties.Settings.Default.check;
            }

            TaiKhoan taiKhoan = new TaiKhoan(guna2TextBox_taikhoan.Text, guna2TextBox_pwd.Text);
            mark = taiKhoan.Login();
            if(mark == 1)
            {
                MessageBox.Show("đăng nhập thành công!!!!!!!", "thông báo bình thường");
                HomeForm childForm = new HomeForm();
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(childForm);
                this.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                childForm.Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show("Sai Mật khẩu!!", "Thông báo cực căng");

            }
        }
    }
}
