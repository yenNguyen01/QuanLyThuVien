using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;

namespace DeTai3_QuanLyMuonSach
{
    public partial class FormMain : Form
    {
        private string tenDN;
        private int quyen;
        private IconButton currentBtn;
        private Panel leffBorderBtn;
        public string TenDN
        {
            set { tenDN = value; }
        }

        public int Quyen
        {
            set { quyen = value; }
        }
        public FormMain()
        {
            InitializeComponent();
            leffBorderBtn = new Panel();
            leffBorderBtn.Size = new Size(7, 45);
            panelSideMenu.Controls.Add(leffBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
       
       
        #region ColorButtonWhenClick
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
        }
        private void ActiveButton(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(11, 7, 17);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leffBorderBtn.BackColor = color;
                leffBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leffBorderBtn.Visible = true;
                leffBorderBtn.BringToFront();
                //current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(11, 7, 17);
                currentBtn.ForeColor = Color.DarkGray;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.DarkGray;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        #endregion
        private void customizeDesing()
        {
            panelQLPhieu.Visible = false;
       

        }
        private void hideSubMenu()
        {
            if (panelQLPhieu.Visible == true)
                panelQLPhieu.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        //private void btn11_Click(object sender, EventArgs e)
        //{
        //    openChildForm(new Form2());
        //    hideSubMenu();
        //}
 
        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leffBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Maroon;
            lblTitleChildForm.Text = "Home";
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitltBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

     

        private void btnQLPM_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQLPhieu);
            ActiveButton(sender, RGBColor.color1);
            openChildForm(new FormQuanLyPhieuMuon());
            //FormQuanLyPhieuMuon f = new FormQuanLyPhieuMuon();
            //f.MdiParent = this;
            //f.StartPosition = FormStartPosition.CenterScreen;
            //f.Show();
        }

        private void btnTaoPhieuMuon_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormTaoPhieuMuon());
            //FormTaoPhieuMuon f = new FormTaoPhieuMuon();
            //f.MdiParent = this;
            //f.StartPosition = FormStartPosition.CenterScreen;
            //f.TenDN = tenDN;
            //f.Show();
        }

        private void btnQLNguoiMuon_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color2);
            openChildForm(new FormQuanLyNguoiMuon());
            //FormQuanLyNguoiMuon f = new FormQuanLyNguoiMuon();
            //f.MdiParent = this;
            //f.StartPosition = FormStartPosition.CenterScreen;
            //f.Show();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color3);
            if (quyen == 1)
            {
                openChildForm( new FormQuanLyNhanVien());
                //FormQuanLyNhanVien f = new FormQuanLyNhanVien();
                //f.MdiParent = this;
                //f.StartPosition = FormStartPosition.CenterScreen;
                //f.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền để vào chức năng này.", "Thông báo");
            }
        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color4);
            openChildForm(new FormQuanLySach());
            //FormQuanLySach f = new FormQuanLySach();
            //f.MdiParent = this;
            //f.StartPosition = FormStartPosition.CenterScreen;
            //f.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color1);
            if (quyen == 1)
            {
                openChildForm(new FormTKSachMuonTheoThang());
                //FormTKSachMuonTheoThang f = new FormTKSachMuonTheoThang();
                //f.MdiParent = this;
                //f.StartPosition = FormStartPosition.CenterScreen;
                //f.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền để vào chức năng này.", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color2);
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi hệ thống?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                Application.Exit();
        }
    }
}
