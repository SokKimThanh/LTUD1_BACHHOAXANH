 

namespace LTUD1_MF_BHX
{
    internal class DanhSachSanPham
    {
        List<SanPham> list;

        public DanhSachSanPham()
        {
            list = new List<SanPham>();
        }

        public void Add(SanPham a)
        {
            list.Add(a);
        }
    }
}
