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
    class Sql_NhanVien
    {
        private SqlAll sqlAll = new SqlAll();
        private MySqlCommand cmd = new MySqlCommand();

        public List<NhanVien> GetAll_Nhanvien()
        {
            List<NhanVien> ds_nv = new List<NhanVien>();
            cmd.Connection = sqlAll.Connection();
            cmd.CommandText =
                "call Get_All_nv();";
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        ds_nv.Add(new NhanVien
                        (
                            reader.GetInt32("ID_NV"),
                            reader.GetString("username"),
                            reader.GetString("Ho_ten_nv"),
                            reader.GetString("gioi_tinh"),
                            reader.GetDateTime("ngay_sinh"),
                            reader.GetString("dia_chi"),
                            reader.GetString("SDT"),
                            reader.GetString("chuc_vu")
                         ));
                        i++;
                    }
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("lỗi lấy ds nv ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return ds_nv;
        }

        public int update_nv(NhanVien nv)
        {
            cmd.Connection = sqlAll.Connection();
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


        public NhanVien find_username(string username)
        {
            cmd.Connection = sqlAll.Connection();
            cmd.CommandText =
                "call Get_nv('" + username + "');";
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        NhanVien nv = new NhanVien
                        (
                            reader.GetInt32("ID_NV"),
                            reader.GetString("username"),
                            reader.GetString("Ho_ten_nv"),
                            reader.GetString("gioi_tinh"),
                            reader.GetDateTime("ngay_sinh"),
                            reader.GetString("dia_chi"),
                            reader.GetString("SDT"),
                            reader.GetString("chuc_vu")
                         );
                        i++;
                        return nv;
                    }

                }
                
                reader.Close();
                
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("lỗi tìm username của nhân viên ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return null;
        }

        public int add_nv(NhanVien nv)
        {
            if(find_username(nv.Username) != null)
            {
                MessageBox.Show( nv.Username + " đã có người sử dụng", "Thông báo cực căng!!!");
                return 0;
            }

            cmd.Connection = sqlAll.Connection();
            cmd.CommandText =
                "call add_nv(" +
                " '" + nv.Username +
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
                MessageBox.Show("lỗi add nhân viên ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        
       

        
    }
}
