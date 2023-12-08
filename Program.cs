using LTUD1_MF_BHX.Screen;

using LTUD1_MF_BHX.ScreenMenu.HeThong;
using LTUD1_MF_BHX.ScreenMenu.Nhap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                /*FormSanPham logon = new FormSanPham();
                Application.Run(logon);
*/
                //FormDangNhap logon = new FormDangNhap();
                //FormMain logon = new FormMain();
                //FormHoaDon hoaDon =  new FormHoaDon();
                //FormKhachHang khachHang = new FormKhachHang(); 

                Application.Run(new FormKhuyenMai());

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