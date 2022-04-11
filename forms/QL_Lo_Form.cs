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
using QL_2.forms;

namespace QL_2.forms
{
    public partial class QL_Lo_Form : Form
    {
        private readonly FormMenu menu;
        private SqlAll sqlAll = new SqlAll();
        List<Lo> los = new List<Lo>();
        public QL_Lo_Form(FormMenu menu)
        {
            this.menu = menu;
            InitializeComponent();
            Refresh_Lo();
        }


        // lam moi ds 
        public void Refresh_Lo()
        {
            ClearTableRows();
            los = sqlAll.GetALL_Lo();
            int i = 0;
            while (los.Count() != i)
            {
                dataGridView_Lo.Rows.Insert
                    (
                        i,
                        los[i].Malo,
                        los[i].Nsx.ToString("dd/MM/yyyy"),
                        los[i].Hsd.ToString("dd/MM/yyyy")
                    );
                i++;
            }
        }
       

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox_Finding.Text == "")
                {
                    ClearTableRows();
                    Refresh_Lo();
                }
                else
                {
                    ClearTableRows();
                    for (int i = 0; i < los.Count(); i++)
                    {
                        int j = 0;
                        if (los[i].Malo.ToUpper().Contains(textBox_Finding.Text.ToUpper()))
                        {
                            dataGridView_Lo.Rows.Insert
                            (
                                j, 
                                los[i].Malo, 
                                los[i].Nsx.ToString("dd/MM/yyyy"),
                                los[i].Hsd.ToString("dd/MM/yyyy")
                            );
                            j++;
                        }
                    }
                }
            }

        }

        // xóa ds
        private void ClearTableRows()
        {
            dataGridView_Lo.Rows.Clear();
        }


        //lay lo từ hàng 
        private string Get_Ma_Lo(DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView_Lo.Rows[e.RowIndex];
            return row.Cells[0].Value.ToString();
        }

        private void dataGridView_Lo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_Lo.RowCount)
            {
                if (e.ColumnIndex == 3)
                {
                    Update_Lo_Form update = new Update_Lo_Form(this, this.Get_Ma_Lo(e));
                    update.ShowDialog();
                }
                if (e.ColumnIndex == 4)
                {
                    string message = "Bạn có muốn xóa lô này?";
                    string title = "Xóa lô";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        sqlAll.Delete_Lo(this.Get_Ma_Lo(e));
                        Refresh_Lo();
                    }
                }
            }

                
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Add_lo_Form add = new Add_lo_Form(this);
            add.ShowDialog();
 
        }

        private void guna2Button_refresh_Click(object sender, EventArgs e)
        {
            Refresh_Lo();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            QL_SanPham_Form qL_SanPham = new QL_SanPham_Form(menu);
            menu.OpenchildForm(qL_SanPham);
            menu.chargeTitle("Kho");
        }

      
    }
}
