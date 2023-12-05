

namespace LTUD1_MF_BHX
{
    public class NhanVien
    {
        // private string manv char (11),
        //private string hotennv nvarchar(30),
        //private string diachinv nvarchar(100),
        //private float luong float,
        //private int sdtnv int,
        //private DateTime ngaysinh date,
        //   private char mapb char (4),
        //private char quanly char (11)

        private string manv;
        private string hotennv;
        private string diachinv;
        private float luong;
        private int sdtnv;
        private DateTime ngaysinh;
        private string mapb;
        private string quanly;

        public NhanVien()
        {
            this.manv = "";
            this.hotennv = "";
            this.diachinv = "";
            this.luong = 0;
            this.sdtnv = 0;
            this.ngaysinh = new DateTime();
            this.mapb = "";
            this.quanly = "";
        }

        public NhanVien(string manv, string hotennv, string diachinv, float luong, int sdtnv, DateTime ngaysinh, string mapb, string quanly)
        {
            this.manv = manv;
            this.hotennv = hotennv;
            this.diachinv = diachinv;
            this.luong = luong;
            this.sdtnv = sdtnv;
            this.ngaysinh = ngaysinh;
            this.mapb = mapb;
            this.quanly = quanly;
        }

        public string Manv { get => manv; set => manv = value; }
        public string Hotennv { get => hotennv; set => hotennv = value; }
        public string Diachinv { get => diachinv; set => diachinv = value; }
        public float Luong { get => luong; set => luong = value; }
        public int Sdtnv { get => sdtnv; set => sdtnv = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Mapb { get => mapb; set => mapb = value; }
        public string Quanly { get => quanly; set => quanly = value; }

        public void Nhap()
        {
            this.Manv = "dfasdf";
            this.Hotennv = "sok kim thanh";
            this.Diachinv = "diachi001";
            this.Luong = 123123;
            this.Sdtnv = 123123123;
            this.ngaysinh = DateTime.Parse("2023/2/2");
            this.mapb = "pb3123";
            this.Quanly = "ql0123123";
        }
        public string Xuat()
        {
            return $"{this.manv}#{this.hotennv}#{this.diachinv}#{this.luong}#{this.manv}#";
        }
    }
}
