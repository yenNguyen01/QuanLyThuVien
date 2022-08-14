
namespace DeTai3_QuanLyMuonSach
{
    partial class FormQuanLyPhieuMuon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdMaPhieu = new System.Windows.Forms.RadioButton();
            this.rdMaSach = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTra = new System.Windows.Forms.DateTimePicker();
            this.cbbMaPhieuMuon = new System.Windows.Forms.ComboBox();
            this.cbbMaSach = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dGVChiTietPhieuMuon = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVChiTietPhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(428, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ PHIẾU MƯỢN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.rdMaPhieu);
            this.groupBox1.Controls.Add(this.rdMaSach);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(180, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(732, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(429, 76);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(135, 31);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(175, 80);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(209, 24);
            this.txtTimKiem.TabIndex = 2;
            // 
            // rdMaPhieu
            // 
            this.rdMaPhieu.AutoSize = true;
            this.rdMaPhieu.Location = new System.Drawing.Point(442, 34);
            this.rdMaPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdMaPhieu.Name = "rdMaPhieu";
            this.rdMaPhieu.Size = new System.Drawing.Size(131, 22);
            this.rdMaPhieu.TabIndex = 1;
            this.rdMaPhieu.TabStop = true;
            this.rdMaPhieu.Text = "Mã phiếu mượn";
            this.rdMaPhieu.UseVisualStyleBackColor = true;
            // 
            // rdMaSach
            // 
            this.rdMaSach.AutoSize = true;
            this.rdMaSach.Location = new System.Drawing.Point(175, 34);
            this.rdMaSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdMaSach.Name = "rdMaSach";
            this.rdMaSach.Size = new System.Drawing.Size(86, 22);
            this.rdMaSach.TabIndex = 0;
            this.rdMaSach.TabStop = true;
            this.rdMaSach.Text = "Mã sách";
            this.rdMaSach.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTra);
            this.groupBox2.Controls.Add(this.cbbMaPhieuMuon);
            this.groupBox2.Controls.Add(this.cbbMaSach);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(90, 191);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(948, 137);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // dateTra
            // 
            this.dateTra.Location = new System.Drawing.Point(180, 89);
            this.dateTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTra.Name = "dateTra";
            this.dateTra.Size = new System.Drawing.Size(273, 22);
            this.dateTra.TabIndex = 5;
            // 
            // cbbMaPhieuMuon
            // 
            this.cbbMaPhieuMuon.FormattingEnabled = true;
            this.cbbMaPhieuMuon.Location = new System.Drawing.Point(613, 35);
            this.cbbMaPhieuMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaPhieuMuon.Name = "cbbMaPhieuMuon";
            this.cbbMaPhieuMuon.Size = new System.Drawing.Size(235, 24);
            this.cbbMaPhieuMuon.TabIndex = 4;
            // 
            // cbbMaSach
            // 
            this.cbbMaSach.FormattingEnabled = true;
            this.cbbMaSach.Location = new System.Drawing.Point(180, 35);
            this.cbbMaSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaSach.Name = "cbbMaSach";
            this.cbbMaSach.Size = new System.Drawing.Size(235, 24);
            this.cbbMaSach.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày trả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số phiếu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sách:";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Blue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(252, 336);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 38);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Orange;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(500, 336);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(128, 38);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Gia hạn";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(749, 336);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 38);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dGVChiTietPhieuMuon
            // 
            this.dGVChiTietPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVChiTietPhieuMuon.Location = new System.Drawing.Point(90, 382);
            this.dGVChiTietPhieuMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVChiTietPhieuMuon.Name = "dGVChiTietPhieuMuon";
            this.dGVChiTietPhieuMuon.RowHeadersWidth = 62;
            this.dGVChiTietPhieuMuon.RowTemplate.Height = 28;
            this.dGVChiTietPhieuMuon.Size = new System.Drawing.Size(948, 166);
            this.dGVChiTietPhieuMuon.TabIndex = 6;
            this.dGVChiTietPhieuMuon.SelectionChanged += new System.EventHandler(this.dGVChiTietPhieuMuon_SelectionChanged);
            // 
            // FormQuanLyPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 661);
            this.Controls.Add(this.dGVChiTietPhieuMuon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQuanLyPhieuMuon";
            this.Text = "Quản lý phiếu mượn";
            this.Load += new System.EventHandler(this.FormQuanLyPhieuMuon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVChiTietPhieuMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdMaPhieu;
        private System.Windows.Forms.RadioButton rdMaSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTra;
        private System.Windows.Forms.ComboBox cbbMaPhieuMuon;
        private System.Windows.Forms.ComboBox cbbMaSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dGVChiTietPhieuMuon;
    }
}