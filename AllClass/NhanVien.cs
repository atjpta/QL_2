using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_2.AllClass
{
    class NhanVien
    {
        private int ID_nv;
        private string username;
        private string name_nv;
        private string sex;
        private DateTime date;
        private string address;
        private int sdt;

        public NhanVien(int iD_nv, string username, string name_nv, string sex, DateTime date, string address, int sdt)
        {
            ID_nv = iD_nv;
            this.username = username;
            this.name_nv = name_nv;
            this.sex = sex;
            this.date = date;
            this.address = address;
            this.sdt = sdt;
        }


        public int ID_nv1 { get => ID_nv; set => ID_nv = value; }
        public string Username { get => username; set => username = value; }
        public string Name_nv { get => name_nv; set => name_nv = value; }
        public string Sex { get => sex; set => sex = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Address { get => address; set => address = value; }
        public int Sdt { get => sdt; set => sdt = value; }
    }
}
