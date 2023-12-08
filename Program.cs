using LTUD1_MF_BHX.Screen;
using LTUD1_MF_BHX.ScreenMenu.HeThong.TaiKhoan;
using LTUD1_MF_BHX.ScreenMenu.Nhap;
using LTUD1_MF_BHX.ScreenMenu.Nhap.PhongBan;

namespace LTUD1_MF_BHX
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                FormDiaDiem formDiaDiem = new FormDiaDiem();
                //FormDangNhap logon = new FormDangNhap();
                FormMain logon = new FormMain();
                FormHoaDon hoaDon =  new FormHoaDon();
                FormKhachHang khachHang = new FormKhachHang(); 
                FormPhongBan formPhongBan = new FormPhongBan();
                //FormMain logon = new FormMain();
                //FormHoaDon hoaDon =  new FormHoaDon();
                //FormKhachHang khachHang = new FormKhachHang(); 

                Application.Run(new FormNhanVienAddEdit());

                //Trần Minh Tuấn

                //gi change
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}