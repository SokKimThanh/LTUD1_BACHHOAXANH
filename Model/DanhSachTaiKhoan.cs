using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * tạo lớp danh sách admin với biến thành viên là Admin[] data, size, capacity, file_path. 
 * Kế tiếp có phương thức giao tiếp get và set. 
 * kế tiếp có phương thức khởi tạo danh sách rỗng và giá trị mặc định. 
 * Các hành vi của lớp này gồm: Them, Xoa, Sua, DocFile, GhiFile trả về kiểu bool.
 */
/*
 * Sok Kim Thanh
 * Date modified: 01/06/2023 7:41 CH
 */
namespace LTUD1_MF_BHX.Model
{
    public class DanhSachTaiKhoan
    {
        private TaiKhoanModel[] items;
        private int size;
        private int capacity;
        private string file_path = "Admin.txt";

        public DanhSachTaiKhoan()
        {
            capacity = 0;
            items = new TaiKhoanModel[0];
            size = 0;
        }

        public DanhSachTaiKhoan(int maxSize)
        {
            capacity = maxSize;
            items = new TaiKhoanModel[maxSize];
            size = 0;
        }

        internal TaiKhoanModel[] Items { get => items; set => items = value; }

        public int Size
        {
            get { return size; }

        }

        public int Capacity
        {
            get { return capacity; }

        }

        // Hàm Them thêm một phần tử vào cuối mảng Data
        public void Add(TaiKhoanModel item)
        {

            // Kiểm tra xem kích thước của mảng có đủ lớn để chứa thêm phần tử mới hay không
            if (size >= items.Length)
            {
                // Nếu không đủ, hãy tăng kích thước của mảng
                Array.Resize(ref items, Items.Length * 2);
            }
            // Thêm phần tử mới vào cuối mảng
            items[size] = item;
            size++;
        }

        // Hàm Them thêm một phần tử vào cuối mảng Data
        public bool ThemBool(TaiKhoanModel data)
        {
            bool isThem = false;// chua them duoc
            if (data == null)
            {
                return isThem;
            }
            // Kiểm tra xem kích thước của mảng có đủ lớn để chứa thêm phần tử mới hay không
            if (size >= items.Length)
            {
                // Nếu không đủ, hãy tăng kích thước của mảng
                Array.Resize(ref items, Items.Length * 2);
            }
            // Thêm phần tử mới vào cuối mảng
            items[size] = data;
            size++;
            isThem = true;
            return isThem;
        }
        // Hàm Xoa xóa phần tử đầu tiên trong mảng items
        public TaiKhoanModel Xoa()
        {
            TaiKhoanModel isXoa = null!;
            // Kiểm tra xem kích thước của mảng có lớn hơn 0 hay không
            if (size > 0)
            {

                // Duyệt qua các phần tử trong mảng từ đầu đến cuối
                for (int i = 0; i < size - 1; i++)
                {
                    // Di chuyển phần tử tại vị trí i + 1 sang vị trí i
                    items[i] = items[i + 1];
                    isXoa = items[i];
                }
                // Giảm kích thước của mảng đi 1
                size--;
                // Thay đổi kích thước của mảng items
                Array.Resize(ref items, size);
            }
            return isXoa;
        }

        public void XuatDS()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i].toString());
            }
        }
        private static TaiKhoanModel parseAdmin(string line)
        {
            string[] arr = line.Split('#');
            TaiKhoanModel item = new TaiKhoanModel();
            item.UserName = arr[0];
            item.Password = arr[1];
            return item;
        }
        public void DocFile()
        {
            using (StreamReader reader = new StreamReader(file_path))
            {
                string line;
                while ((line = reader.ReadLine()!) != null)
                {
                    TaiKhoanModel data = parseAdmin(line);
                    Add(data);
                }
            }
        }
        public void GhiFile()
        {
            using (StreamWriter writer = new StreamWriter(file_path))
            {
                // reset danh sach dang ky
                writer.WriteLine(items[0].InRaFile());
            }
        }
    }
}
