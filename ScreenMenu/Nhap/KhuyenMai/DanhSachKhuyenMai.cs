using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_MF_BHX
{
    internal class ListKhuyenMai
    {
        ArrayList<KhuyenMai> dsKhuyenMai;
        int size;


        public ListKhuyenMai()
        {
            this.dsKhuyenMai = new ArrayList<KhuyenMai>(0);
        }

       

        public int Count { get => size; set => size = value; }
        internal ArrayList<KhuyenMai> DsKhuyenMai { get => dsKhuyenMai; set => dsKhuyenMai = value; }

        public void ThemKhuyenMai(KhuyenMai item)
        {
            dsKhuyenMai.AddLast(item);
            size++;
        }

        // Hàm Them thêm một phần tử vào cuối mảng dsKhuyenMai
        public bool ThemKhuyenMaiBool(KhuyenMai item)
        {
            size++;
            return dsKhuyenMai.AddLastBool(item);
        }
        // Hàm Xoa xóa phần tử đầu tiên trong mảng items
        public bool XoaKhuyenMai(KhuyenMai item)
        {
            size--;
            return dsKhuyenMai.Remove(item);
        }

        public void XuatDS()
        {
            try
            {
                if (Count == 0)
                {
                    ThongBao.p_alert_writeline("--Danh sach rong--".ToUpper());
                    return;
                }

                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < dsKhuyenMai.Count; i++)
                {
                    Console.WriteLine(dsKhuyenMai[i].ToString());
                }
            }
            catch (NullReferenceException ex)
            {
                ThongBao.p_alert_writeline(ex.Message);
            }
        }


        // tìm kiếm hàng hóa theo ma
        public KhuyenMai SearchByMakm(string Makm)
        {
            try
            {
                for (int i = 0; i < dsKhuyenMai.Count; i++)
                {
                    if (dsKhuyenMai[i].Makm.ToLower().CompareTo(Makm.ToLower()) == 0)
                    {
                        return dsKhuyenMai[i];
                    }
                }
            }
            catch (Exception ex)
            {
                ThongBao.p_alert_writeline(ex.Message);
            }
            return null!;
        }
        // tìm kiếm hàng hóa theo tên
        public KhuyenMai SearchByMasp(string Masp)
        {
            try
            {
                for (int i = 0; i < dsKhuyenMai.Count; i++)
                {
                    if (dsKhuyenMai[i].Makm.ToLower().CompareTo(Masp.ToLower()) == 0)
                    {
                        return dsKhuyenMai[i];
                    }
                }
            }
            catch (Exception ex)
            {
                ThongBao.p_alert_writeline(ex.Message);
            }
            return null!;
        }

        private static KhuyenMai parseLine(string line)
        {
            string[] arr = line.Split('#');
            KhuyenMai item = new KhuyenMai();
            item.Makm = arr[0];
            item.Masp = arr[1];
            item.Ngaybd = DateTime.Parse(arr[2]);
            item.Ngaykt = DateTime.Parse(arr[2]);
            
            return item;
        }
        public void DocFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()!) != null)
                {
                    KhuyenMai item = parseLine(line);
                    ThemKhuyenMai(item);
                }
            }
        }
        public void GhiFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < dsKhuyenMai.Count; i++)
                {
                    writer.WriteLine(dsKhuyenMai[i].ToString());
                }
            }
        }
    }
}
