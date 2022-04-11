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
    public partial class Update_Lo_Form : Form
    {
        private Lo lo;
        private readonly QL_Lo_Form qL_Lo;

        public Update_Lo_Form(QL_Lo_Form ql_Lo, string Malo)
        {
            this.qL_Lo = ql_Lo;
            InitializeComponent();
            SqlAll sqlAll = new SqlAll();
            lo = sqlAll.Find_Lo(Malo);
            label_fix_maLo.Text = lo.Malo;
            dateTimePicker_Nsx.Value = lo.Nsx;
            dateTimePicker_Hsd.Value = lo.Hsd;

            dateTimePicker_Nsx.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Hsd.Format = DateTimePickerFormat.Custom;

            dateTimePicker_Nsx.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_Hsd.CustomFormat = "dd/MM/yyyy";

            dateTimePicker_Hsd.MinDate = DateTime.Today;

            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            SqlAll sqlAll = new SqlAll();
            Lo temp = new Lo
                (
                    label_fix_maLo.Text,
                    dateTimePicker_Nsx.Value,
                    dateTimePicker_Hsd.Value
                );
            if (sqlAll.Update_Lo_db(temp))
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
