using LTUD1_MF_BHX.Connection;
using System.Data;
using System.Data.SqlClient;

namespace LTUD1_MF_BHX
{
    public class NhanVienController : MyController
    {
        public NhanVienController(string connectionString) : base(connectionString)
        {
        }

        public override void Delete(object id)
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_nhanvien_delete", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@manv", id);

                // Thực thi SqlCommand
                if (Sql.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("Xóa thành công");
                }

                // Đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public override object FromDataRow(DataRow row)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien.Manv = row.Field<string>("manv")!;
            nhanvien.Hotennv = row.Field<string>("hotennv")!;
            nhanvien.Diachinv = row.Field<string>("diachinv")!;
            int luong = row.Field<int>("luong")!;
            nhanvien.Luong = luong;
            nhanvien.Mapb = row.Field<string>("mapb")!;
            nhanvien.Ngaysinh = row.Field<DateTime>("ngaysinh")!;
            nhanvien.Sdtnv = row.Field<int>("sdtnv")!;
            nhanvien.Gioitinh = row.Field<string>("gioitinh")!;
            return nhanvien;
        }

        public override void Insert(object sender)
        {
            try
            {
                NhanVien o = (NhanVien)sender;
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_nhanvien_insert", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@manv", o.Manv);
                Sql.Parameters.AddWithValue("@hotennv", o.Hotennv);
                Sql.Parameters.AddWithValue("@sdtnv", o.Sdtnv);
                Sql.Parameters.AddWithValue("@luong", o.Luong);
                Sql.Parameters.AddWithValue("@diachinv", o.Diachinv);
                Sql.Parameters.AddWithValue("@ngaysinh", o.Ngaysinh);
                Sql.Parameters.AddWithValue("@mapb", o.Mapb);
                Sql.Parameters.AddWithValue("@gioitinh", o.Gioitinh);
                // Thực thi SqlCommand
                if (Sql.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công");
                }

                // Đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("Insert" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public DataTable ThongKeNhanVien()
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_nhanvien_thongke", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Tạo một đối tượng SqlDataAdapter
                Adapter = new SqlDataAdapter(Sql);

                // Tạo một đối tượng DataTable để lưu trữ dữ liệu
                DataSource = new DataTable();

                // Đổ dữ liệu vào DataTable
                Adapter.Fill(DataSource);

                // Đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("ThongKeNhanVien" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return DataSource;
        }
        public DataTable DanhSachNhanVienTheoChiNhanhPhongBan()
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_nhanvien_danhsach_theophongban_chinhanh", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Tạo một đối tượng SqlDataAdapter
                Adapter = new SqlDataAdapter(Sql);

                // Tạo một đối tượng DataTable để lưu trữ dữ liệu
                DataSource = new DataTable();

                // Đổ dữ liệu vào DataTable
                Adapter.Fill(DataSource);

                // Đóng kết nố
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("DanhSachNhanVienTheoChiNhanhPhongBan" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return DataSource;
        }
        public override void SelectAll()
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_nhanvien_select_all", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Tạo một đối tượng SqlDataAdapter
                Adapter = new SqlDataAdapter(Sql);

                // Tạo một đối tượng DataTable để lưu trữ dữ liệu
                DataSource = new DataTable();

                // Đổ dữ liệu vào DataTable
                Adapter.Fill(DataSource);

                // Đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("SelectAll" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public override DataTable SelectByID(object id)
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_nhanvien_select_one", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                string idnv = (string)id;
                idnv = idnv.ToString().Trim();
                Sql.Parameters.AddWithValue("@manv", idnv);

                // Tạo một đối tượng SqlDataAdapter
                Adapter = new SqlDataAdapter(Sql);

                // Tạo một đối tượng DataTable để lưu trữ dữ liệu
                DataSource = new DataTable();

                // Đổ dữ liệu vào DataTable
                Adapter.Fill(DataSource);

                // Đóng kết nối
                CloseConnection();

                // Trả về DataTable
                return DataSource;
            }
            catch (Exception ex)
            {
                throw new Exception("SelectByID" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public override void Update(object sender)
        {
            try
            {
                NhanVien o = (NhanVien)sender;
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_nhanvien_update", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@manv", o.Manv);
                Sql.Parameters.AddWithValue("@hotennv", o.Hotennv);
                Sql.Parameters.AddWithValue("@sdtnv", o.Sdtnv);
                Sql.Parameters.AddWithValue("@luong", o.Luong);
                Sql.Parameters.AddWithValue("@diachinv", o.Diachinv);
                Sql.Parameters.AddWithValue("@ngaysinh", o.Ngaysinh);
                Sql.Parameters.AddWithValue("@mapb", o.Mapb);
                Sql.Parameters.AddWithValue("@gioitinh", o.Gioitinh);
                // Thực thi SqlCommand
                if (Sql.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                }

                // Đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("Update" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public DataTable DanhSachQuanLy()
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_cbo_quanly_theo_phongban", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Tạo một đối tượng SqlDataAdapter
                Adapter = new SqlDataAdapter(Sql);

                // Tạo một đối tượng DataTable để lưu trữ dữ liệu
                DataSource = new DataTable();

                // Đổ dữ liệu vào DataTable
                Adapter.Fill(DataSource);

                // Đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("DanhSachQuanLy" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return DataSource;
        }
        public DataTable GetDanhSachPhongBan()
        {

            DataTable dt;

            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_cbo_phongban", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Tạo một đối tượng SqlDataAdapter
                Adapter = new SqlDataAdapter(Sql);

                // Tạo một đối tượng DataTable để lưu trữ dữ liệu
                dt = new DataTable();

                // Đổ dữ liệu vào DataTable
                Adapter.Fill(dt);

                // Đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("GetDanhSachPhongBan" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }

        public DataTable GetDanhSachNhanVien()
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_nhanvien_select_all", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Tạo một đối tượng SqlDataAdapter
                Adapter = new SqlDataAdapter(Sql);

                // Tạo một đối tượng DataTable để lưu trữ dữ liệu
                DataSource = new DataTable();

                // Đổ dữ liệu vào DataTable
                Adapter.Fill(DataSource);

                // Đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("GetDanhSachNhanVien" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return DataSource;
        }
    }
}
