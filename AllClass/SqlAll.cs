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
        private MySqlDataAdapter adt; // dùng để chuyển đổi 

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


            try
            {
                con = new MySqlConnection(constr);
                con.Open();
                Console.WriteLine("ket noi thanh cong!!!!!!!");

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
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
                    Console.WriteLine(reader.GetString("username"));
                    Console.WriteLine(reader.GetString("password"));
                    Console.WriteLine(reader.GetInt32("maltk"));
                    return taiKhoan;
                }
            }

            reader.Close();
            return null;

        }

        //lấy bảng lo từ DB
        public List<Lo> GetALL_Lo()
        {
            cmd.Connection = con;
            cmd.CommandText =
                "select * " +
                "from lo";
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Lo> los = new List<Lo>();

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
    }
}
