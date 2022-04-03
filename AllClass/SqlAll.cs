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

        public TaiKhoan GetTaikhoan(String UserName)
        {
            cmd.Connection = con;
            cmd.CommandText = 
                "select *" +
                "from taikhoan " +
                "where" + UserName;
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
    }
}
