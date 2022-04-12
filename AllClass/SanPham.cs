using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QL_2.AllClass
{
    class SanPham
    {
        private int id_san_pham;
        private int id_nhan_vien;
        private string malo;
        private string ten_san_pham;
        private string don_vi_tinh;
        private int don_gia;
        private int so_luong_ton_kho;
        private byte[] img;
        private string name_nv;

        public SanPham()
        {
        }

        public SanPham(int id_nhan_vien, string malo, string ten_san_pham, string don_vi_tinh,int don_gia, int so_luong_ton_kho, byte[] img)
        {
            this.Id_nhan_vien = id_nhan_vien;
            this.Malo = malo;
            this.Ten_san_pham = ten_san_pham;
            this.Don_vi_tinh = don_vi_tinh;
            this.don_gia = don_gia;
            this.So_luong_ton_kho = so_luong_ton_kho;
            this.img = img;
        }

        public SanPham(int id_san_pham, int id_nhan_vien, string malo, string ten_san_pham, string don_vi_tinh, int don_gia, int so_luong_ton_kho, string name_nv, byte[] img)
        {
            this.Id_san_pham = id_san_pham;
            this.Id_nhan_vien = id_nhan_vien;
            this.Malo = malo;
            this.Ten_san_pham = ten_san_pham;
            this.Don_vi_tinh = don_vi_tinh;
            this.don_gia = don_gia;
            this.So_luong_ton_kho = so_luong_ton_kho;
            this.img = img;
            this.name_nv = name_nv;
        }


        public int Id_san_pham { get => id_san_pham; set => id_san_pham = value; }
        public int Id_nhan_vien { get => id_nhan_vien; set => id_nhan_vien = value; }
        public string Malo { get => malo; set => malo = value; }
        public string Ten_san_pham { get => ten_san_pham; set => ten_san_pham = value; }
        public string Don_vi_tinh { get => don_vi_tinh; set => don_vi_tinh = value; }
        public int So_luong_ton_kho { get => so_luong_ton_kho; set => so_luong_ton_kho = value; }

        public int DON_GIA { get => don_gia; set => don_gia = value; }
        public byte[] Img { get => img; set => img = value; }

        public string Name_nv { get => name_nv; set => name_nv = value; }


        public MemoryStream GetImgStream()
        {
            MemoryStream imgStream = new MemoryStream(img);
            return imgStream;
        }
    }
}