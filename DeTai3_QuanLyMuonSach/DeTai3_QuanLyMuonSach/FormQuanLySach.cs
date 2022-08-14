using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai3_QuanLyMuonSach
{
    public partial class FormQuanLySach : Form
    {
        public FormQuanLySach()
        {
            InitializeComponent();
        }

        Modify modify;
        Sach sach;

        private void boxBanDau()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtTinhTrang.Text = "";
            txtNXB.Text = "";
            txtLoaiSach.Text = "";
            num_sl.Value = (decimal)0;
            dateNhap.Value = DateTime.Now;
            txtMaSach.Focus();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            string name = txtTim.Text.Trim();
            if (name == "")
            {
                FormQuanLySach_Load(sender, e);
            }
            else
            {
                string query = "select * from Sach where tenSach like N'%" + name + "%'";
                dGVThongTinSach.DataSource = modify.table(query);
            }
        }

        private void FormQuanLySach_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                boxBanDau();
                dGVThongTinSach.DataSource = modify.getAllSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string name = txtTenSach.Text;
            string tacgia = txtTacGia.Text;
            Decimal sl = (Decimal)num_sl.Value;
            DateTime ngaynhap = dateNhap.Value;
            string tinhtrang = txtTinhTrang.Text;
            string nxb = txtNXB.Text;
            string loai = txtLoaiSach.Text;
            if (modify.insert(name, tacgia, sl, ngaynhap, tinhtrang, nxb, loai))
            {
                dGVThongTinSach.DataSource = modify.getAllSach();
                boxBanDau();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "Không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMaSach.Text);
            string name = txtTenSach.Text;
            string tacgia = txtTacGia.Text;
            int sl = (int)num_sl.Value;
            DateTime ngaynhap = dateNhap.Value;
            string tinhtrang = txtTinhTrang.Text;
            string nxb = txtNXB.Text;
            string loai = txtLoaiSach.Text;
            sach = new Sach(id, name, tacgia, sl, ngaynhap, tinhtrang, nxb, loai);
            if (modify.update(sach))
            {
                dGVThongTinSach.DataSource = modify.getAllSach();
                boxBanDau();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "Không sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = (int)dGVThongTinSach.SelectedRows[0].Cells[0].Value;
            if (modify.delete(id))
            {
                dGVThongTinSach.DataSource = modify.getAllSach();
                boxBanDau();
            }

            else
            {
                MessageBox.Show("Lỗi: " + "Không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dGVThongTinSach_SelectionChanged(object sender, EventArgs e)
        {
            txtMaSach.Text = dGVThongTinSach.CurrentRow.Cells[0].Value.ToString();
            txtTenSach.Text = dGVThongTinSach.CurrentRow.Cells[1].Value.ToString();
            txtTacGia.Text = dGVThongTinSach.CurrentRow.Cells[2].Value.ToString();
            num_sl.Value = (Decimal)dGVThongTinSach.CurrentRow.Cells[3].Value;
            dateNhap.Value = Convert.ToDateTime(dGVThongTinSach.CurrentRow.Cells[4].Value.ToString());
            txtTinhTrang.Text = dGVThongTinSach.CurrentRow.Cells[5].Value.ToString();
            txtNXB.Text = dGVThongTinSach.CurrentRow.Cells[6].Value.ToString();
            txtLoaiSach.Text = dGVThongTinSach.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
