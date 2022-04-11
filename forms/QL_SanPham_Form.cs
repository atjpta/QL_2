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
    public partial class QL_SanPham_Form : Form
    {
        SqlAll sqlAll = new SqlAll();

        List<SanPham> sanPhams = new List<SanPham>();

        private readonly FormMenu menu;
        public QL_SanPham_Form(FormMenu menu)
        {
            this.menu = menu;
            InitializeComponent();

            GetAllListOfSanPham();

        }

        public void GetAllListOfSanPham()
        {
            sanPhams.Clear();

            dataGridView_SanPham.Rows.Clear();

            sanPhams = sqlAll.GetAll_SanPham(); // lay het san pham trong DB

            for (int i = 0; i < sanPhams.Count; i++)
            {
                dataGridView_SanPham.Rows.Add(Image.FromStream(sanPhams[i].GetImgStream()), sanPhams[i].Ten_san_pham, sanPhams[i].Id_san_pham, sanPhams[i].Don_vi_tinh, sanPhams[i].So_luong_ton_kho);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Add_SanPham_Form add = new Add_SanPham_Form(this);
            add.ShowDialog();
        }

        private void guna2Button_switch_Click(object sender, EventArgs e)
        {
            QL_Lo_Form qL_Lo = new QL_Lo_Form(menu);
            menu.OpenchildForm(qL_Lo);     
            menu.chargeTitle("Kho");

        }

        private void dataGridView_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                Form updateSanPhamForm = new Update_SanPham_Form(this, sanPhams[e.RowIndex].Id_san_pham);

                updateSanPhamForm.Show();
            }
            if (e.ColumnIndex == 6)
            {
                MessageBox.Show("Hello World");
            }

        }

        public void guna2Button_refresh_Click(object sender, EventArgs e)
        {
            GetAllListOfSanPham();
        }

        private void QL_SanPham_Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
