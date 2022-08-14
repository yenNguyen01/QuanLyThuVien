using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai3_QuanLyMuonSach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SqlConnection data = Connection.getConnection();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                data.Open();
                String username = txtTenDN.Text;
                String password = txtMK.Text;
                int quyen;
                SqlDataAdapter dn = new SqlDataAdapter("select * from TaiKhoan where tenDangNhap = N'" + username + "' and matKhau = N'" + password + "'", data);
                DataTable dl = new DataTable();
                dn.Fill(dl);
                if (username == "" || password == "")
                {
                    MessageBox.Show("Chưa nhập Tên đăng nhập hoặc Mật khẩu!");
                }
                else
                {
                    if (dl.Rows.Count > 0)
                    {
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK);
                        this.Hide();
                        FormMain f2 = new FormMain();
                        quyen = (int)dl.Rows[0].ItemArray[2];
                        f2.TenDN = username;
                        f2.Quyen = quyen;
                        f2.Show();                     
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                data.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi hệ thống");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
