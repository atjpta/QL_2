using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using QL_2.forms;


namespace QL_2.AllClass
{
    class sql_SanPham
    {

        private SqlCon con = new SqlCon();
        private MySqlCommand cmd = new MySqlCommand();

        public sql_SanPham()
        {
            cmd.Connection = con.Connection();
        }

        public List<SanPham> GetAll_SanPham()
        {
            List<SanPham> sanPhams = new List<SanPham>();
            cmd.CommandText =
                "call Get_All_sp();";

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        SanPham sanPham = new SanPham
                        (
                            reader.GetInt32("id_sp"),
                            reader.GetInt32("id_nv"),
                            reader.GetString("malo"),
                            reader.GetString("tensp"),
                            reader.GetString("don_vi_tinh"),
                            reader.GetInt32("don_gia"),
                            reader.GetInt32("so_luong_ton_kho"),
                            reader.GetString("ho_ten_nv"),
                            (byte[])reader["img"]
                            );

                        sanPhams.Add(sanPham);
                    }
                }
                reader.Close();
                return sanPhams;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("lỗi lấy ds sản phẩm ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return null;

        }

        public int update_nv(NhanVien nv)
        {
            cmd.CommandText =
                "call update_nv(" +
                " '" + nv.ID_NV +
                "', '" + nv.Username +
                "', '" + nv.Name_nv +
                "', '" + nv.Sex +
                "', '" + nv.Date.ToString("yyyy/MM/dd") +
                "', '" + nv.Address +
                "', '" + nv.Sdt.ToString() +
                "', '" + nv.Chuc_vu + "')";

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                return 1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("lỗi update nhân viên ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }


        public SanPham Find_SanPham(int maSP)
        {
            SanPham SanPham;
            cmd.CommandText =
                "call Get_find_sp(" + maSP + ");";
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        SanPham = new SanPham
                        (
                            reader.GetInt32("id_sp"),
                            reader.GetInt32("id_nv"),
                            reader.GetString("malo"),
                            reader.GetString("tensp"),
                            reader.GetString("don_vi_tinh"),
                            reader.GetInt32("don_gia"),
                            reader.GetInt32("so_luong_ton_kho"),
                            reader.GetString("ho_ten_nv"),
                            (byte[])reader["img"]
                         );
                        reader.Close();
                        return SanPham;
                    }
                }
                reader.Close();
            }

            catch(MySqlException ex)
            {
                MessageBox.Show("lỗi tìn sản phẩm ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return null;
        }

        public bool Add_SanPham(SanPham sanPham)
        {
            if (Find_SanPham(sanPham.Id_san_pham) == null)
            {
                cmd.CommandText =
                   "insert into sanpham( `ID_NV`, `MALO`, `TENSP`, `DON_VI_TINH`,`don_gia`, `SO_LUONG_TON_KHO`, img) " +
                   "values('"
                   + sanPham.Id_nhan_vien + "', "
                   + "'" + sanPham.Malo + "', "
                   + "'" + sanPham.Ten_san_pham + "', "
                   + "'" + sanPham.Don_vi_tinh + "', "
                   + "'" + sanPham.DON_GIA + "', "
                   + "'" + sanPham.So_luong_ton_kho + "', "
                   + "@img)";

                cmd.Parameters.Add(new MySqlParameter("@img", sanPham.Img));
                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    return true;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo cực căng!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Bạn đã nhập trùng Mã Sản Phẩm", "Thông báo cực căng!");
                return false;
            }
        }

        public bool Update_SanPham(SanPham sanPham)
        {
            cmd.CommandText =
               "update sanpham "
               + "set "
               + "id_nv = " + sanPham.Id_nhan_vien + ", "
               + "malo = '" + sanPham.Malo + "', "
               + "tensp = '" + sanPham.Ten_san_pham + "', "
               + "don_vi_tinh = '" + sanPham.Don_vi_tinh + "', "
               + "don_gia = " + sanPham.DON_GIA + ", "
               + "so_luong_ton_kho = " + sanPham.So_luong_ton_kho + ", "
               + "img = @img "
               + "where id_sp = " + sanPham.Id_san_pham;

            cmd.Parameters.Add(new MySqlParameter("@img", sanPham.Img));

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                return true;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo cực căng!");

                return false;
            }

        }



    }
}
