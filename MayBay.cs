using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Nhom7
{
    class MayBay
    {
        public MayBay(string soHieu, int soCho)
        {
            this.soHieu = soHieu;
            this.soCho = soCho;
        }
        public override string ToString()
        {
            return soHieu + " " + soCho.ToString();
        }

        public String soHieu { get; set; }
        public int soCho { get; set; }
    }
}
