
namespace DeTai3_QuanLyMuonSach
{
    partial class FormTaoPhieuMuon
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
            this.groupBoxTT = new System.Windows.Forms.GroupBox();
            this.cbMaNguoiMuon = new System.Windows.Forms.ComboBox();
            this.dateMuon = new System.Windows.Forms.DateTimePicker();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTaoPhieu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dGVPhieuMuon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(-2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1116, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẠO PHIẾU MƯỢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxTT
            // 
            this.groupBoxTT.Controls.Add(this.cbMaNguoiMuon);
            this.groupBoxTT.Controls.Add(this.dateMuon);
            this.groupBoxTT.Controls.Add(this.txtSoPhieu);
            this.groupBoxTT.Controls.Add(this.label4);
            this.groupBoxTT.Controls.Add(this.label3);
            this.groupBoxTT.Controls.Add(this.label2);
            this.groupBoxTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxTT.Location = new System.Drawing.Point(80, 81);
            this.groupBoxTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTT.Name = "groupBoxTT";
            this.groupBoxTT.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTT.Size = new System.Drawing.Size(954, 182);
            this.groupBoxTT.TabIndex = 1;
            this.groupBoxTT.TabStop = false;
            this.groupBoxTT.Text = "Thông tin chi tiết";
            // 
            // cbMaNguoiMuon
            // 
            this.cbMaNguoiMuon.FormattingEnabled = true;
            this.cbMaNguoiMuon.Location = new System.Drawing.Point(635, 42);
            this.cbMaNguoiMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaNguoiMuon.Name = "cbMaNguoiMuon";
            this.cbMaNguoiMuon.Size = new System.Drawing.Size(264, 28);
            this.cbMaNguoiMuon.TabIndex = 5;
            // 
            // dateMuon
            // 
            this.dateMuon.Location = new System.Drawing.Point(188, 118);
            this.dateMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateMuon.Name = "dateMuon";
            this.dateMuon.Size = new System.Drawing.Size(319, 26);
            this.dateMuon.TabIndex = 4;
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(188, 44);
            this.txtSoPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(183, 26);
            this.txtSoPhieu.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(481, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã người mượn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(53, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày mượn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(53, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số phiếu:";
            // 
            // btnTaoPhieu
            // 
            this.btnTaoPhieu.BackColor = System.Drawing.Color.Blue;
            this.btnTaoPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoPhieu.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTaoPhieu.Location = new System.Drawing.Point(188, 279);
            this.btnTaoPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoPhieu.Name = "btnTaoPhieu";
            this.btnTaoPhieu.Size = new System.Drawing.Size(137, 36);
            this.btnTaoPhieu.TabIndex = 2;
            this.btnTaoPhieu.Text = "Tạo phiếu";
            this.btnTaoPhieu.UseVisualStyleBackColor = false;
            this.btnTaoPhieu.Click += new System.EventHandler(this.btnTaoPhieu_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnLuu.Location = new System.Drawing.Point(393, 279);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(137, 36);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(607, 279);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(137, 36);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Window;
            this.btnXoa.Location = new System.Drawing.Point(821, 279);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 36);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dGVPhieuMuon
            // 
            this.dGVPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dGVPhieuMuon.Location = new System.Drawing.Point(80, 341);
            this.dGVPhieuMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVPhieuMuon.Name = "dGVPhieuMuon";
            this.dGVPhieuMuon.RowHeadersWidth = 62;
            this.dGVPhieuMuon.RowTemplate.Height = 28;
            this.dGVPhieuMuon.Size = new System.Drawing.Size(954, 190);
            this.dGVPhieuMuon.TabIndex = 6;
            this.dGVPhieuMuon.SelectionChanged += new System.EventHandler(this.dGVPhieuMuon_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "soPhieu";
            this.Column1.HeaderText = "Số phiếu";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "idNguoiMuon";
            this.Column2.HeaderText = "Mã người mượn";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "idNV";
            this.Column3.HeaderText = "Mã nhân viên";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ngayMuon";
            this.Column4.HeaderText = "Ngày mượn";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // FormTaoPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 661);
            this.Controls.Add(this.dGVPhieuMuon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTaoPhieu);
            this.Controls.Add(this.groupBoxTT);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTaoPhieuMuon";
            this.Text = "Tạo phiếu mượn";
            this.Load += new System.EventHandler(this.FormTaoPhieuMuon_Load);
            this.groupBoxTT.ResumeLayout(false);
            this.groupBoxTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPhieuMuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxTT;
        private System.Windows.Forms.ComboBox cbMaNguoiMuon;
        private System.Windows.Forms.DateTimePicker dateMuon;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTaoPhieu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dGVPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}