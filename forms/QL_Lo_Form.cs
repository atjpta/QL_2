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
    public partial class QL_Lo_Form : Form
    {
        private SqlAll sqlAll = new SqlAll();
        List<Lo> los = new List<Lo>();
        public QL_Lo_Form()
        {
            InitializeComponent();
            Refresh_Lo();
        }

        private void Refresh_Lo()
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

        private void ClearTableRows()
        {
            dataGridView_Lo.Rows.Clear();
        }

        private void dataGridView_Lo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string message = "Bạn có muốn xóa lô này?";
            string title = "Xóa lô";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = this.dataGridView_Lo.Rows[e.RowIndex];
                var maLo = row.Cells[0].Value.ToString();
                sqlAll.Delete_Lo(maLo);
                Refresh_Lo();
            }
            else
            {
            }
        }

        
    }
}
