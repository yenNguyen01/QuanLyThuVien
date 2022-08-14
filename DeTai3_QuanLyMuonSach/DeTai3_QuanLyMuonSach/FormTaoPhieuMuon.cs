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
    public partial class FormTaoPhieuMuon : Form
    {
        private string tenDN;
        Connection x = new Connection();

        public FormTaoPhieuMuon()
        {
            InitializeComponent();
        }

        public string TenDN
        {
            set { tenDN = value; }
        }

        private void loadCombo()
        {
            DataTable tb = x.readDaTa("select * from NguoiMuon");

            cbMaNguoiMuon.DataSource = tb;
            cbMaNguoiMuon.DisplayMember = "hoTen";
            cbMaNguoiMuon.ValueMember = "idNguoiMuon";

        }
        private void loadData()
        {
            DataTable tbp = x.readDaTa("select * from PhieuMuon");
            loadCombo();
            if (tbp != null)
            {
                dGVPhieuMuon.DataSource = tbp;
            }
        }

        private void dGVPhieuMuon_SelectionChanged(object sender, EventArgs e)
        {
            txtSoPhieu.Text = dGVPhieuMuon.CurrentRow.Cells[0].Value.ToString();
            cbMaNguoiMuon.Text = dGVPhieuMuon.CurrentRow.Cells[1].Value.ToString();
            dateMuon.Text = dGVPhieuMuon.CurrentRow.Cells[3].Value.ToString();
        }

        private void FormTaoPhieuMuon_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            DataTable tbp = x.readDaTa("select * from PhieuMuon");
            int i = tbp.Rows.Count;
            dGVPhieuMuon.DataSource = tbp;
            if (i >= 0 && i < 9)
            {
                txtSoPhieu.Text = dGVPhieuMuon.Rows[i - 1].Cells[0].Value.ToString().Substring(0, 5) + (i + 1).ToString();
            }
            else
            {
                txtSoPhieu.Text = dGVPhieuMuon.Rows[i - 1].Cells[0].Value.ToString().Substring(0, 4) + (i + 1).ToString();
            }
            dateMuon.Value = DateTime.Now;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngayMuon = dateMuon.Value.ToString("yyyy/MM/dd");

            if (x.changeData("INSERT INTO PhieuMuon VALUES ('" + txtSoPhieu.Text + "','" + cbMaNguoiMuon.SelectedValue.ToString() + "', '" + tenDN + "','" + ngayMuon + "')") == true)
            {
                MessageBox.Show("Tạo phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK);
                loadData();
            }
            else
                MessageBox.Show("Lỗi! Không thêm được phiếu mượn", "Erorr", MessageBoxButtons.OK);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("Bạn có chắc chắn muốn xóa không ", "Thông báo", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                try
                {

                    x.changeData("delete from PhieuMuon where soPhieu='" + txtSoPhieu.Text + "'");
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK);
                    loadData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa", "Thông báo");
                    throw;
                }
            }
            else
                loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string lenh = @"update PhieuMuon
                                set idNguoiMuon = @maNM, ngayMuon = @ngayMuon
                                where soPhieu = @soPhieu";
                SqlConnection KetNoi = Connection.getConnection();
                SqlCommand ThucHien;
                KetNoi.Open();
                ThucHien = new SqlCommand(lenh, KetNoi);
                ThucHien.Parameters.Add("@maNM", SqlDbType.Char, 5);
                ThucHien.Parameters.Add("@soPhieu", SqlDbType.Char, 6);
                ThucHien.Parameters.Add("@ngayMuon", SqlDbType.Date);
                ThucHien.Parameters["@maNM"].Value = cbMaNguoiMuon.SelectedValue.ToString();
                ThucHien.Parameters["@soPhieu"].Value = txtSoPhieu.Text;
                ThucHien.Parameters["@ngayMuon"].Value = dateMuon.Value;
                int a = ThucHien.ExecuteNonQuery();
                KetNoi.Close();
                if (a == 0)
                {
                    MessageBox.Show("Sửa dữ liệu không thành công.", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sửa dữ liệu thành công.", "Thông báo");
                    loadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}
