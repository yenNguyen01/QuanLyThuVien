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
    public partial class FormQuanLyPhieuMuon : Form
    {
        Connection x = new Connection();

        public FormQuanLyPhieuMuon()
        {
            InitializeComponent();
        }

        private void loadCombo()
        {
            DataTable tb1 = x.readDaTa("select * from Sach");

            cbbMaSach.DataSource = tb1;
            cbbMaSach.DisplayMember = "tenSach";
            cbbMaSach.ValueMember = "idSach";

            DataTable tb2 = x.readDaTa("select * from PhieuMuon");

            cbbMaPhieuMuon.DataSource = tb2;
            cbbMaPhieuMuon.DisplayMember = "soPhieu";
            cbbMaPhieuMuon.ValueMember = "soPhieu";
        }

        private void loadData()
        {
            DataTable tbct = x.readDaTa("select * from ChiTietPhieuMuon order by soPhieu");
            loadCombo();
            if (tbct != null)
            {
                dGVChiTietPhieuMuon.DataSource = tbct;
            }
            dGVChiTietPhieuMuon.Columns[0].HeaderText = "Mã sách";
            dGVChiTietPhieuMuon.Columns[1].HeaderText = "Mã phiếu mượn";
            dGVChiTietPhieuMuon.Columns[2].HeaderText = "Ngày trả";
            dGVChiTietPhieuMuon.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void dGVChiTietPhieuMuon_SelectionChanged(object sender, EventArgs e)
        {
            cbbMaSach.Text = dGVChiTietPhieuMuon.CurrentRow.Cells[0].Value.ToString();
            cbbMaPhieuMuon.Text = dGVChiTietPhieuMuon.CurrentRow.Cells[1].Value.ToString();
            dateTra.Text = dGVChiTietPhieuMuon.CurrentRow.Cells[2].Value.ToString();
        }

        private void FormQuanLyPhieuMuon_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ngayTra = dateTra.Value.ToString("yyyy/MM/dd");
            DataTable ct = x.readDaTa("select * from ChiTietPhieuMuon where idSach= N'" + cbbMaSach.Text + "' and soPhieu= N'" + cbbMaPhieuMuon.Text + "'");
            //if (ct.Rows.Count == 1)
            //{
            //    MessageBox.Show("Sách đã có trong chi tiết phiếu mượn! Vui lòng chọn cuốn khác", "Warning", MessageBoxButtons.OK);
            //    cbbMaSach.Focus();
            //}
            if (x.changeData("INSERT INTO ChiTietPhieuMuon VALUES (N'" + cbbMaSach.SelectedValue.ToString() + "','" + cbbMaPhieuMuon.SelectedValue.ToString() + "','" + ngayTra + "')") == true)
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK);
                loadData();
            }
            else
            {
                MessageBox.Show("Lỗi không thêm được!", "Erorr", MessageBoxButtons.OK);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ngayTra = dateTra.Value.ToString("yyyy/MM/dd");

            if (x.changeData("UPDATE ChiTietPhieuMuon SET ngayTra= N'" + ngayTra + "' where soPhieu= N'" + cbbMaPhieuMuon.SelectedValue.ToString() + "'") == true)
            {
                MessageBox.Show("Gia hạn thành công!", "Thông báo", MessageBoxButtons.OK);
                loadData();
            }
            else
            {
                MessageBox.Show("Lỗi không gia hạn được!", "Erorr", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("Bạn có chắc chắn muốn xóa không ", "Thông báo", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                try
                {

                    x.changeData("delete from ChiTietPhieuMuon where soPhieu='" + cbbMaPhieuMuon.Text + "'");
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable b1 = x.readDaTa("select * from ChiTietPhieuMuon where idSach like '%" + txtTimKiem.Text + "%'");
            DataTable b2 = x.readDaTa("select * from ChiTietPhieuMuon where soPhieu like '%" + txtTimKiem.Text + "%'");
            if (rdMaSach.Checked == true)
            {
                dGVChiTietPhieuMuon.DataSource = b1;
            }
            else dGVChiTietPhieuMuon.DataSource = b2;
        }
    }
}
