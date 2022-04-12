using System;
using System.IO;
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
    public partial class Add_SP_Form : Form
    {
        Sql_lo sqllo = new Sql_lo();

        sql_SanPham sql_SanPham = new sql_SanPham();

        List<Lo> los = new List<Lo>();

        private int id_nv;

        private readonly QL_SP_Form qL_SanPham;

        public Add_SP_Form(QL_SP_Form qL_SanPham, int id_nv)
        {
            this.qL_SanPham = qL_SanPham;
            InitializeComponent();
            Load_Lo_intoComboBox();
            this.id_nv = id_nv;
        }

        private bool KiemTraSanPham()
        {
            if (guna2TextBox1_name_sp.Text == "")
            {
                MessageBox.Show("Hãy nhập Tên sản phẩm", "Thông báo cực căng");
                return false;
            }

            if (guna2ComboBox_malo.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn mã lô", "Thông báo cực căng");
                return false;
            }

            if (guna2NumericUpDown2_sl.Value <= 0)
            {
                MessageBox.Show("Hãy nhập số lượng lớn hơn 0", "Thông báo cực căng");
                return false;
            }

            if (guna2TextBox_donvitinh.Text == "")
            {
                MessageBox.Show("Hãy nhập Đơn vị tính", "Thông báo cực căng");
                return false;
            }

            if (guna2PictureBox_img.Image == null)
            {
                MessageBox.Show("Hãy nhập Nhập hình ảnh", "Thông báo cực căng");
                return false;
            }

            return true;
        }

       

        private void Load_Lo_intoComboBox()
        {
            los = sqllo.GetALL_Lo();
            for (int i = 0; i < los.Count; i++)
            {
                guna2ComboBox_malo.Items.Add(los[i].Malo);
            }
        }

        public byte[] ImageToByteArray(PictureBox pictureBox)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
            return ms.ToArray();
        }

      

        private void Add_SanPham_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //qL_SanPham.GetAllListOfSanPham();
        }

        private void guna2Button_add_Click(object sender, EventArgs e)
        {
            if (KiemTraSanPham())
            {
                SanPham sanPham = new SanPham
                    (
                    this.id_nv,
                    guna2ComboBox_malo.Text,
                    guna2TextBox1_name_sp.Text,
                    guna2TextBox_donvitinh.Text,
                    (int)guna2NumericUpDown_dongia.Value,
                    (int)guna2NumericUpDown2_sl.Value,
                    ImageToByteArray(guna2PictureBox_img)
                    );

                if (sql_SanPham.Add_SanPham(sanPham))
                {
                    this.Close();
                }
            }
        }

        private void guna2Button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif, *.jpg, *jpeg, *.bmp, *.png)| *.gif; *.jpg; *jpeg; *.bmp; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                guna2PictureBox_img.ImageLocation = openFileDialog.FileName;
            }
        }

      
    }
}