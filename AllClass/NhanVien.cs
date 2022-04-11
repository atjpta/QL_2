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
        private string sdt;
        private string chuc_vu;


        public NhanVien(int iD_nv, string username, string name_nv, string sex, DateTime date, string address, string sdt, string chuc_vu)
        {
            this.ID_nv = iD_nv;
            this.username = username;
            this.name_nv = name_nv;
            this.sex = sex;
            this.date = date;
            this.address = address;
            this.sdt = sdt;
            this.chuc_vu = chuc_vu;
        }

        public NhanVien(string username, string name_nv, string sex, DateTime date, string address, string sdt, string chuc_vu)
        {
            this.username = username;
            this.name_nv = name_nv;
            this.sex = sex;
            this.date = date;
            this.address = address;
            this.sdt = sdt;
            this.chuc_vu = chuc_vu;
        }                               


        public int ID_NV { get => ID_nv; set => ID_nv = value; }
        public string Username { get => username; set => username = value; }
        public string Name_nv { get => name_nv; set => name_nv = value; }
        public string Sex { get => sex; set => sex = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Address { get => address; set => address = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Chuc_vu { get => chuc_vu; set => chuc_vu = value; }
    }
}
