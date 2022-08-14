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
    public partial class FormQuanLyNhanVien : Form
    {
        SqlConnection KetNoi = Connection.getConnection();
        SqlCommand ThucHien;
        string lenh;
        private string hoTen, noiSinh, sdt, diaChi;
        private DateTime ngaySinh, ngayBdLam;
        SqlDataReader DocDuLieu;
        int i;

        //public string HoTen
        //{
        //    set { hoTen = value; }
        //}
        //public string NoiSinh
        //{
        //    set { noiSinh = value; }
        //}
        //public DateTime NgaySinh
        //{
        //    set { ngaySinh = value; }
        //}
        //public DateTime NgayBdLam
        //{
        //    set { ngayBdLam = value; }
        //}
        //public string Sdt
        //{
        //    set { sdt = value; }
        //}

        //public string DiaChi
        //{
        //    set { diaChi = value; }
        //}
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
            danhSachBanDau();
        }

        private void danhSachBanDau()
        {
            listViewNhanVien.Items.Clear();
            lenh = @"select *
                     from NhanVien";
            KetNoi.Open();
            ThucHien = new SqlCommand(lenh, KetNoi);
            DocDuLieu = ThucHien.ExecuteReader();
            i = 0;
            while (DocDuLieu.Read())
            {
                listViewNhanVien.Items.Add((i + 1).ToString());
                listViewNhanVien.Items[i].SubItems.Add(DocDuLieu[0].ToString());
                listViewNhanVien.Items[i].SubItems.Add(DocDuLieu[1].ToString());
                listViewNhanVien.Items[i].SubItems.Add(DocDuLieu[2].ToString());
                listViewNhanVien.Items[i].SubItems.Add(DocDuLieu[3].ToString());
                listViewNhanVien.Items[i].SubItems.Add(DocDuLieu[4].ToString());
                listViewNhanVien.Items[i].SubItems.Add(DocDuLieu[5].ToString());
                listViewNhanVien.Items[i].SubItems.Add(DocDuLieu[6].ToString());
                i++;
            }
            KetNoi.Close();
        }

        private void textboxBanDau()
        {
            txtHoTen.Text = "";
            txtTenDN.Text = "";
            txtNoiSinh.Text = "";
            dtpNgayBD.Value = DateTime.Now;
            dtpNgaySinh.Value = DateTime.Now;
            txtSdt.Text = txtDiaChi.Text = "";
            txtTenDN.Focus();
        }

        private bool kiemTraDuLieuTrong()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtNoiSinh.Text)
                ||string.IsNullOrWhiteSpace(txtSdt.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text))
                return true;
            return false;
        }

        private bool kiemTraSo(String s)
        {
            foreach (char i in s)
            {
                if (char.IsDigit(i) == false)
                    return true;
            }
            return false;
        }
        private bool kiemtraMK()
        {
            string mk1 = txtMK.Text;
            string mk2 = txtConFirm.Text;
            if (string.Compare(mk1, mk2, false) == 0)
                return true;
            return false;
        }

        private bool kiemMatKhauTrong()
        {
            if (string.IsNullOrWhiteSpace(txtTenDN.Text) || string.IsNullOrWhiteSpace(txtMK.Text)
                || string.IsNullOrWhiteSpace(txtConFirm.Text))
            {
                return true;
            }
            return false;
        }
        private bool kiemTraChieuDai(String s)
        {
            if (s.Length <= 10 && s.Length >= 0)
                return true;
            return false;
        }

        private void listViewNhanVien_Click(object sender, EventArgs e)
        {
            txtTenDN.Text = listViewNhanVien.SelectedItems[0].SubItems[1].Text;
            txtHoTen.Text = listViewNhanVien.SelectedItems[0].SubItems[2].Text;
            dtpNgaySinh.Value = Convert.ToDateTime(listViewNhanVien.SelectedItems[0].SubItems[3].Text);  
            txtNoiSinh.Text = listViewNhanVien.SelectedItems[0].SubItems[4].Text;
            txtSdt.Text = listViewNhanVien.SelectedItems[0].SubItems[5].Text;
            txtDiaChi.Text = listViewNhanVien.SelectedItems[0].SubItems[6].Text;
            dtpNgayBD.Value = Convert.ToDateTime(listViewNhanVien.SelectedItems[0].SubItems[7].Text);         
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            listViewNhanVien.Items.Clear();
            lenh = @"select *
                     from NhanVien
                     where Sdt = @Sdt OR hoTen like N'%" + txtTim.Text + "%'";
            KetNoi.Open();
            ThucHien = new SqlCommand(lenh, KetNoi);
            ThucHien.Parameters.Add("@Sdt", SqlDbType.Char, 50);
            ThucHien.Parameters["@Sdt"].Value = txtTim.Text;
            DocDuLieu = ThucHien.ExecuteReader();
            i = 0;
            while (DocDuLieu.Read())
            {
                listViewNhanVien.Items.Add((i + 1).ToString());
                listViewNhanVien.Items[i].SubItems.Add(DocDuLieu[0].ToString());
                listViewNhanVien.Items[i].SubItems.Add(DocDuLieu[1].ToString());
                listViewNhanVien.Items[i].SubItems.Add(DocDuLieu[2].ToString());
                listViewNhanVien.Items[i].SubItems.Add(DocDuLieu[3].ToString());
                listViewNhanVien.Items[i].SubItems.Add(DocDuLieu[4].ToString());
                listViewNhanVien.Items[i].SubItems.Add(DocDuLieu[5].ToString());
                listViewNhanVien.Items[i].SubItems.Add(DocDuLieu[6].ToString());
            }
            KetNoi.Close();
            textboxBanDau();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            textboxBanDau();
            txtTim.Text = "";
            danhSachBanDau();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemTraDuLieuTrong() == true)
            {
                MessageBox.Show("Chưa nhập dữ liệu!!!", "Thông báo");
            }
            else
            {
                if (kiemMatKhauTrong() == false)
                {
                    if (kiemtraMK() == true)
                    {
                        try
                        {
                            lenh = @"Insert InTo TaiKhoan(tenDangNhap, matKhau, quyen) 
                                 Values(@TenDN, @MK, 0)";
                            KetNoi.Open();
                            ThucHien = new SqlCommand(lenh, KetNoi);
                            ThucHien.Parameters.Add("@TenDN", SqlDbType.NChar, 50);
                            ThucHien.Parameters.Add("@MK", SqlDbType.NChar, 20);
                            ThucHien.Parameters["@TenDN"].Value = txtTenDN.Text;
                            ThucHien.Parameters["@MK"].Value = txtMK.Text;
                            int a = ThucHien.ExecuteNonQuery();

                            lenh = @"Insert Into NhanVien(idNV, hoTen, ngaySinh, noiSinh, Sdt, diaChi, ngayBatDauLam)
                         Values(@maNV, @hoTen, @ngaySinh, @noiSinh, @Sdt, @diaChi, @ngayBdLam);
                         select * 
                         from NhanVien where idNV = @maNV ";
                            ThucHien = new SqlCommand(lenh, KetNoi);
                            ThucHien.Parameters.Add("@maNV", SqlDbType.NChar, 50);
                            ThucHien.Parameters.Add("@hoTen", SqlDbType.NVarChar, 50);
                            ThucHien.Parameters.Add("@ngaySinh", SqlDbType.Date);
                            ThucHien.Parameters.Add("@noiSinh", SqlDbType.NVarChar, 50);
                            ThucHien.Parameters.Add("@Sdt", SqlDbType.NVarChar, 50);
                            ThucHien.Parameters.Add("@diaChi", SqlDbType.NVarChar, 50);
                            ThucHien.Parameters.Add("@ngayBdLam", SqlDbType.Date);
                            ThucHien.Parameters["@maNV"].Value = txtTenDN.Text;
                            ThucHien.Parameters["@hoTen"].Value = txtHoTen;
                            ThucHien.Parameters["@ngaySinh"].Value = dtpNgaySinh.Value;
                            ThucHien.Parameters["@noiSinh"].Value = txtNoiSinh.Text;
                            ThucHien.Parameters["@Sdt"].Value = txtSdt.Text;
                            ThucHien.Parameters["@diaChi"].Value = txtDiaChi.Text;
                            ThucHien.Parameters["@ngayBdLam"].Value = dtpNgayBD.Value;
                            int b = ThucHien.ExecuteNonQuery();
                            KetNoi.Close();
                            if (a == 0 && b == 0)
                            {
                                MessageBox.Show("Thêm dữ liệu không thành công.", "Thông báo");
                            }
                            else
                            {
                                MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo");
                                danhSachBanDau();
                                textboxBanDau();
                            }
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Thông báo");
                        }


                    }
                    else
                    {
                        DialogResult result = new DialogResult();
                        result = MessageBox.Show("Hai mật khẩu không trùng khớp! Bạn có muốn nhập lại không?", "Thông báo", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            txtTenDN.Text = "";
                            txtMK.Text = "";
                            txtConFirm.Text = "";
                            txtTenDN.Focus();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập dữ liệu!!!", "Thông báo");
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                lenh = @"update NhanVien
                     set hoTen = @hoTen, ngaySinh = @ngaySinh, noiSinh = @noiSinh, Sdt = @Sdt, diaChi = @diaChi, ngayBatDauLam = @ngayBdLam
                     where idNV = @maNV";
                KetNoi.Open();
                ThucHien = new SqlCommand(lenh, KetNoi);
                ThucHien.Parameters.Add("@maNV", SqlDbType.NChar, 50);
                ThucHien.Parameters.Add("@hoTen", SqlDbType.NVarChar, 50);
                ThucHien.Parameters.Add("@ngaySinh", SqlDbType.Date);
                ThucHien.Parameters.Add("@noiSinh", SqlDbType.NVarChar, 50);
                ThucHien.Parameters.Add("@Sdt", SqlDbType.NVarChar, 50);
                ThucHien.Parameters.Add("@diaChi", SqlDbType.NVarChar, 50);
                ThucHien.Parameters.Add("@ngayBdLam", SqlDbType.Date);
                ThucHien.Parameters["@maNV"].Value = listViewNhanVien.SelectedItems[0].SubItems[1].Text;
                ThucHien.Parameters["@hoTen"].Value = txtHoTen.Text;
                ThucHien.Parameters["@ngaySinh"].Value = dtpNgaySinh.Value;
                ThucHien.Parameters["@noiSinh"].Value = txtNoiSinh.Text;
                ThucHien.Parameters["@Sdt"].Value = txtSdt.Text;
                ThucHien.Parameters["@diaChi"].Value = txtDiaChi.Text;
                ThucHien.Parameters["@ngayBdLam"].Value = dtpNgayBD.Value;
                int a = ThucHien.ExecuteNonQuery();
                KetNoi.Close();
                if (a == 0)
                {
                    MessageBox.Show("Sửa dữ liệu KHÔNG thành công.", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sửa dữ liệu thành công.", "Thông báo");
                    danhSachBanDau();
                    textboxBanDau();
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }                       
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                lenh = @"delete from NhanVien
                     where idNV = @maNV";
                KetNoi.Open();
                ThucHien = new SqlCommand(lenh, KetNoi);
                ThucHien.Parameters.Add("@maNV", SqlDbType.NChar, 50);
                ThucHien.Parameters["@maNV"].Value = txtTenDN.Text;
                int a = ThucHien.ExecuteNonQuery();

                lenh = @"delete from TaiKhoan
                         where tenDangNhap = @maNV";
                ThucHien = new SqlCommand(lenh, KetNoi);
                ThucHien.Parameters.Add("@maNV", SqlDbType.NChar, 50);
                ThucHien.Parameters["@maNV"].Value = txtTenDN.Text;
                int b = ThucHien.ExecuteNonQuery();
                KetNoi.Close();

                if (a == 0 && b == 0)
                {
                    MessageBox.Show("Xóa dữ liệu KHÔNG thành công.", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thành công.", "Thông báo");
                    danhSachBanDau();
                    textboxBanDau();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
            
        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {
            string s = txtSdt.Text;
            if (kiemTraSo(s) == true || kiemTraChieuDai(s) == false)
            {
                MessageBox.Show("Bạn nhập SAI dữ liệu (Số điện thoại CHỈ ĐƯỢC nhập số)" +
                    "\nhoặc chiều dài KHÔNG hợp lệ (Chiều dài có 10 ký tự).", "Thông báo");
                txtSdt.Clear();
            }
        }

       
    }
}
