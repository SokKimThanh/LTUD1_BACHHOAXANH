using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LTUD1_MF_BHX.ScreenMenu.HeThong.TaiKhoan
{
    internal class TaiKhoan
    {
        private string tentk, matkhau, matk;
        private DateTime createdate;
        private string phone;
        private string cccd;
        private string email;

        public TaiKhoan(string? tentk = null, string? matkhau = null, string? matk = null, DateTime createdate = default, string? phone = null, string? cccd = null, string? email = null)
        {
            this.tentk = tentk!;
            this.matkhau = matkhau!;
            this.matk = matk!;
            this.createdate = createdate;
            this.phone = phone!;
            this.cccd = cccd!;
            this.email = email!;
        }

        public string TenTaiKhoan { get => tentk; set => tentk = value; }
        public string MatKhau { get => matkhau; set => matkhau = value; }
        public string MaTaiKhoan { get => matk; set => matk = value; }
        public DateTime Createdate { get => createdate; set => createdate = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string Email { get => email; set => email = value; }


        public string InRaFile()
        {
            return $"{TenTaiKhoan}#{MatKhau}";
        }
        public string toString()
        {
            return $"tentk: {TenTaiKhoan} matkhau: {MatKhau}";
        }
    }
}
