using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DeTai3_QuanLyMuonSach
{
    class Modify
    {
        SqlDataAdapter dataAdapter; // truy xuatdu lieu vao bang
        SqlCommand sqlCommand; //dung de truy van va cap nhat toi CSDL
        public Modify()
        {

        }

        public DataTable getAllSach()
        {
            DataTable dataTable = new DataTable();
            string query = "select *from Sach";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public DataTable table(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public bool insert(string tenSach, string tacGia, Decimal soLuong, DateTime ngayNhapKho, string tinhTrang, string NXB, string loaiSach)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into Sach values (@tenSach, @tacGia, @soLuong, @ngayNhapKho, @tinhTrang, @NXB, @loaiSach)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@tenSach", SqlDbType.NVarChar).Value = tenSach;
                sqlCommand.Parameters.Add("@tacGia", SqlDbType.NVarChar).Value = tacGia;
                sqlCommand.Parameters.Add("@soLuong", SqlDbType.Decimal).Value = soLuong;
                sqlCommand.Parameters.Add("@ngayNhapKho", SqlDbType.DateTime).Value = ngayNhapKho;
                sqlCommand.Parameters.Add("@tinhTrang", SqlDbType.NVarChar).Value = tinhTrang;
                sqlCommand.Parameters.Add("@NXB", SqlDbType.NVarChar).Value = NXB;
                sqlCommand.Parameters.Add("@loaiSach", SqlDbType.NVarChar).Value = loaiSach;
                sqlCommand.ExecuteNonQuery(); //thuc thi cau lenh truy van
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool update(Sach sach)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "update Sach set tenSach = @tenSach, tacGia = @tacGia, soLuong = @soLuong, ngayNhapKho = @ngayNhapKho, tinhTrang = @tinhTrang, NXB = @NXB, loaiSach = @loaiSach where idSach = @idSach";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@idSach", SqlDbType.Int).Value = sach.Id;
                sqlCommand.Parameters.Add("@tenSach", SqlDbType.NVarChar).Value = sach.Name;
                sqlCommand.Parameters.Add("@tacGia", SqlDbType.NVarChar).Value = sach.Tacgia;
                sqlCommand.Parameters.Add("@soLuong", SqlDbType.Decimal).Value = sach.Sl;
                sqlCommand.Parameters.Add("@ngayNhapKho", SqlDbType.DateTime).Value = sach.Ngaynhap;
                sqlCommand.Parameters.Add("@tinhTrang", SqlDbType.NVarChar).Value = sach.Tinhtrang;
                sqlCommand.Parameters.Add("@NXB", SqlDbType.NVarChar).Value = sach.Nxb;
                sqlCommand.Parameters.Add("@loaiSach", SqlDbType.NVarChar).Value = sach.Loai;
                sqlCommand.ExecuteNonQuery(); //thuc thi cau lenh truy van

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool delete(int id)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "delete Sach where idSach = @idSach";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@idSach", SqlDbType.NChar).Value = id;
                sqlCommand.ExecuteNonQuery(); //thuc thi cau lenh truy van

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
    }
}
