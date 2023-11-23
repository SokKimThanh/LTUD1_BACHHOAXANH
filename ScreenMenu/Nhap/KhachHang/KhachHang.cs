using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_MF_BHX.Model
{
    internal class KhachHang1
    {
        private string ma, ten;
        private int sdt, diem;

        public KhachHang1(string ma, string ten, int sdt, int diem)
        {
            this.ma = ma;
            this.Ten = ten;
            this.Sdt = sdt;
            this.Diem = diem;
        }
        public KhachHang1()
        {
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        public int Diem { get => diem; set => diem = value; }
    }
}
