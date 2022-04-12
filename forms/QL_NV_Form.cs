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
    public partial class QL_NV_Form : Form
    {
        private readonly FormMenu menu;
        private List<NhanVien> ds_nv;
        private List<NhanVien> ds_nv_s;
        private NhanVien nv_update = null;

        private Sql_NhanVien sql_NhanVien = new Sql_NhanVien();
        public QL_NV_Form(FormMenu menu)
        {
            this.menu = menu;
            InitializeComponent();
            Refresh_nv();
        }

        public void Refresh_nv()
        {
            ClearTableRows();
            ds_nv = sql_NhanVien.GetAll_Nhanvien();
            int i = 0;
            while (ds_nv.Count() != i)
            {
                dataGridView_NhanVien.Rows.Insert
                    (
                        i,
                        ds_nv[i].Name_nv,
                        ds_nv[i].Username
                    );
                i++;
            }
            ds_nv_s = ds_nv;
        }
        public void print_nv()
        {
            ClearTableRows();
            int i = 0;
            while (ds_nv_s.Count() != i)
            {
                dataGridView_NhanVien.Rows.Insert
                    (
                        i,
                        ds_nv_s[i].Name_nv,
                        ds_nv[i].Username
                    );
                i++;
            }
        }

        private void ClearTableRows()
        {
            dataGridView_NhanVien.Rows.Clear();
        }

        private void guna2Button_refresh_Click(object sender, EventArgs e)
        {
            Refresh_nv();
        }

        private string GetSex(string sex)
        {
            if(sex == "M")
            {
                return "Nam";
            }
            if(sex == "F")
            {
                return "Nữ";
            }
            return "Khác";
        }

        private void dataGridView_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < dataGridView_NhanVien.RowCount)
            {
                label_name_nv.Text = ds_nv_s[e.RowIndex].Name_nv;
                label_usename.Text = ds_nv_s[e.RowIndex].Username;
                label_sex.Text = GetSex(ds_nv_s[e.RowIndex].Sex);
                label_date.Text = ds_nv_s[e.RowIndex].Date.ToString("dd/MM/yyyy");
                label_address.Text = ds_nv_s[e.RowIndex].Address;
                label_sdt.Text = ds_nv_s[e.RowIndex].Sdt.ToString();
                label_chuc_vu.Text = ds_nv_s[e.RowIndex].Chuc_vu;
                nv_update = ds_nv_s[e.RowIndex];
            }
            else
            {
                label_name_nv.Text = "";
                label_usename.Text = "";
                label_sex.Text = "";
                label_date.Text = "";
                label_address.Text = "";
                label_sdt.Text = "";
                label_chuc_vu.Text = "";
                nv_update = null;
            }
            
        }

        private void textBox_Finding_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox_Finding.Text == "")
                {
                    ClearTableRows();
                    Refresh_nv();
                }
                else
                {
                    List<NhanVien> temp = new List<NhanVien>();
                    for (int i = 0; i < ds_nv.Count; i++)
                    {
                        if (ds_nv[i].Name_nv.ToUpper().Contains(textBox_Finding.Text.ToUpper()) || ds_nv[i].Username.ToUpper().Contains(textBox_Finding.Text.ToUpper()))
                        {
                            temp.Add(ds_nv[i]);
                        }
                    }
                    ds_nv_s = temp;
                    print_nv();
                    
                }
            }
        }

        private void guna2Button2_add_nv_Click(object sender, EventArgs e)
        {
            Add_nv_From add = new Add_nv_From(this);
            add.ShowDialog();
        }

        private void guna2Button1_update_nv_Click(object sender, EventArgs e)
        {
            if(nv_update == null)
            {
                MessageBox.Show("vui lòng chọn nhân viên muốn sửa!!", "Thông báo cực căng");
            }
            else
            {
                Update_nv_Form update = new Update_nv_Form(this, nv_update.Username);
                update.ShowDialog();
            }
            
        }
    }
}
