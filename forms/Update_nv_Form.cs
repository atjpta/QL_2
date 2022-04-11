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
    public partial class Update_nv_Form : Form
    {
        private readonly QL_NhanVien_Form ql_NhanVien_Form;
        NhanVien nv;
        Sql_NhanVien sql = new Sql_NhanVien();
        public Update_nv_Form(QL_NhanVien_Form ql_NhanVien_Form, string username)
        {
            nv = sql.find_username(username);
            InitializeComponent();
            this.ql_NhanVien_Form = ql_NhanVien_Form;
            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = " dd/MM/yyyy";
            text_sdt.MaxLength = 10;

            text_name.Text = nv.Name_nv;
            text_usename.Text = nv.Username;
            combo_sex.Text = nv.Sex;
            date.Value = nv.Date;
            text_address.Text = nv.Address;
            text_sdt.Text = nv.Sdt;
            combo_chuc_vu.Text = nv.Chuc_vu;
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (text_name.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!!!", "Thông báo cực căng !!!!");
                return;
            }

            if (text_usename.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản!!!", "Thông báo cực căng !!!!");
                return;
            }

            if (text_address.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!!!", "Thông báo cực căng !!!!");
                return;
            }
            if (text_sdt.TextLength != 10)
            {
                MessageBox.Show("Bạn đã nhập thiếu số điện thoại!!!", "Thông báo cực căng !!!!");
                return;
            }
            NhanVien nv_update = new NhanVien(
                nv.ID_NV,
                text_usename.Text,
                text_name.Text,
                GetSex(combo_sex.Text),
                date.Value,
                text_address.Text,
                text_sdt.Text,
                (combo_chuc_vu.SelectedIndex + 1).ToString()
                );
            int mark = sql.update_nv(nv_update);
            if (mark == 1)
            {
                MessageBox.Show("bạn đã sửa thành công!!!", "Thông báo cực căng !!!!");
                ql_NhanVien_Form.Refresh_nv();
                this.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
