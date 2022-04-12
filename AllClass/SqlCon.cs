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
    class SqlCon
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
        public SqlCon()
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


        public MySqlConnection Connection()
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

            return con;
        }
        
      
    }
}