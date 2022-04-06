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
    
    public partial class Add_lo_Form : Form
    {
        private readonly QL_Lo_Form qL_Lo;
        private Lo lo;

        public Add_lo_Form(QL_Lo_Form qL_Lo )
        {
            this.qL_Lo = qL_Lo; 
            InitializeComponent();
            dateTimePicker_Nsx.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Hsd.Format = DateTimePickerFormat.Custom;

            dateTimePicker_Nsx.CustomFormat = " dd/MM/yyyy";
            dateTimePicker_Hsd.CustomFormat = " dd/MM/yyyy";

            dateTimePicker_Hsd.MinDate = DateTime.Today;


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(guna2TextBox_MaLo.Text.Trim().Length < 1)
            {
                MessageBox.Show("Nhập mã lô !!", "Thông báo cực căng");
                return;
            }

            lo = new Lo
                (
                    guna2TextBox_MaLo.Text,
                    dateTimePicker_Nsx.Value,
                    dateTimePicker_Hsd.Value
                );
            SqlAll sqlAll = new SqlAll();
            if (sqlAll.Add_Lo(lo))
            {
                qL_Lo.Refresh_Lo();
                this.Close();
            }
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
