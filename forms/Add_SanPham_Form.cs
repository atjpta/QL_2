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
    public partial class Add_SanPham_Form : Form
    {
        private readonly QL_SanPham_Form qL_SanPham;
        public Add_SanPham_Form(QL_SanPham_Form qL_SanPham)
        {
            this.qL_SanPham = qL_SanPham;
            InitializeComponent();
        }

       
    }
}
