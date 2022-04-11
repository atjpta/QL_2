using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using QL_2.AllClass;

namespace QL_2.forms
{
    public partial class Update_SanPham_Form : Form
    {
        SanPham sanPham;

        List<Lo> los = new List<Lo>();

        SqlAll sqlAll = new SqlAll();

        private QL_SanPham_Form qL_SanPham_Form;

        public Update_SanPham_Form(QL_SanPham_Form parentForm, int idSanpham)
        {
            InitializeComponent();

            qL_SanPham_Form = parentForm;

            Load_Lo_intoComboBox();

            sanPham = sqlAll.Find_SanPham(idSanpham);

            guna2TextBox_Ten_san_pham.Text = sanPham.Ten_san_pham;
            guna2ComboBox_Lo.Text = sanPham.Malo;
            guna2NumericUpDown_SoLuong.Value = sanPham.So_luong_ton_kho;
            guna2TextBox_Don_vi_tinh.Text = sanPham.Don_vi_tinh;

            pictureBox_UploadedPicture.Image = Image.FromStream(sanPham.GetImgStream());


        }


        private void Load_Lo_intoComboBox()
        {
            los = sqlAll.GetALL_Lo();
            for (int i = 0; i < los.Count; i++)
            {
                guna2ComboBox_Lo.Items.Add(los[i].Malo);
            }
        }

        public byte[] ImageToByteArray(PictureBox pictureBox)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);

            return ms.ToArray();
        }

        private void guna2Button_Add_SanPham_Click(object sender, EventArgs e)
        {
            SanPham sanPhamEdited = new SanPham
                (
                sanPham.Id_san_pham,
                sanPham.Id_nhan_vien,
                guna2ComboBox_Lo.Text,
                guna2TextBox_Ten_san_pham.Text, 
                guna2TextBox_Don_vi_tinh.Text, 
                (int)guna2NumericUpDown_SoLuong.Value, 
                ImageToByteArray(pictureBox_UploadedPicture)
                );

            guna2TextBox_NhanVien.Text = sanPham.Id_san_pham.ToString();

            if (sqlAll.Update_SanPham(sanPhamEdited))
            {
                qL_SanPham_Form.GetAllListOfSanPham();

                MessageBox.Show("Sửa thành công", "Thông báo cực căng!");


                this.Close();
            }
        }

        private void guna2Button_AddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif, *.jpg, *jpeg, *.bmp, *.png)| *.gif; *.jpg; *jpeg; *.bmp; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_UploadedPicture.ImageLocation = openFileDialog.FileName;
            }
        }
    }
}
