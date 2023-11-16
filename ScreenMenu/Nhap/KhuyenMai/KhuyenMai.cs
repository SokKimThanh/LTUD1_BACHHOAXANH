using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_MF_BHX
{
    internal class KhuyenMai
    {
        string makm;
        DateTime ngaybd;
        DateTime ngaykt;
        string masp;

        public KhuyenMai()
        {

        }
        public KhuyenMai(string makm, DateTime ngaybd, DateTime ngaykt, string masp)
        {
            this.makm = makm;
            this.ngaybd = ngaybd;
            this.ngaykt = ngaykt;
            this.masp = masp;
        }

        public string Makm { get => makm; set => makm = value; }
        public DateTime Ngaybd { get => ngaybd; set => ngaybd = value; }
        public DateTime Ngaykt { get => ngaykt; set => ngaykt = value; }
        public string Masp { get => masp; set => masp = value; }

        public override string ToString()
        {
            return  $"{makm,-15}{Ngaybd.ToString("dd/MM/yyyy"),-10}{Ngaykt.ToString("dd/MM/yyyy"),-10}{Masp,-15}";
        }
    }
}
