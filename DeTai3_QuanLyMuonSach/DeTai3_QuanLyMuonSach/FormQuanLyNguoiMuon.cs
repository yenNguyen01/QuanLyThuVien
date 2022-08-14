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
    public partial class FormQuanLyNguoiMuon : Form
    {
        SqlConnection KetNoi = Connection.getConnection();
        SqlCommand ThucHien;
        SqlDataReader DocDuLieu;
        String lenh;
        int i;

        public FormQuanLyNguoiMuon()
        {
            InitializeComponent();
            danhSachBanDau();
        }

        private void danhSachBanDau()
        {
            listViewNguoiMuon.Items.Clear();
            lenh = @"select idNguoiMuon, hoTen, ngaySinh, diaChi, Sdt, soSachMuon, soSachConGiu, soSachQuaHan
                     from NguoiMuon";
            KetNoi.Open();
            ThucHien = new SqlCommand(lenh, KetNoi);
            DocDuLieu = ThucHien.ExecuteReader();
            i = 0;
            while (DocDuLieu.Read())
            {
                listViewNguoiMuon.Items.Add((i + 1).ToString());
                listViewNguoiMuon.Items[i].SubItems.Add(DocDuLieu[0].ToString());
                listViewNguoiMuon.Items[i].SubItems.Add(DocDuLieu[1].ToString());
                listViewNguoiMuon.Items[i].SubItems.Add(Convert.ToDateTime(DocDuLieu[2]).ToShortDateString());
                listViewNguoiMuon.Items[i].SubItems.Add(DocDuLieu[4].ToString());
                listViewNguoiMuon.Items[i].SubItems.Add(DocDuLieu[3].ToString());
                listViewNguoiMuon.Items[i].SubItems.Add(DocDuLieu[5].ToString());
                listViewNguoiMuon.Items[i].SubItems.Add(DocDuLieu[6].ToString());
                listViewNguoiMuon.Items[i].SubItems.Add(DocDuLieu[7].ToString());
                i++;
            }
            KetNoi.Close();
        }

        private void textboxBanDau()
        {
            txtmaNM.Text = "";
            txthoTen.Text = "";
            dtmSinh.Value = DateTime.Now;
            txtDiaChi.Text = "";
            txtSdt.Text = "";
            txtSachGiu.Text = txtSachMuon.Text = txtSachQuaHan.Text = "";
        }

        private bool kiemTraDuLieuTrong()
        {
            if (String.IsNullOrWhiteSpace(txthoTen.Text) || String.IsNullOrWhiteSpace(txtDiaChi.Text)
                || String.IsNullOrWhiteSpace(txtSdt.Text))
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

        private bool kiemTraChieuDai(String s)
        {
            if (s.Length <= 10 && s.Length >= 0)
                return true;
            return false;
        }

        private void listViewNguoiMuon_Click(object sender, EventArgs e)
        {
            txtmaNM.Text = listViewNguoiMuon.SelectedItems[0].SubItems[1].Text;
            txthoTen.Text = listViewNguoiMuon.SelectedItems[0].SubItems[2].Text;
            dtmSinh.Value = Convert.ToDateTime(listViewNguoiMuon.SelectedItems[0].SubItems[3].Text);
            txtDiaChi.Text = listViewNguoiMuon.SelectedItems[0].SubItems[5].Text;
            txtSdt.Text = listViewNguoiMuon.SelectedItems[0].SubItems[4].Text;
            txtSachMuon.Text = listViewNguoiMuon.SelectedItems[0].SubItems[6].Text;
            txtSachGiu.Text = listViewNguoiMuon.SelectedItems[0].SubItems[7].Text;
            txtSachQuaHan.Text = listViewNguoiMuon.SelectedItems[0].SubItems[8].Text;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            textboxBanDau();
            listViewNguoiMuon.Items.Clear();
            lenh = @"select idNguoiMuon, hoTen, ngaySinh, diaChi, Sdt, soSachMuon, soSachConGiu, soSachQuaHan
                     from NguoiMuon
                     where Sdt = @Sdt OR hoTen LIKE N'%" + txtTim.Text + "%'";
            KetNoi.Open();
            ThucHien = new SqlCommand(lenh, KetNoi);
            ThucHien.Parameters.Add("@Sdt", SqlDbType.NChar, 50);
            ThucHien.Parameters["@Sdt"].Value = txtTim.Text;
            DocDuLieu = ThucHien.ExecuteReader();
            i = 0;
            while (DocDuLieu.Read())
            {
                listViewNguoiMuon.Items.Add((i + 1).ToString());
                listViewNguoiMuon.Items[i].SubItems.Add(DocDuLieu[0].ToString());
                listViewNguoiMuon.Items[i].SubItems.Add(DocDuLieu[1].ToString());
                listViewNguoiMuon.Items[i].SubItems.Add(Convert.ToDateTime(DocDuLieu[2]).ToShortDateString());
                listViewNguoiMuon.Items[i].SubItems.Add(DocDuLieu[4].ToString());
                listViewNguoiMuon.Items[i].SubItems.Add(DocDuLieu[3].ToString());
                listViewNguoiMuon.Items[i].SubItems.Add(DocDuLieu[5].ToString());
                listViewNguoiMuon.Items[i].SubItems.Add(DocDuLieu[6].ToString());
                listViewNguoiMuon.Items[i].SubItems.Add(DocDuLieu[7].ToString());
                i++;
            }
            KetNoi.Close();
            txtTim.Text = "";
            txtTim.Focus();
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
                MessageBox.Show("Chưa nhập dữ liệu!!!", "Thông báo");
            else
            {
                try
                {
                    lenh = @"Insert Into NguoiMuon(hoTen, ngaySinh, Sdt, diaChi, trangThai, soSachMuon, soSachConGiu, soSachQuaHan)
                         Values(@hoTen, @ngaySinh, @SDT, @diaChi, 'Còn', 0.00, 0.00, 0.00)";
                    KetNoi.Open();
                    ThucHien = new SqlCommand(lenh, KetNoi);
                    ThucHien.Parameters.Add("@hoTen", SqlDbType.NVarChar, 50);
                    ThucHien.Parameters.Add("@ngaySinh", SqlDbType.Date);
                    ThucHien.Parameters.Add("@SDT", SqlDbType.NVarChar, 50);
                    ThucHien.Parameters.Add("@diaChi", SqlDbType.NVarChar, 50);
                    ThucHien.Parameters["@hoTen"].Value = txthoTen.Text;
                    ThucHien.Parameters["@ngaySinh"].Value = dtmSinh.Value;
                    ThucHien.Parameters["@SDT"].Value = txtSdt.Text;
                    ThucHien.Parameters["@diaChi"].Value = txtDiaChi.Text;
                    int a = ThucHien.ExecuteNonQuery();
                    KetNoi.Close();
                    if (a == 0)
                    {
                        MessageBox.Show("Thêm dữ liệu không thành công.", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo");
                        danhSachBanDau();
                        textboxBanDau();
                        txtmaNM.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                lenh = @"update NguoiMuon
                        set idNguoiMuon = @maNM, hoTen = @hoTen, ngaySinh = @ngaySinh, diaChi = @diaChi, soSachMuon = @sachMuon, soSachConGiu = @sachGiu,
                        soSachQuaHan = @quaHan
                     where idNguoiMuon = @maNM1";
                KetNoi.Open();
                ThucHien = new SqlCommand(lenh, KetNoi);
                ThucHien.Parameters.Add("@maNM", SqlDbType.NChar, 50);
                ThucHien.Parameters.Add("@maNM1", SqlDbType.NChar, 50);
                ThucHien.Parameters.Add("@hoTen", SqlDbType.NVarChar, 50);
                ThucHien.Parameters.Add("@ngaySinh", SqlDbType.Date);
                ThucHien.Parameters.Add("@SDT", SqlDbType.NVarChar, 50);
                ThucHien.Parameters.Add("@diaChi", SqlDbType.NVarChar, 50);
                ThucHien.Parameters.Add("@sachMuon", SqlDbType.Decimal);
                ThucHien.Parameters.Add("@sachGiu", SqlDbType.Decimal);
                ThucHien.Parameters.Add("@quaHan", SqlDbType.Decimal);
                ThucHien.Parameters["@maNM"].Value = txtmaNM.Text;
                ThucHien.Parameters["@maNM1"].Value = listViewNguoiMuon.SelectedItems[0].SubItems[1].Text;
                ThucHien.Parameters["@hoTen"].Value = txthoTen.Text;
                ThucHien.Parameters["@ngaySinh"].Value = dtmSinh.Value;
                ThucHien.Parameters["@SDT"].Value = txtSdt.Text;
                ThucHien.Parameters["@diaChi"].Value = txtDiaChi.Text;
                ThucHien.Parameters["@sachMuon"].Value = txtSachMuon.Text;
                ThucHien.Parameters["@sachGiu"].Value = txtSachGiu.Text;
                ThucHien.Parameters["@quaHan"].Value = txtSachQuaHan.Text;
                int a = ThucHien.ExecuteNonQuery();
                KetNoi.Close();
                if (a == 0)
                {
                    MessageBox.Show("Sửa dữ liệu không thành công.", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sửa dữ liệu thành công.", "Thông báo");
                    danhSachBanDau();
                    textboxBanDau();
                    txtmaNM.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                lenh = @"delete from NguoiMuon
                     where idNguoiMuon = @maNM";
                KetNoi.Open();
                ThucHien = new SqlCommand(lenh, KetNoi);
                ThucHien.Parameters.Add("@maNM", SqlDbType.NChar, 50);
                ThucHien.Parameters["@maNM"].Value = txtmaNM.Text;
                int a = ThucHien.ExecuteNonQuery();
                KetNoi.Close();
                if (a == 0)
                {
                    MessageBox.Show("Xóa dữ liệu không thành công.", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thành công.", "Thông báo");
                    danhSachBanDau();
                    textboxBanDau();
                    txtmaNM.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {
            string s = txtSdt.Text;
            if (kiemTraSo(s) == true || kiemTraChieuDai(s) == false)
            {
                MessageBox.Show("Bạn nhập SAI dữ liệu (Số điện thoại CHỈ ĐƯỢC nhập số)"+
                    "\nhoặc chiều dài KHÔNG hợp lệ (Chiều dài có 10 ký tự).", "Thông báo");
                txtSdt.Clear();
            }
        }
    }
}
