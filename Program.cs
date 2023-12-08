using LTUD1_MF_BHX.Screen;
using LTUD1_MF_BHX.ScreenDetail;
using LTUD1_MF_BHX.ScreenMenu.HeThong.TaiKhoan;
using LTUD1_MF_BHX.ScreenMenu.Nhap;

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
                //FormDangNhap logon = new FormDangNhap();
                //FormMain logon = new FormMain();
                //FormHoaDon hoaDon =  new FormHoaDon();
                //FormKhachHang khachHang = new FormKhachHang(); 
                FormNhanVienAddEdit d = new FormNhanVienAddEdit();
                Application.Run(new FormSanPham());
                Application.Run(new FormChiTietHoaDon());

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