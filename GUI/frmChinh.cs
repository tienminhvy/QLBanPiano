using QLBanPiano;
using QLBanPiano.GUI;
using QLBanPiano.GUI.SubForm;
using System.Windows.Forms;

namespace QLBanPiano
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
            innerNewForm(new frmThongKe());
        }
        private frmDangNhap fLogin;
        public static string username;
        public static List<string> dsQuyen;
        public frmChinh(frmDangNhap fLogin)
        {
            this.fLogin = fLogin;
            InitializeComponent();
            innerNewForm(new frmThongKe());
            fLogin.Hide();
            Init();
            PhanQuyen();
        }
        private void PhanQuyen()
        {
            bool isQL = false;
            foreach (string quyen in dsQuyen)
            {
                if (quyen == "banHang")
                    banHangtoolStripButton.Visible = true;
                if (quyen == "quanLyNhapHang")
                {
                    phieuNhapToolStripMenuItem.Visible = true;
                    isQL = true;
                }
                if (quyen == "quanLyHoaDon")
                {
                    hoaDonToolStripMenuItem.Visible = true;
                    isQL = true;
                }
                if (quyen == "quanLyNhacCu")
                {
                    pianoToolStripMenuItem.Visible = true;
                    isQL = true;
                }
                if (quyen == "quanLyKhachHang")
                {
                    khachHangToolStripMenuItem.Visible = true;
                    isQL = true;
                }
                if (quyen == "quanLyNhanVien")
                {
                    nhanVienToolStripMenuItem.Visible = true;
                    isQL = true;
                }
                if (quyen == "nhapXuat")
                {

                }
            }
            if (isQL)
                dstoolStripDropDownButton.Visible = true;
        }
        private void Init()
        {
            pianoToolStripMenuItem.Visible = false;
            khachHangToolStripMenuItem.Visible = false;
            nhanVienToolStripMenuItem.Visible = false;
            phieuNhapToolStripMenuItem.Visible = false;
            hoaDonToolStripMenuItem.Visible = false;
            vaiTroToolStripMenuItem.Visible = false;
            dstoolStripDropDownButton.Visible = false;
            banHangtoolStripButton.Visible = false;
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            frmGioiThieu about = new frmGioiThieu();
            about.Show();
        }

        private void btnTaoMoi_ButtonClick(object sender, EventArgs e)
        {

        }

        private void innerNewForm(Form f)
        {
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;

            foreach (Form cF in mainPanel.Controls)
            {
                cF.Dispose();
            }
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(f);
            f.Show();
            f.Dock = DockStyle.Fill;
            this.Size = f.Size;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            innerNewForm(new frmBanHang());
        }

        private void pianoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            innerNewForm(new frmQLSanPham());
        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            innerNewForm(new frmQLKhachHang());
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            innerNewForm(new frmQLNhanVien());
        }

        private void phieuNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            innerNewForm(new frmQLPhieuNhap());
        }

        private void hoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            innerNewForm(new frmQLHoaDon());
        }

        private void vaiTroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            innerNewForm(new frmPhanQuyen());
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {

        }

        private void frmChinh_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            fLogin.Show();
            Dispose();
        }
    }
}