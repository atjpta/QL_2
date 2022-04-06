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
    class SqlAll
    {
        private string constr; // lưu toan bộ thông tin để kết nối DB
        private MySqlConnection con; // dùng để kết nối 
        private MySqlCommand cmd = new MySqlCommand(); // lưu các lệnh của sql

        private string server = "localhost";
        private string user = "root";
        private string pwd = "";
        private string database = "QLCHDL";
        private int port = 3306;


        // kết nối vào DB
        public SqlAll()
        {
            constr = "server=" + server +
                    ";user=" + user +
                    ";pwd=" + pwd +
                    ";database=" + database +
                    ";port=" + port +
                    ";";

            con = new MySqlConnection(constr);

            try
            {
                con.Open();
                Console.WriteLine("ket noi thanh cong!!!!!!!");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql connetion ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // lấy tài khoản dựa vào UserName
        public TaiKhoan GetTaikhoan(String UserName)
        {
            cmd.Connection = con;
            cmd.CommandText =
                "select * " +
                "from taikhoan " +
                "where username = '" + UserName + "'";
            MySqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TaiKhoan taiKhoan = new TaiKhoan
                        (
                            reader.GetString("username"),
                            reader.GetString("password"),
                            reader.GetInt32("maltk")
                        );
                    return taiKhoan;
                }
            }

            reader.Close();
            return null;

        }

        internal bool Update_Lo(Lo lo)
        {
            throw new NotImplementedException();
        }

        //lấy bảng lo từ DB
        public List<Lo> GetALL_Lo()
        {
            cmd.Connection = con;
            cmd.CommandText =
                "select * " +
                "from lo";
            List<Lo> los = new List<Lo>();
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        los.Add(new Lo
                        (
                            reader.GetString("malo"),
                            reader.GetDateTime("ngay_nhap"),
                            reader.GetDateTime("han_su_dung")
                         ));
                        i++;
                    }
                }
                reader.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("MySql connetion ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return los;
        }

        // xóa 1 lo dựa vào mã lo
        public void Delete_Lo(String maLo)
        {
            cmd.Connection = con;
            cmd.CommandText =
                "delete " +
                "from lo " +
                "where malo = '" + maLo + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
        }


        //thêm lô
        public bool Add_Lo(Lo lo)
        {
            if (Find_Lo(lo.Malo) == null)
            {
                cmd.Connection = con;
                cmd.CommandText =
                   "insert into lo(malo, ngay_nhap, han_su_dung) " +
                   "values('" + lo.Malo + "', '" + lo.Nsx.ToString("yyyy/MM/dd") + "', '" + lo.Hsd.ToString("yyyy/MM/dd") + "')";
                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    return true;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message , "Thông báo cực căng!!!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Bạn đã nhập trùng Mã lô", "Thông báo cực căng!!!");
                return false;
            }

            
        }

        //tìm xem da có lô chưa
        public Lo Find_Lo(String maLo)
        {
            Lo lo ;
            cmd.Connection = con;
            cmd.CommandText =
                "select *" +
                "from lo " +
                "where malo = '" + maLo + "'";
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                int i = 0;
                while (reader.Read())
                {
                    
                    lo = new Lo
                    (
                        reader.GetString("malo"),
                        reader.GetDateTime("ngay_nhap"),
                        reader.GetDateTime("han_su_dung")
                     );
                    i++;
                    return lo;
                }
            }
            reader.Close();
            return null;
        }


        public bool Update_Lo_db(Lo lo)
        {
            cmd.Connection = con;
            cmd.CommandText =
                "update lo " +
                "set    ngay_nhap = '" + lo.Nsx.ToString("yyyy/MM/dd") + "', " +
                "       han_su_dung = '" + lo.Hsd.ToString("yyyy/MM/dd") + "' " +
                "where malo = '" + lo.Malo + "' ";
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                return true;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo cực căng của sửa Lô!!! ");
                return false;
            }
        }
    }
}
