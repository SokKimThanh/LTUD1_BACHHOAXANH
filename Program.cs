using LTUD1_MF_BHX.Screen;
using LTUD1_MF_BHX.ScreenMenu.HeThong.TaiKhoan;

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
                FormTaiKhoan logon = new FormTaiKhoan();

                Application.Run(logon);

                //Trần Minh Tuấn

                //gi change
            }
            catch (Exception)
            {
                throw;
            }
            //jdhjhhjhj
            //sbdjsbjbs
		// ngo quy
        }
    }
}