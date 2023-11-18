using QLBanPiano.BUS;
using QLBanPiano.DTO;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace DoAn
{
    public partial class Product : Form
    {
        string projectDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private PianoBUS pianoBUS = new PianoBUS();

        private List<DoiTuong> danhSachDoiTuongPiano = new List<DoiTuong>();
        public Product()
        {
            InitializeComponent();
            danhSachDoiTuongPiano.Clear();
            danhSachDoiTuongPiano = pianoBUS.LayDS("nhaccu.trangthai = 1");
            LoadDanhSachSanPham();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMaTimKiem.Text = string.Empty;
            txtTenTimKiem.Text = string.Empty;
            cbGiaTimKiem.SelectedIndex = 0;
      //      cbThuongHieuTimKiem.SelectedIndex = 0;
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
                MessageBox.Show("chọn sản phẩm muốn xóa");
                return;
            }
            int id = int.Parse(txtIDSP.Text.Trim());

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa khách hàng có mã là:" + id + " không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            if (pianoBUS.Xoa("Ma=" + id))
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }

        }

        public void LoadDanhSachSanPham()
        {
            DataTable danhSachSanPham = pianoBUS.LayToanBoDS();
            dgvSanPham.Rows.Clear();
            dgvSanPham.DataSource = danhSachSanPham;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMaTimKiem_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txtTenTimKiem_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void cbGiaTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void cbThuongHieuTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvSanPham_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = dgvSanPham.SelectedRows[0].Index; // Lấy chỉ số của dòng được chọn đầu tiên nếu chọn nhiều dòng
            DataGridViewRow selectedRow = dgvSanPham.Rows[rowIndex]; // Lấy dòng được chọn
            var maDuocChon = selectedRow.Cells[0].Value;
            Piano SanPhamDuocChon = new Piano();
            foreach (DoiTuong sanpham in danhSachDoiTuongPiano)
            {
                Piano piano = new Piano();
                piano = (Piano)sanpham;
                if (piano.Ma.Equals(maDuocChon))
                {
                    SanPhamDuocChon = piano; // từ mã sản phẩm của dòng được chọn lấy ra sản phẩm piano tương ứng
                }
            }
            FillThongTinSanPhamDuocChon(SanPhamDuocChon);

        }

        public void FillThongTinSanPhamDuocChon(Piano piano)
        {
            txtIDSP.Text = piano.Id.ToString();
            txtMaSP.Text = piano.Ma.ToString();
            txtTenSP.Text = piano.Ten.ToString();
            txtGiaSP.Text = piano.Gia.ToString();
            txtDacDiemSP.Text = piano.DacDiemNoiBat.ToString();
            txtMoTaSP.Text = piano.MoTaChiTiet.ToString();
            string imagelink =projectDirectory+ "\\GUI\\ImageSanPham\\example.png";
            ptbAnh.Image = Image.FromFile(imagelink);

        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            
        }
    }


}