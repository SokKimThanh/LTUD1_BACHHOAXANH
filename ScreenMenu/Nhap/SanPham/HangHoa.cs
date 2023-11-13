using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/**
 * Sok Kim Thanh
 * Date: 31/05/2023 9:55 CH
 * Hang hoa tren website co thong tin hang hoa chi tiet
 */
namespace LTUD1_MF_BHX 
{
    /// <summary>
    /// Thong tin chi tiet cua hang hoa tren website
    /// </summary>
    public class HangHoa
    {
        private string _MaHang; // toi da 4 ky tu khong trung
        private string _TenHang;
        private string _NoiSanXuat;
        private string _MauSac;
        private double _GiaBan;
        private DateTime _NgayNhapKho;
        private int _SoLuongNhapKho;// so sanh so luong nhap kho voi so luong mua hang hoa

        public HangHoa(string maHang)
        {
            _MaHang = maHang;
            _TenHang = "";
            _NoiSanXuat = "";
            _MauSac = "";
            _GiaBan = 0.0;
            _NgayNhapKho = new DateTime();
            _SoLuongNhapKho = 0;
        }
        public HangHoa()
        {
            _MaHang = "";
            _TenHang = "";
            _NoiSanXuat = "";
            _MauSac = "";
            _GiaBan = 0.0;
            _NgayNhapKho = new DateTime();
            _SoLuongNhapKho = 0;
        }
        public HangHoa(string maHang, string tenHang, string noiSanXuat, string mauSac, double giaBan, DateTime ngayNhapKho, int soLuongNhapKho)
        {
            _MaHang = maHang;
            _TenHang = tenHang;
            _NoiSanXuat = noiSanXuat;
            _MauSac = mauSac;
            _GiaBan = giaBan;
            _NgayNhapKho = ngayNhapKho;
            _SoLuongNhapKho = soLuongNhapKho;
        }

        public string MaHang
        {
            get => _MaHang;
            set
            {
                if (value.Length > 4)
                {
                    return;
                }
                else
                {
                    _MaHang = value;
                }
            }
        }
        public string TenHang { get => _TenHang; set => _TenHang = value; }
        public string NoiSanXuat { get => _NoiSanXuat; set => _NoiSanXuat = value; }
        public string MauSac { get => _MauSac; set => _MauSac = value; }
        public double GiaBan { get => _GiaBan; set => _GiaBan = value; }
        public DateTime NgayNhapKho { get => _NgayNhapKho; set => _NgayNhapKho = value; }
        public int SoLuongNhapKho { get => _SoLuongNhapKho; set => _SoLuongNhapKho = value; }


        public void NhapTuDong()
        {
            Random d = new Random();
            MaHang = "" + d.Next(100, 9999).ToString();
            TenHang = "tenHang" + d.Next(100, 999).ToString();
            NoiSanXuat = "noiSanXuat" + d.Next(100, 999).ToString();
            MauSac = "MauSac" + d.Next(100, 999).ToString();
            GiaBan = d.Next(10000, 999999) * d.NextDouble();
            SoLuongNhapKho = d.Next(100, 999);
            /* lưu ý rằng không phải tất cả các tháng đều có 31 ngày và 
             * tháng 2 có thể có 28 hoặc 29 ngày tùy thuộc vào năm. 
             * 
             * Điều này có thể dẫn đến một ngoại lệ ArgumentOutOfRangeException
             * khi khởi tạo đối tượng DateTime với một ngày không hợp lệ
             * 
             * cho tháng đã chọn.*/
            // Random ngay
            try
            {
                int nam = d.Next(1900, 2031);//1900-2030
                int thang = d.Next(1, 13);// 1-12 
                int soNgayTrongThang = DateTime.DaysInMonth(nam, thang);// tính số ngày trong tháng trước khi random
                int ngay = d.Next(1, soNgayTrongThang + 1);
                NgayNhapKho = new DateTime(nam, thang, ngay);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            Thread.Sleep(10);
        }

        /// <summary>
        ///  In ra file 
        /// </summary>
        /// <returns></returns>
        public string InRaFile()
        {
            return $"{MaHang}#{TenHang}#{NoiSanXuat}#{MauSac}#{GiaBan}#{NgayNhapKho.ToString("dd/MM/yyyy")}#{SoLuongNhapKho}";
        }

        /// <summary>
        /// Ghi đè để phương thức array list có thể truy cập được định nghĩa mới của ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{MaHang,-15}{TenHang,-15}{NoiSanXuat,-15}{MauSac,-15}{GiaBan.ToString("C"),-15}{NgayNhapKho.ToString("dd/MM/yyyy"),-15}{SoLuongNhapKho,-15}";
        }

        internal void NhapTay()
        {
            // nhap ma hang hoa 

            ThongBao.p_success_write("Nhap ma hang: ");
            MaHang = Console.ReadLine()!;

            ThongBao.p_success_write("Nhap ten hang: ");
            TenHang = Console.ReadLine()!;

            ThongBao.p_success_write("Nhap noiSanXuat: ");
            NoiSanXuat = "noiSanXuat" + Console.ReadLine()!;

            ThongBao.p_success_write("Nhap MauSac: ");
            MauSac = "MauSac" + Console.ReadLine()!;

            ThongBao.p_success_write("Nhap gia ban: ");
            GiaBan = double.Parse(Console.ReadLine()!);

            ThongBao.p_success_write("Nhap ton kho: ");
            SoLuongNhapKho = int.Parse(Console.ReadLine()!);

            // nhap ngay nhap kho, ngay/ thang/ nam
            ThongBao.p_alert_writeline("Ngay nhap kho: ");
            ThongBao.p_success_write("Nhap ngay nhap kho: ");
            int ngay = int.Parse(Console.ReadLine()!);
            ThongBao.p_success_write("Nhap thang nhap kho: ");
            int thang = int.Parse(Console.ReadLine()!);// 1-12 
            ThongBao.p_success_write("Nhap nam nhap kho: ");
            int nam = int.Parse(Console.ReadLine()!);//1900-2030
            NgayNhapKho = new DateTime(nam, thang, ngay);
        }

        public int CompareToMaHang(HangHoa other)
        {
            return MaHang.ToLower().CompareTo(other.MaHang.ToLower());
        }

        public int CompareToGiaBan(HangHoa other)
        {
            return GiaBan.CompareTo(other.GiaBan);
        }
    }
}
