
namespace DeTai3_QuanLyMuonSach
{
    partial class FormMain
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
            this.btnTaoPhieuMuon = new FontAwesome.Sharp.IconButton();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.btnQLSach = new FontAwesome.Sharp.IconButton();
            this.btnQLNV = new FontAwesome.Sharp.IconButton();
            this.btnQLNguoiMuon = new FontAwesome.Sharp.IconButton();
            this.panelQLPhieu = new System.Windows.Forms.Panel();
            this.btnQLPM = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitltBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelQLPhieu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitltBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaoPhieuMuon
            // 
            this.btnTaoPhieuMuon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaoPhieuMuon.FlatAppearance.BorderSize = 0;
            this.btnTaoPhieuMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoPhieuMuon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTaoPhieuMuon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTaoPhieuMuon.IconColor = System.Drawing.Color.Black;
            this.btnTaoPhieuMuon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTaoPhieuMuon.Location = new System.Drawing.Point(0, 0);
            this.btnTaoPhieuMuon.Name = "btnTaoPhieuMuon";
            this.btnTaoPhieuMuon.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTaoPhieuMuon.Size = new System.Drawing.Size(250, 40);
            this.btnTaoPhieuMuon.TabIndex = 0;
            this.btnTaoPhieuMuon.Text = "Tạo phiếu mượn";
            this.btnTaoPhieuMuon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoPhieuMuon.UseVisualStyleBackColor = true;
            this.btnTaoPhieuMuon.Click += new System.EventHandler(this.btnTaoPhieuMuon_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnThoat);
            this.panelSideMenu.Controls.Add(this.btnThongKe);
            this.panelSideMenu.Controls.Add(this.btnQLSach);
            this.panelSideMenu.Controls.Add(this.btnQLNV);
            this.panelSideMenu.Controls.Add(this.btnQLNguoiMuon);
            this.panelSideMenu.Controls.Add(this.panelQLPhieu);
            this.panelSideMenu.Controls.Add(this.btnQLPM);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 783);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnThoat.IconColor = System.Drawing.Color.Silver;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.IconSize = 32;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(0, 405);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnThoat.Size = new System.Drawing.Size(250, 40);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.Stairs;
            this.btnThongKe.IconColor = System.Drawing.Color.Silver;
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.IconSize = 32;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 365);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(250, 40);
            this.btnThongKe.TabIndex = 9;
            this.btnThongKe.Text = "Thống kê ";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnQLSach
            // 
            this.btnQLSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLSach.FlatAppearance.BorderSize = 0;
            this.btnQLSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLSach.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQLSach.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnQLSach.IconColor = System.Drawing.Color.Silver;
            this.btnQLSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLSach.IconSize = 32;
            this.btnQLSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSach.Location = new System.Drawing.Point(0, 325);
            this.btnQLSach.Name = "btnQLSach";
            this.btnQLSach.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnQLSach.Size = new System.Drawing.Size(250, 40);
            this.btnQLSach.TabIndex = 8;
            this.btnQLSach.Text = "Quản lý sách";
            this.btnQLSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLSach.UseVisualStyleBackColor = true;
            this.btnQLSach.Click += new System.EventHandler(this.btnQLSach_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.BackColor = System.Drawing.Color.Black;
            this.btnQLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNV.FlatAppearance.BorderSize = 0;
            this.btnQLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQLNV.IconChar = FontAwesome.Sharp.IconChar.BuildingUser;
            this.btnQLNV.IconColor = System.Drawing.Color.Silver;
            this.btnQLNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLNV.IconSize = 32;
            this.btnQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.Location = new System.Drawing.Point(0, 280);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnQLNV.Size = new System.Drawing.Size(250, 45);
            this.btnQLNV.TabIndex = 6;
            this.btnQLNV.Text = "Quản lý nhân viên";
            this.btnQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLNV.UseVisualStyleBackColor = false;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnQLNguoiMuon
            // 
            this.btnQLNguoiMuon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNguoiMuon.FlatAppearance.BorderSize = 0;
            this.btnQLNguoiMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNguoiMuon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQLNguoiMuon.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.btnQLNguoiMuon.IconColor = System.Drawing.Color.Silver;
            this.btnQLNguoiMuon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLNguoiMuon.IconSize = 32;
            this.btnQLNguoiMuon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNguoiMuon.Location = new System.Drawing.Point(0, 240);
            this.btnQLNguoiMuon.Name = "btnQLNguoiMuon";
            this.btnQLNguoiMuon.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnQLNguoiMuon.Size = new System.Drawing.Size(250, 40);
            this.btnQLNguoiMuon.TabIndex = 3;
            this.btnQLNguoiMuon.Text = "Quản lý người mượn";
            this.btnQLNguoiMuon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNguoiMuon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLNguoiMuon.UseVisualStyleBackColor = true;
            this.btnQLNguoiMuon.Click += new System.EventHandler(this.btnQLNguoiMuon_Click);
            // 
            // panelQLPhieu
            // 
            this.panelQLPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.panelQLPhieu.Controls.Add(this.btnTaoPhieuMuon);
            this.panelQLPhieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQLPhieu.Location = new System.Drawing.Point(0, 190);
            this.panelQLPhieu.Name = "panelQLPhieu";
            this.panelQLPhieu.Size = new System.Drawing.Size(250, 50);
            this.panelQLPhieu.TabIndex = 2;
            // 
            // btnQLPM
            // 
            this.btnQLPM.BackColor = System.Drawing.Color.Black;
            this.btnQLPM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLPM.FlatAppearance.BorderSize = 0;
            this.btnQLPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLPM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQLPM.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.btnQLPM.IconColor = System.Drawing.Color.DarkGray;
            this.btnQLPM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLPM.IconSize = 32;
            this.btnQLPM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPM.Location = new System.Drawing.Point(0, 145);
            this.btnQLPM.Name = "btnQLPM";
            this.btnQLPM.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnQLPM.Size = new System.Drawing.Size(250, 45);
            this.btnQLPM.TabIndex = 1;
            this.btnQLPM.Text = "Quản lý phiếu mượn";
            this.btnQLPM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLPM.UseVisualStyleBackColor = false;
            this.btnQLPM.Click += new System.EventHandler(this.btnQLPM_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 145);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::DeTai3_QuanLyMuonSach.Properties.Resources.DKy;
            this.btnHome.Location = new System.Drawing.Point(68, 29);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(95, 65);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitltBar
            // 
            this.panelTitltBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelTitltBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitltBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitltBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitltBar.Location = new System.Drawing.Point(250, 0);
            this.panelTitltBar.Name = "panelTitltBar";
            this.panelTitltBar.Size = new System.Drawing.Size(1215, 75);
            this.panelTitltBar.TabIndex = 1;
            this.panelTitltBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitltBar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleChildForm.Location = new System.Drawing.Point(70, 40);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(45, 17);
            this.lblTitleChildForm.TabIndex = 2;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Maroon;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Maroon;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 34;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(28, 29);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(38, 34);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelChildForm.Location = new System.Drawing.Point(250, 75);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1215, 708);
            this.panelChildForm.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1465, 783);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelTitltBar);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelQLPhieu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitltBar.ResumeLayout(false);
            this.panelTitltBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private FontAwesome.Sharp.IconButton btnQLPM;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelQLPhieu;
        private FontAwesome.Sharp.IconButton btnQLNguoiMuon;
        private FontAwesome.Sharp.IconButton btnQLSach;
        private FontAwesome.Sharp.IconButton btnQLNV;
        private System.Windows.Forms.Panel panelTitltBar;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton btnTaoPhieuMuon;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private FontAwesome.Sharp.IconButton btnThoat;
    }
}


