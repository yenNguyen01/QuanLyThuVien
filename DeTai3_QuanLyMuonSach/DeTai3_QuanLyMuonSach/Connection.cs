using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DeTai3_QuanLyMuonSach
{
    class Connection
    {
        private static string stringconnection = @"Data Source=DESKTOP-OEAJGUC\SERVERQTHCSDL;Initial Catalog=QuanLyMuonSach;Integrated Security=True";
        public SqlConnection data = new SqlConnection(stringconnection);

        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringconnection);
        }

        public DataTable readDaTa(string cmd)//đọc dữ liệu từ sql đổ vào DaTaGridView
        {
            data.Open();
            DataTable ta = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, data);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(ta);
            }
            catch (Exception)
            {
                ta = null;
            }
            data.Close();
            return ta;
        }
        public Boolean changeData(String cmd)// thực thi dữ liệu
        {
            data.Open();
            Boolean input = false;
            try
            {
                SqlCommand a = new SqlCommand(cmd, data);
                a.ExecuteNonQuery();
                input = true;
            }
            catch (Exception)
            {
                input = false;
            }
            data.Close();
            return input;
        }
    }
}
