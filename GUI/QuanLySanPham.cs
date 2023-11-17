namespace DoAn
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtIDTimKiem.Text = string.Empty;
            txtMaTimKiem.Text = string.Empty;
            txtTenTimKiem.Text = string.Empty;
            cbGiaTimKiem.SelectedIndex = 0;
            cbThuongHieuTimKiem.SelectedIndex = 0;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            txtGiaSP.Text = string.Empty;
            txtMoTaSP.Text = string.Empty;
            txtDacDiemSP.Text = string.Empty;
            cbbLoaiSP.SelectedIndex = 0;
            cbbThuongHieuSP.SelectedIndex = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtIDSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("chon san pham muon xoa");
                return;
            }
            int id = int.Parse(txtIDSP.Text.Trim());

            if (XoaSanPham(id))
            {
                MessageBox.Show("Thanh cong");

            }
            else
            {
                MessageBox.Show("That bai");
            }

        }

        public bool XoaSanPham(int id)
        {   

            // ---------------------------------Code xoa san pham ---------------------------------------------
            return true;
        }
    }

    
}