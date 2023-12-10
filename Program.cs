using LTUD1_MF_BHX.Screen;
using LTUD1_MF_BHX.ScreenMenu.HeThong.TaiKhoan;
using LTUD1_MF_BHX.ScreenMenu.Nhap;

namespace LTUD1_MF_BHX
{
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                //FormDangNhap logon = new FormDangNhap();
                FormMain logon = new FormMain();
                //FormHoaDon logon =  new FormHoaDon();
                //FormKhachHang logon = new FormKhachHang(); 
                //FormNhanVienAddEdit logon = new FormNhanVienAddEdit();
                Application.Run(logon);

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