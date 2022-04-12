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
    class Sql_lo
    {
        private SqlCon con = new SqlCon();
        private MySqlCommand cmd = new MySqlCommand();

        public Sql_lo()
        {
            cmd.Connection = con.Connection();
        }

        public List<Lo> GetALL_Lo()
        {
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
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql connetion ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return los;
        }

        // xóa 1 lo dựa vào mã lo
        public void Delete_Lo(String maLo)
        {
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
                    MessageBox.Show(ex.Message, "Thông báo cực căng!!!");
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
            Lo lo;
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