//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.menuStripQlMS = new System.Windows.Forms.MenuStrip();
//            this.phiếuMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.lậpPhiếuMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.quảnLýPhiếuMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.quảnLýNgườiMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.sốLầnSáchĐượcMượnTheoThángToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.menuStripQlMS.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // menuStripQlMS
//            // 
//            this.menuStripQlMS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
//            this.menuStripQlMS.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
//            this.menuStripQlMS.ImageScalingSize = new System.Drawing.Size(24, 24);
//            this.menuStripQlMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.phiếuMượnToolStripMenuItem,
//            this.quảnLýSáchToolStripMenuItem,
//            this.quảnLýNgườiMượnToolStripMenuItem,
//            this.quảnLýNhânViênToolStripMenuItem,
//            this.thốngKêToolStripMenuItem,
//            this.thoátToolStripMenuItem});
//            this.menuStripQlMS.Location = new System.Drawing.Point(0, 0);
//            this.menuStripQlMS.Name = "menuStripQlMS";
//            this.menuStripQlMS.Size = new System.Drawing.Size(1324, 36);
//            this.menuStripQlMS.TabIndex = 0;
//            this.menuStripQlMS.Text = "menuStrip1";
//            // 
//            // phiếuMượnToolStripMenuItem
//            // 
//            this.phiếuMượnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.lậpPhiếuMượnToolStripMenuItem,
//            this.quảnLýPhiếuMượnToolStripMenuItem});
//            this.phiếuMượnToolStripMenuItem.Name = "phiếuMượnToolStripMenuItem";
//            this.phiếuMượnToolStripMenuItem.Size = new System.Drawing.Size(133, 32);
//            this.phiếuMượnToolStripMenuItem.Text = "Phiếu mượn";
//            // 
//            // lậpPhiếuMượnToolStripMenuItem
//            // 
//            this.lậpPhiếuMượnToolStripMenuItem.Name = "lậpPhiếuMượnToolStripMenuItem";
//            this.lậpPhiếuMượnToolStripMenuItem.Size = new System.Drawing.Size(292, 36);
//            this.lậpPhiếuMượnToolStripMenuItem.Text = "Lập phiếu mượn";
//            this.lậpPhiếuMượnToolStripMenuItem.Click += new System.EventHandler(this.lậpPhiếuMượnToolStripMenuItem_Click);
//            // 
//            // quảnLýPhiếuMượnToolStripMenuItem
//            // 
//            this.quảnLýPhiếuMượnToolStripMenuItem.Name = "quảnLýPhiếuMượnToolStripMenuItem";
//            this.quảnLýPhiếuMượnToolStripMenuItem.Size = new System.Drawing.Size(292, 36);
//            this.quảnLýPhiếuMượnToolStripMenuItem.Text = "Quản lý phiếu mượn";
//            this.quảnLýPhiếuMượnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýPhiếuMượnToolStripMenuItem_Click);
//            // 
//            // quảnLýSáchToolStripMenuItem
//            // 
//            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
//            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(138, 32);
//            this.quảnLýSáchToolStripMenuItem.Text = "Quản lý sách";
//            this.quảnLýSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSáchToolStripMenuItem_Click);
//            // 
//            // quảnLýNgườiMượnToolStripMenuItem
//            // 
//            this.quảnLýNgườiMượnToolStripMenuItem.Name = "quảnLýNgườiMượnToolStripMenuItem";
//            this.quảnLýNgườiMượnToolStripMenuItem.Size = new System.Drawing.Size(209, 32);
//            this.quảnLýNgườiMượnToolStripMenuItem.Text = "Quản lý người mượn";
//            this.quảnLýNgườiMượnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNgườiMượnToolStripMenuItem_Click);
//            // 
//            // quảnLýNhânViênToolStripMenuItem
//            // 
//            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
//            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(184, 32);
//            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
//            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
//            // 
//            // thốngKêToolStripMenuItem
//            // 
//            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.sốLầnSáchĐượcMượnTheoThángToolStripMenuItem});
//            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
//            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(109, 32);
//            this.thốngKêToolStripMenuItem.Text = "Thống kê";
//            // 
//            // sốLầnSáchĐượcMượnTheoThángToolStripMenuItem
//            // 
//            this.sốLầnSáchĐượcMượnTheoThángToolStripMenuItem.Name = "sốLầnSáchĐượcMượnTheoThángToolStripMenuItem";
//            this.sốLầnSáchĐượcMượnTheoThángToolStripMenuItem.Size = new System.Drawing.Size(419, 36);
//            this.sốLầnSáchĐượcMượnTheoThángToolStripMenuItem.Text = "Số lần sách được mượn theo tháng";
//            this.sốLầnSáchĐượcMượnTheoThángToolStripMenuItem.Click += new System.EventHandler(this.sốLầnSáchĐượcMượnTheoThángToolStripMenuItem_Click);
//            // 
//            // thoátToolStripMenuItem
//            // 
//            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
//            this.thoátToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
//            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(78, 32);
//            this.thoátToolStripMenuItem.Text = "Thoát";
//            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
//            // 
//            // FormMain
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.AutoSize = true;
//            this.ClientSize = new System.Drawing.Size(1324, 740);
//            this.Controls.Add(this.menuStripQlMS);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
//            this.IsMdiContainer = true;
//            this.MainMenuStrip = this.menuStripQlMS;
//            this.Name = "FormMain";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Quản lý mượn sách";
//            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
//            this.menuStripQlMS.ResumeLayout(false);
//            this.menuStripQlMS.PerformLayout();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.MenuStrip menuStripQlMS;
//        private System.Windows.Forms.ToolStripMenuItem phiếuMượnToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuMượnToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem quảnLýPhiếuMượnToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem quảnLýNgườiMượnToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem sốLầnSáchĐượcMượnTheoThángToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
//    }
//}