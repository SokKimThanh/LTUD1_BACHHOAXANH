﻿using System.Data;
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
                Sql.Parameters.AddWithValue("@ma", id);

                // Thực thi SqlCommand
                Sql.ExecuteNonQuery();

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
            throw new NotImplementedException();
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
                Sql.Parameters.AddWithValue("@ma", o.Ma);
                Sql.Parameters.AddWithValue("@ten", o.Ten);
                Sql.Parameters.AddWithValue("@ghichu", o.Ghichu);

                // Thực thi SqlCommand
                Sql.ExecuteNonQuery();

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
                throw new Exception(ex.Message);
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
                Sql.Parameters.AddWithValue("@ma", id);

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
                throw new Exception(ex.Message);
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
                Sql.Parameters.AddWithValue("@ma", o.Ma);
                Sql.Parameters.AddWithValue("@ten", o.Ten);
                Sql.Parameters.AddWithValue("@ghichu", o.Ghichu);

                // Thực thi SqlCommand
                Sql.ExecuteNonQuery();

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
    }
}
