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
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;

namespace DeTai3_QuanLyMuonSach
{
    public partial class FormTKSachMuonTheoThang : Form
    {
        SqlConnection KetNoi = Connection.getConnection();
        SqlCommand ThucHien;
        String lenh;
        SqlDataAdapter adapter;
        DataTable data;

        public FormTKSachMuonTheoThang()
        {
            InitializeComponent();
        }

        private void load_cbThang()
        {
            for (int i = 1; i <= 12; i++)
            {
                cbThang.Items.Add(i);
            }
        }

        private void load_nam()
        {
            int max = DateTime.MaxValue.Year;
            for(int i = 2021; i <= max; i++)
            {
                cbNam.Items.Add(i);
            }
        }

        private void danhDach()
        {
            data = new DataTable();
            lenh = @"select a.tenSach, a.loaiSach, a.NXB, a.tacGia, COUNT(a.idSach) as'soLan'
                     from Sach a, PhieuMuon b, ChiTietPhieuMuon c
                     where a.idSach = c.idSach and b.soPhieu = c.soPhieu
                     Group by a.tenSach, a.loaiSach, a.NXB, a.tacGia";
            KetNoi.Open();
            adapter = new SqlDataAdapter(lenh, KetNoi);
            adapter.Fill(data);
            dGvThongTin.DataSource = data;
            KetNoi.Close();
        }

        private void FormTKSachMuonTheoThang_Load(object sender, EventArgs e)
        {
            load_cbThang();
            load_nam();
            danhDach();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Bạn có chắn chắn muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            try
            {
                data = (DataTable)dGvThongTin.DataSource;
                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "THỐNG KÊ BÁO CÁO SỐ LẦN SÁCH ĐƯỢC MƯỢN";
                PdfPage pdfPage = pdf.AddPage();
                XGraphics xGraphics = XGraphics.FromPdfPage(pdfPage);
                XFont xFont = new XFont("Arial", 10);
                XFont xFont_1 = new XFont("Arial", 12, XFontStyle.Bold);

                int yPoint = 0;
                yPoint = yPoint + 100;
                String tenSach = null, loaiSach = null, tenNXB = null, tacGia = null, soLan = null;

                xGraphics.DrawString("THỐNG KÊ BÁO CÁO SỐ LẦN SÁCH ĐƯỢC MƯỢN", new XFont("Arial", 16, XFontStyle.Bold), XBrushes.Black, new XRect(125, 15, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                xGraphics.DrawString("Tên sách", xFont_1, XBrushes.Black, new XRect(10, yPoint - 40, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                xGraphics.DrawString("Loại sách", xFont_1, XBrushes.Black, new XRect(180, yPoint - 40, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                xGraphics.DrawString("Nhà xuất bản", xFont_1, XBrushes.Black, new XRect(280, yPoint - 40, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                xGraphics.DrawString("Tác giả", xFont_1, XBrushes.Black, new XRect(470, yPoint - 40, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                xGraphics.DrawString("Số lần", xFont_1, XBrushes.Black, new XRect(568, yPoint - 40, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                for (int i = 0; i <= data.Rows.Count - 1; i++)
                {
                    tenSach = data.Rows[i].ItemArray[0].ToString();
                    loaiSach = data.Rows[i].ItemArray[1].ToString();
                    tenNXB = data.Rows[i].ItemArray[2].ToString();
                    tacGia = data.Rows[i].ItemArray[3].ToString();
                    soLan = data.Rows[i].ItemArray[4].ToString();

                    xGraphics.DrawString(tenSach, xFont, XBrushes.Black, new XRect(10, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    xGraphics.DrawString(loaiSach, xFont, XBrushes.Black, new XRect(180, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    xGraphics.DrawString(tenNXB, xFont, XBrushes.Black, new XRect(280, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    xGraphics.DrawString(tacGia, xFont, XBrushes.Black, new XRect(470, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    xGraphics.DrawString(soLan, xFont, XBrushes.Black, new XRect(580, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    yPoint = yPoint + 40;
                }

                string pdfFilename = "TKBCSachDuocMuon.pdf";
                pdf.Save(pdfFilename);
                Process.Start(pdfFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Thông báo");
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            data = new DataTable();
            lenh = @"select a.tenSach, a.loaiSach, a.NXB, a.tacGia, COUNT(a.idSach) as'soLan'
                     from Sach a, PhieuMuon b, ChiTietPhieuMuon c
                     where a.idSach = c.idSach and b.soPhieu = c.soPhieu and MONTH(b.ngayMuon) = @date 
                           and YEAR(b.ngayMuon) = @year
                     Group by a.tenSach, a.loaiSach, a.NXB, a.tacGia";
            KetNoi.Open();
            ThucHien = new SqlCommand(lenh, KetNoi);
            ThucHien.Parameters.Add("@date", SqlDbType.Int);
            ThucHien.Parameters["@date"].Value = cbThang.SelectedItem;
            ThucHien.Parameters.Add("@year", SqlDbType.Int);
            ThucHien.Parameters["@year"].Value = cbNam.SelectedItem;
            adapter.SelectCommand = ThucHien;
            adapter.Fill(data);
            dGvThongTin.DataSource = data;
            KetNoi.Close();
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!!!", "Thông báo");
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            danhDach();
        }
    }
}
