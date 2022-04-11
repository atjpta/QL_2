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
    public partial class Add_SanPham_Form : Form
    {

        SqlAll sqlAll = new SqlAll();

        List<Lo> los = new List<Lo>();

        private readonly QL_SanPham_Form qL_SanPham;

        public Add_SanPham_Form(QL_SanPham_Form qL_SanPham)
        {
            this.qL_SanPham = qL_SanPham;
            InitializeComponent();

            Load_Lo_intoComboBox();
        }

        private bool KiemTraSanPham()
        {
            if (guna2TextBox_Ten_san_pham.Text == "")
            {
                MessageBox.Show("Hãy nhập Tên sản phẩm", "Thông báo cực căng");
                return false;
            }

            if(guna2ComboBox_Lo.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn mã lô", "Thông báo cực căng");
                return false;
            }

            if(guna2NumericUpDown_SoLuong.Value <= 0)
            {
                MessageBox.Show("Hãy nhập số lượng lớn hơn 0", "Thông báo cực căng");
                return false;
            }

            if(guna2TextBox_Don_vi_tinh.Text == "")
            {
                MessageBox.Show("Hãy nhập Đơn vị tính", "Thông báo cực căng");
                return false;
            }

            if (pictureBox_UploadedPicture.Image == null)
            {
                MessageBox.Show("Hãy nhập Nhập hình ảnh", "Thông báo cực căng");
                return false;
            }

            return true;
        }

        private void ThemSanPham()
        {
            if (KiemTraSanPham())
            {
                SanPham sanPham = new SanPham
                    (
                    Int32.Parse(guna2TextBox_NhanVien.Text), 
                    guna2ComboBox_Lo.Text, 
                    guna2TextBox_Ten_san_pham.Text, 
                    guna2TextBox_Don_vi_tinh.Text,
                    (int)guna2NumericUpDown_SoLuong.Value,
                    ImageToByteArray(pictureBox_UploadedPicture)
                    );

                sqlAll.Add_SanPham(sanPham);

                guna2NumericUpDown_SoLuong.Value = 0;
                guna2ComboBox_Lo.Text = "";
                guna2TextBox_Ten_san_pham.Text = "";
                guna2TextBox_Don_vi_tinh.Text = "";
                pictureBox_UploadedPicture.Image = null;
            }
        }

        private void Load_Lo_intoComboBox()
        {
            los = sqlAll.GetALL_Lo();
            for (int i = 0; i < los.Count; i++)
            {
                guna2ComboBox_Lo.Items.Add(los[i].Malo);
            }
        }

        private void guna2Button_AddPicture_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif, *.jpg, *jpeg, *.bmp, *.png)| *.gif; *.jpg; *jpeg; *.bmp; *.png";

            if( openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_UploadedPicture.ImageLocation = openFileDialog.FileName;
            }

        }

        private void guna2Button_Add_SanPham_Click(object sender, EventArgs e)
        {
            ThemSanPham();
        }

        public byte[] ImageToByteArray(PictureBox pictureBox)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);

            return ms.ToArray();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Add_SanPham_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            qL_SanPham.GetAllListOfSanPham();
        }
    }
}
