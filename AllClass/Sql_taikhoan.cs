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
    class Sql_taikhoan
    {
        private SqlCon sqlAll = new SqlCon();
        private MySqlCommand cmd = new MySqlCommand();

        public int login(string username, string pwd)
        {
            cmd.Connection = sqlAll.Connection();
            cmd.CommandText =
                "call login('" + username + "', '" + pwd + "');";
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return (int) reader.GetInt16("id_nv");
                    }
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("lỗi login ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return 0;
        }
    }
}
