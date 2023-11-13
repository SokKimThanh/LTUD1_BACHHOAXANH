using LTUD1_MF_BHX.Screen;

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
                FormDangNhap logon = new FormDangNhap();
                //FormNhaCungCap logon = new FormNhaCungCap();

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
        }
    }
}