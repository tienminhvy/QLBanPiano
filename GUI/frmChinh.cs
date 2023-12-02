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
        public static string nhanvien_id;
        public static List<string> dsQuyen;
        public frmChinh(frmDangNhap fLogin)
        {
            this.fLogin = fLogin;
            InitializeComponent();
            foreach (string quyen in dsQuyen)
            {
                if (quyen == "thongKe")
                {
                    innerNewForm(new frmThongKe());
                    break;
                }

                else
                {
                    innerNewForm(new frmBanHang());
                    break;
                }
            }
            fLogin.Hide();
            // Init();
            PhanQuyen();
        }
        private void PhanQuyen()
        {
            int count = 0;
            bool isQL = false;
            foreach (string quyen in dsQuyen)
            {
                if (quyen == "banHang")
                {
                    banHangtoolStripButton.Visible = true;
                    count++;
                }
                if (quyen == "quanLyNhapHang")
                {
                    phieuNhapToolStripMenuItem.Visible = true;
                    isQL = true;
                    count++;
                }
                if (quyen == "quanLyHoaDon")
                {
                    hoaDonToolStripMenuItem.Visible = true;
                    isQL = true;
                    count++;
                }
                if (quyen == "quanLyNhacCu")
                {
                    pianoToolStripMenuItem.Visible = true;
                    isQL = true;
                    count++;
                }
                if (quyen == "quanLyKhachHang")
                {
                    khachHangToolStripMenuItem.Visible = true;
                    isQL = true;
                    count++;
                }
                if (quyen == "quanLyNhanVien")
                {
                    nhanVienToolStripMenuItem.Visible = true;
                    isQL = true;
                    count++;
                }
                if (quyen == "thongKe")
                {
                    thongKetoolStripButton.Visible = true;
                    count++;
                }
                if (quyen == "nhapXuat")
                {
                    count++;
                }
            }
            if (isQL)
                dstoolStripDropDownButton.Visible = true;
            if (count == 8)
            {
                vaiTroToolStripMenuItem.Visible = true;
            }
        }
        private void Init()
        {
            KeyPress += KeyPressEvent;
            lblThongTinDangNhap.Text += username + " | ID nhân viên: " + nhanvien_id;
            pianoToolStripMenuItem.Visible = false;
            khachHangToolStripMenuItem.Visible = false;
            nhanVienToolStripMenuItem.Visible = false;
            phieuNhapToolStripMenuItem.Visible = false;
            hoaDonToolStripMenuItem.Visible = false;
            vaiTroToolStripMenuItem.Visible = false;
            banHangtoolStripButton.Visible = false;
            thongKetoolStripButton.Visible = false;
            // 8 quyền cơ bản
            dstoolStripDropDownButton.Visible = false;
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            frmGioiThieu about = new frmGioiThieu();
            about.Show();
            about.KeyPress += KeyPressEvent;
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

        private void dangXuatBtn_Click(object sender, EventArgs e)
        {
            frmChinh_FormClosing(sender, new FormClosingEventArgs(CloseReason.UserClosing, false));
        }

        private void thongKetoolStripButton_Click(object sender, EventArgs e)
        {

        }
        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                ((Form)sender).Dispose();
            }
        }
        private void ttCaNhantoolStripButton_Click(object sender, EventArgs e)
        {
            frmChinhSuaThongTin frm = new frmChinhSuaThongTin();
            frm.ShowDialog();
            frm.KeyPress += KeyPressEvent;
        }

        private void theoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            innerNewForm(new frmThongKe());
        }

        private void theoThuongHieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            innerNewForm(new frmThongKeThuongHieu());
        }

        private void thuongHieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            innerNewForm(new frmQLThuongHieu());
        }
    }
}