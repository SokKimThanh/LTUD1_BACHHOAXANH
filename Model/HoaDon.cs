using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_MF_BHX.Model
{
    internal class HoaDon
    {
        string maHD, TTMH, TTHD, maNV, maKH, maSP, maKM;
        int diem;

        public HoaDon(string maHD, string tTMH, string tTHD, string maNV, string maKH, string maSP, string maKM, int diem)
        {
            this.maHD = maHD;
            TTMH = tTMH;
            TTHD = tTHD;
            this.maNV = maNV;
            this.maKH = maKH;
            this.maSP = maSP;
            this.maKM = maKM;
            this.diem = diem;   
        }
        public HoaDon() { }

        public string MaHD { get => maHD; set => maHD = value; }
        public string TTMH1 { get => TTMH; set => TTMH = value; }
        public string TTHD1 { get => TTHD; set => TTHD = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public string MaKM { get => maKM; set => maKM = value; }
        public int Diem { get => diem; set => diem = value; }
    }
}
