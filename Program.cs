using LTUD1_MF_BHX.Model;
using LTUD1_MF_BHX.Screen;
using LTUD1_MF_BHX.ScreenDetail;
using LTUD1_MF_BHX.ScreenMenu.HeThong.TaiKhoan;
using LTUD1_MF_BHX.ScreenMenu.Nhap;
using LTUD1_MF_BHX.ScreenMenu.Nhap.ChiTietHoaDon;
using LTUD1_MF_BHX.ScreenMenu.Nhap.DanhMuc;
using LTUD1_MF_BHX.ScreenMenu.Nhap.DiaDiem;
using LTUD1_MF_BHX.ScreenMenu.Nhap.HoaDon;
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
                //FormDangNhap logon = new FormDangNhap();
                //FormMain logon = new FormMain();
                //FormHoaDon hoaDon =  new FormHoaDon();
                //FormKhachHang khachHang = new FormKhachHang(); 
                //FormNhanVienAddEdit d = new FormNhanVienAddEdit();
                Application.Run(new ChiTietHoaDonThongKe());
                

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