using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_MF_BHX.Model
{
    internal class Khachhang
    {
        string ma, ten;
        int sdt, diem;

        public Khachhang(string ma, string ten, int std, int diem)
        {
            this.ma = ma;
            this.ten = ten;
            this.sdt = std;
            this.diem = diem;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Std { get => sdt; set => sdt = value; }
        public int Diem { get => diem; set => diem = value; }
    }
}
