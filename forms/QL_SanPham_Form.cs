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

namespace QL_2.forms
{
    public partial class QL_SanPham_Form : Form
    {
        private readonly FormMenu menu;
        public QL_SanPham_Form(FormMenu menu)
        {
            this.menu = menu;
            InitializeComponent();
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
    }
}
