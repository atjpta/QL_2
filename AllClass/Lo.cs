using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_2.AllClass
{
    class Lo
    {
        private string maLo;
        private DateTime nsx;
        private DateTime hsd;

        public Lo(string maLo, DateTime nsx, DateTime hsd)
        {
            this.maLo = maLo;
            this.nsx = nsx;
            this.hsd = hsd;
        }

        public string Malo
        {
            get { return maLo; }
            set { maLo = value; }
        }

        public DateTime Nsx
        {
            get { return nsx; }
            set { nsx = value; }
        }

        public DateTime Hsd
        {
            get { return hsd; }
            set { nsx = value; }
        }


    }
}
