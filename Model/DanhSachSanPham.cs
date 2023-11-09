using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_MF_BHX.model
{
    internal class DanhSachSanPham
    {
        List<SanPham> list;

        public DanhSachSanPham()
        {
            this.list = new List<SanPham>();
        }

        public void Add(SanPham a)
        {
            list.Add(a);
        }
    }
}
