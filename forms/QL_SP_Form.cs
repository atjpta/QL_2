using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_2.forms;
using QL_2.AllClass;

namespace QL_2.forms
{
    public partial class QL_SP_Form : Form
    {
        private readonly FormMenu menu;
        List<SanPham> sanPhams = new List<SanPham>();
        List<SanPham> sanPhams2;
        SanPham sp_update = null;

        private sql_SanPham sql = new sql_SanPham();
        public QL_SP_Form(FormMenu menu)
        {
            this.menu = menu;
            InitializeComponent();
            Refresh_sp();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Add_SP_Form add = new Add_SP_Form(this, menu.current_id_nv);
            add.ShowDialog();
        }

        private void ClearTableRows()
        {
            dataGridView_SanPham.Rows.Clear();
        }

        public void Refresh_sp()
        {
            ClearTableRows();

            dataGridView_SanPham.Rows.Clear();

            sanPhams = sql.GetAll_SanPham(); // lay het san pham trong DB

            for (int i = 0; i < sanPhams.Count; i++)
            {
                dataGridView_SanPham.Rows.Insert(
                    i, 
                    Image.FromStream(sanPhams[i].GetImgStream()),
                    sanPhams[i].Ten_san_pham);
            }
            sanPhams2 = sanPhams;
        }

        public void print_sp()
        {
            ClearTableRows();
            for (int i = 0; i < sanPhams2.Count; i++)
            {
                dataGridView_SanPham.Rows.Insert(
                    i,
                    Image.FromStream(sanPhams2[i].GetImgStream()),
                    sanPhams2[i].Ten_san_pham);
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            QL_Lo_Form qL_Lo = new QL_Lo_Form(menu);
            menu.OpenchildForm(qL_Lo);
            menu.chargeTitle("Kho");
        }

        private void guna2Button_refresh_Click(object sender, EventArgs e)
        {
            Refresh_sp();
        }

        private void guna2Button2_add_nv_Click(object sender, EventArgs e)
        {
            Add_SP_Form add = new Add_SP_Form(this, menu.current_id_nv);
            add.ShowDialog();
        }

        private void dataGridView_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_SanPham.RowCount)
            {
                label3_nv.Text = sanPhams2[e.RowIndex].Name_nv;
                label_name_sp.Text = sanPhams2[e.RowIndex].Ten_san_pham;
                label_malo.Text = sanPhams2[e.RowIndex].Malo;
                label_dongia.Text = sanPhams2[e.RowIndex].DON_GIA.ToString();
                label_donvitinh.Text = sanPhams2[e.RowIndex].Don_vi_tinh;
                label_sl.Text = sanPhams2[e.RowIndex].Malo;
                sp_update = sanPhams[e.RowIndex];
            }
            else
            {
                label3_nv.Text = "";
                label_name_sp.Text = "";
                label_malo.Text = "";
                label_dongia.Text = "";
                label_donvitinh.Text = "";
                label_sl.Text = "";
                sp_update = null;
            }
        }

        private void textBox_Finding_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox_Finding.Text == "")
                {
                    ClearTableRows();
                    Refresh_sp();
                }
                else
                {
                    List<SanPham> temp = new List<SanPham>();
                    for (int i = 0; i < sanPhams.Count; i++)
                    {
                        if (sanPhams[i].Ten_san_pham.ToUpper().Contains(textBox_Finding.Text.ToUpper()))
                        {
                            temp.Add(sanPhams[i]);
                        }
                    }
                    sanPhams2 = temp;
                    print_sp();

                }
            }
        }

        private void guna2Button1_update_nv_Click(object sender, EventArgs e)
        {
            if (sp_update == null)
            {
                MessageBox.Show("vui lòng chọn sản phẩm muốn sửa!!", "Thông báo cực căng");
            }
            else
            {
                Update_sp_Form update = new Update_sp_Form(this, sp_update.Id_san_pham);
                update.ShowDialog();
            }
        }
    }
}
