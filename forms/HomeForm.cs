using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_2.forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void OpenForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
            form.Dock = DockStyle.Fill;
        }

        private void guna2Button2_kho_Click(object sender, EventArgs e)
        {
            OpenForm(new QL_Lo_Form());
        }
    }
}
