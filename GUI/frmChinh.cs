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
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            innerNewForm(new frmBanHang());
        }

        private void pianoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            innerNewForm(new frmQLSanPham());
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}