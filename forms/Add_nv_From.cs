using System;
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
    public partial class Add_nv_From : Form
    {
        private readonly QL_NV_Form ql_NhanVien_Form;
        public Add_nv_From(QL_NV_Form ql_NhanVien_Form)
        {
            this.ql_NhanVien_Form = ql_NhanVien_Form;
            InitializeComponent();
            dateTimePicker_date.Format = DateTimePickerFormat.Custom;
            dateTimePicker_date.CustomFormat = "dd/MM/yyyy";
            guna2TextBox2.MaxLength = 10;
        }

        private string GetSex(string sex)
        {
            if (sex == "Nam")
            {
                return "M";
            }
            if (sex == "Nữ")
            {
                return "F";
            }
            return "O";
        }

        private void guna2Button1_update_nv_Click(object sender, EventArgs e)
        {
            if(guna2TextBox_name.Text == "")
            {
                MessageBox.Show( "Bạn chưa nhập tên!!!", "Thông báo cực căng !!!!");
                return;
            }

            if (guna2TextBox_username.Text == "" )
            {
                MessageBox.Show( "Bạn chưa nhập tài khoản!!!","Thông báo cực căng !!!!");
                return;
            }

            if (guna2TextBox_address.Text == "")
            {
                MessageBox.Show( "Bạn chưa nhập địa chỉ!!!","Thông báo cực căng !!!!");
                return;
            }
            if (guna2TextBox2.TextLength != 10)
            {
                MessageBox.Show( "Bạn đã nhập thiếu số điện thoại!!!","Thông báo cực căng !!!!");
                return;
            }
            NhanVien nv = new NhanVien(
                guna2TextBox_username.Text,
                guna2TextBox_name.Text,
                GetSex(guna2ComboBox_sex.Text),
                dateTimePicker_date.Value,
                guna2TextBox_address.Text,
                guna2TextBox2.Text,
                (guna2ComboBox_chuc_vu.SelectedIndex + 1).ToString()
                );
            Sql_NhanVien sql = new Sql_NhanVien();
            int mark = sql.add_nv(nv);
            if (mark == 1)
            {
                MessageBox.Show("bạn đã thêm thành công!!!", "Thông báo cực căng !!!!");
                ql_NhanVien_Form.Refresh_nv();
                this.Close();
            }         
        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void guna2Button3_delete_nv_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
