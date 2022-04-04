using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QL_2.AllClass
{
    class TaiKhoan
    {
        private string username;
        private string pwd;
        private int maTK;
        private string hash;

        public TaiKhoan(String username, String pwd, int maTK)
        {
            this.username = username;
            this.pwd = pwd;
            this.maTK = maTK;
        }
        public TaiKhoan(String username, String pwd)
        {
            this.username = username;

            string source = pwd;
            using (SHA512 sha512Hash = SHA512.Create())
            {
                //From String to byte array
                byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
                byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
                hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
            }
            this.pwd = hash;
        }

        public string GetPwd()
        {
            return this.pwd;
        }

        public int GetMatk()
        {
            return this.maTK;
        }

        public int Login()
        {
            SqlAll sql = new SqlAll();
            TaiKhoan temp = sql.GetTaikhoan(this.username);
            if(temp == null)
            {
                return 0;
            }
            if (temp.GetPwd().ToUpper() == this.GetPwd().ToUpper())
            {
                return temp.GetMatk();
            }
            else return 0;
        }
    }
}
