using LTUD1_MF_BHX.Connection;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_MF_BHX.ScreenMenu.Nhap.ChiTietHoaDon
{
    internal class ChiTietHoaDonController : MyController
    {
        public ChiTietHoaDonController(string connectionString) : base(connectionString)
        {
        }

        public override void Delete(object sender)
        {
            ChiTietHoaDon user = (ChiTietHoaDon)sender;
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_chitiethoadon_delete", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@maHD", user.MaHD);
                Sql.Parameters.AddWithValue("@masp", user.MaSP);

                // Thực thi SqlCommand
                Sql.ExecuteNonQuery();

                // Đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public string TongTien(object id)
        {
            string TT = "";
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_chitiethoadon_tongtien", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@makm", id);


                using (SqlDataReader reader = Sql.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Assuming YourColumnName is a string column; adjust accordingly
                        Decimal value = reader.GetDecimal(0);
                       //MessageBox.Show(value.ToString());
                        TT= value.ToString() + "\tVND";
                       // MessageBox.Show(TT);
                    }
                    else
                    {
                        TT = "No data found.";
                    }
                }
                // Đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return TT;
        }
        public void KTTonKho(object id,int sl)
        {
            
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_chitiethoadon_Kiemtratonkho", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@makm", id);
                Sql.Parameters.AddWithValue("@slmua", sl);


                using (SqlDataReader reader = Sql.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Assuming YourColumnName is a string column; adjust accordingly
                        int value = reader.GetInt32(0);
                        MessageBox.Show(value.ToString());
                        if(value > 0)
                        {
                            MessageBox.Show("Sản phẩm tồn kho còn lại: " + value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Hết hàng");
                        }
                        // MessageBox.Show(TT);
                    }
                    else
                    {
                        MessageBox.Show("No data found.");
                    }
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
            throw new NotImplementedException();
        }

        public override void Insert(object sender)
        {
            ChiTietHoaDon user = (ChiTietHoaDon)sender;
            if (KTMASP(user.MaSP) == true)
            {

                try
                {
                    
                    // Mở kết nối
                    SqlConnection conn = OpenConnection();

                    // Tạo một đối tượng SqlCommand
                    Sql = new SqlCommand("sp_chitiethoadon_insert", conn);
                    Sql.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số vào SqlCommand
                    Sql.Parameters.AddWithValue("@mahd", user.MaHD);
                    Sql.Parameters.AddWithValue("masp", user.MaSP);
                    Sql.Parameters.AddWithValue("@sl", user.SoLuong);
                    // Thực thi SqlCommand
                    Sql.ExecuteNonQuery();

                    // Đóng kết nối
                    CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            }
            
        }

        public override void SelectAll()
        {
            try
            {/*
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // thực hiện các thao tác trên cơ sở dữ liệu
                Sql = new SqlCommand("sp_chitiethoadon_select_one", conn);
                Sql.CommandType = CommandType.StoredProcedure;
                Sql.Parameters.AddWithValue("@maHD", user.MaHD);
                // Tạo đối tượng SqlDataAdapter
                Adapter = new SqlDataAdapter(Sql);

                // Tạo một đối tượng Database để lưu trữ dữ liệu
                DataSource = new DataTable();

                // đổ dữ liệu vào DataTable
                Adapter.Fill(DataSource);

                //đóng kết nối
                CloseConnection();*/
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

                // thực hiện các thao tác trên cơ sở dữ liệu
                Sql = new SqlCommand("sp_chitiethoadon_select_all", conn);
                Sql.CommandType = CommandType.StoredProcedure;
                Sql.Parameters.AddWithValue("@mahd", id);
                // Tạo đối tượng SqlDataAdapter
                Adapter = new SqlDataAdapter(Sql);

                // Tạo một đối tượng Database để lưu trữ dữ liệu
                DataSource = new DataTable();

                // đổ dữ liệu vào DataTable
                Adapter.Fill(DataSource);

                //đóng kết nối
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
            return DataSource;
        }
        public bool KTMASP(object id)
        {
           
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // thực hiện các thao tác trên cơ sở dữ liệu
                Sql = new SqlCommand("sp_chitiethoadon_SPDangCo", conn);
                Sql.CommandType = CommandType.StoredProcedure;
                Sql.Parameters.AddWithValue("@makm", id);
                using (SqlDataReader reader = Sql.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Assuming YourColumnName is a string column; adjust accordingly
                        string  value = reader.GetString(0);
                        MessageBox.Show(value.ToString());
                        if (value.ToString() == id.ToString())
                        {
                            return false;
                        }
                        
                    }
                    else
                    {
                        return true;
                        
                    }
                }

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
            return false;
        }

        public override void Update(object sender)
        {
            try
            {
                ChiTietHoaDon user = (ChiTietHoaDon)sender;
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_chitiethoadon_update", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@maHD", user.MaHD);
                Sql.Parameters.AddWithValue("masp", user.MaSP);
                Sql.Parameters.AddWithValue("@SLmua", user.SoLuong);
                // Thực thi SqlCommand
                Sql.ExecuteNonQuery();

                // Đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
