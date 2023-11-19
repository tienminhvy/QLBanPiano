using QLBanPiano.BUS;
using QLBanPiano.DTO;
using QLBanPiano.GUI.SubForm;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Numerics;
using System.Reflection;
using System.Windows.Forms;

namespace DoAn
{
    public partial class Product : Form
    {
        string projectDirectory = Directory.GetCurrentDirectory() + "..\\..\\..\\..\\"; // lấy dường dẫn tính tới folder QLBanPIano
        private PianoBUS pianoBUS = new PianoBUS();
        private ThuongHieuBUS thuongHieuBUS = new ThuongHieuBUS();


        private List<DoiTuong> danhSachDoiTuongPiano = new List<DoiTuong>();
        public Product()
        {
            InitializeComponent();
            LoadTrangThaiComponents();
            LoadDanhSachSanPham();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMaTimKiem.Text = string.Empty;
            txtTenTimKiem.Text = string.Empty;
            cbbGiaTimKiem.SelectedItem = null;
            cbbThuongHieuTimKiem.SelectedItem = null;
            ptbAnh.Image = null;
            btnNhapLai_Click(null, null);
            txtIDSP.Text = string.Empty;
            LoadDanhSachSanPham();
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
                MessageBox.Show("Chọn sản phẩm muốn xóa", "Thông báo");
                return;
            }
            int id = int.Parse(txtIDSP.Text.Trim());

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa khách hàng có mã là: " + id + " không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            if (pianoBUS.Xoa("Id=" + id))
            {
                MessageBox.Show("Thành công");
                LoadDanhSachSanPham();
                btnNhapLai_Click(null, null);
                txtIDSP.Text = string.Empty;
                ptbAnh.Image = null;
            }
            else
            {
                MessageBox.Show("Thất bại");
            }

        }

        public void LoadDanhSachSanPham()
        {
            DataTable danhSachSanPham = pianoBUS.LayToanBoDS();
            dgvSanPham.DataSource = null;
            dgvSanPham.Rows.Clear();
            dgvSanPham.DataSource = danhSachSanPham;

        }

        public void LoadTrangThaiComponents()
        {
            danhSachDoiTuongPiano.Clear();
            danhSachDoiTuongPiano = pianoBUS.LayDS("nhaccu.trangthai = 1");
            cbbThuongHieuSP.DataSource = thuongHieuBUS.LayDSTenThuongHieu();
            cbbThuongHieuTimKiem.DataSource = thuongHieuBUS.LayDSTenThuongHieu();
            cbbThuongHieuTimKiem.SelectedItem = null;
            cbbLoaiSP.SelectedIndex = 0;
            cbbGiaTimKiem.SelectedItem = null;
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
            if (txtMaTimKiem.Text.Trim().Length == 0 && txtTenTimKiem.Text.Trim().Length == 0 &&
                cbbGiaTimKiem.SelectedItem == null && cbbThuongHieuTimKiem.SelectedItem == null)
            {
                MessageBox.Show("Hãy nhập ít nhất một tiêu chí tìm kiếm", "Thông báo");
                return;
            }
            string maSanPham = txtMaTimKiem.Text;
            string tenSanPham = txtTenTimKiem.Text;
            string mucGiaSanPham = "";
            if (cbbGiaTimKiem.SelectedItem != null)
            {
                mucGiaSanPham = cbbGiaTimKiem.SelectedItem.ToString();
            }

            string thuongHieuSanPham = "";
            if (cbbThuongHieuTimKiem.SelectedItem != null)
            {
                thuongHieuSanPham = cbbThuongHieuTimKiem.SelectedItem.ToString();
            }

            DataTable list = pianoBUS.Loc(maSanPham, tenSanPham, mucGiaSanPham, thuongHieuSanPham);
            if (list.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào", "Thông báo");
            }
            dgvSanPham.DataSource = null;
            dgvSanPham.DataSource = list;
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvSanPham_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = dgvSanPham.SelectedRows[0].Index; // Lấy chỉ số của dòng được chọn đầu tiên nếu chọn nhiều dòng
            DataGridViewRow selectedRow = dgvSanPham.Rows[rowIndex]; // Lấy dòng được chọn
            string maDuocChon = selectedRow.Cells[0].Value.ToString();
            if (maDuocChon.Equals("")) return; // chưa chọn sản phẩm
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
            string imagelink = projectDirectory + "GUI\\ImageSanPham\\" + piano.HinhAnh;
            ptbAnh.Image = Image.FromFile(imagelink);
            cbbLoaiSP.SelectedItem = piano.Phanloai;
            cbbThuongHieuSP.SelectedItem = piano.ThuongHieu.Ten;
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            frmThemSanPham fThemSanPham = new frmThemSanPham();
            fThemSanPham.ShowDialog();
            LoadDanhSachSanPham();
            LoadTrangThaiComponents();
            btnNhapLai_Click(null, null);
            btnDatLai_Click(null, null);
            txtIDSP.Text = string.Empty;
            ptbAnh.Image = null;

        }

        private void txtMaTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; // cho phép nhập kí tự không dấu và số và dấu '_'

            if (!Char.IsDigit(ch) && !Char.IsLetter(ch) && ch != '_' && ch != ' ' && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtTenTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; // cho phép nhập kí tự không dấu và số và dấu '_'

            if (!Char.IsDigit(ch) && !Char.IsLetter(ch) && ch != '-' && ch != ' ' && ch != 8 && ch != '_')
            {
                e.Handled = true;
            }
        }

        private void txtMaSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; // cho phép nhập kí tự không dấu và số và dấu '_'

            if (!Char.IsDigit(ch) && !Char.IsLetter(ch) && ch != '_' && ch != ' ' && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtTenSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; // cho phép nhập kí tự không dấu và số và dấu '_'

            if (!Char.IsDigit(ch) && !Char.IsLetter(ch) && ch != '-' && ch != ' ' && ch != 8 && ch != '_')
            {
                e.Handled = true;
            }
        }

        private void txtGiaSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDacDiemSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; // cho phép nhập kí tự không dấu và số và dấu '_'

            if (!Char.IsDigit(ch) && !Char.IsLetter(ch) && ch != '-' && ch != ' ' && ch != 8 && ch != '_')
            {
                e.Handled = true;
            }
        }

        private void txtMoTaSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; // cho phép nhập kí tự không dấu và số và dấu '_'

            if (!Char.IsDigit(ch) && !Char.IsLetter(ch) && ch != '-' && ch != ' ' && ch != 8 && ch != '_')
            {
                e.Handled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtIDSP.Text.Length == 0)
            {
                MessageBox.Show("Chọn sản phẩm muốn sửa", "Thông báo");
                return;
            }
            try
            {
                if (DuThongTin())
                {
                    int id = int.Parse(txtIDSP.Text);
                    string ma = txtMaSP.Text.Trim();
                    string ten = txtTenSP.Text.Trim();
                    long gia = long.Parse(txtGiaSP.Text.Trim());
                    string loai = cbbLoaiSP.SelectedItem.ToString();
                    string thuongHieu = cbbThuongHieuSP.SelectedItem.ToString();
                    string moTa = txtMoTaSP.Text.Trim();
                    string dacDiem = txtDacDiemSP.Text.Trim();
                    string hinhAnh = id + ".png";
                    if (!pianoBUS.ThongTinSanPhamChinhXac(id, ma, ten, gia, hinhAnh, loai, thuongHieu, dacDiem, moTa))
                    {
                        return;
                    }
                    if (!pianoBUS.ThongTinSanPhamThayDoi(id, ma, ten, gia, hinhAnh, loai, thuongHieu, dacDiem, moTa))
                    {
                        MessageBox.Show("Sản phẩm không thay đổi gì", "Thông báo");
                        return;
                    }

                    string idThuongHieu = thuongHieuBUS.GiaTriTruong("id", "ten = '" + thuongHieu + "'").ToString();
                    string[] dsTruong = { ma, ten, dacDiem, moTa, gia.ToString(), hinhAnh, loai, idThuongHieu, id.ToString() };

                    if (pianoBUS.Sua(dsTruong))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo");
                        LoadDanhSachSanPham();
                        btnNhapLai_Click(null, null);
                        txtIDSP.Text = string.Empty;
                        danhSachDoiTuongPiano.Clear();
                        danhSachDoiTuongPiano = pianoBUS.LayDS("nhaccu.trangthai = 1");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại, vui lòng thực hiện đúng thao tác", "Thông báo");
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi không mong muốn xảy ra, vui lòng thực hiện đúng thao tác", "Báo lỗi");
                return;
            }
        }

        public bool DuThongTin()
        {
            if (txtMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng điền mã sản phẩm", "Thông báo");
                txtMaSP.Focus();
                return false;
            }
            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng điền tên sản phẩm", "Thông báo");
                txtTenSP.Focus();
                return false;
            }
            if (txtGiaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng điền giá sản phẩm", "Thông báo");
                txtGiaSP.Focus();
                return false;
            }
            if (txtDacDiemSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng điền đặc điểm sản phẩm", "Thông báo");
                txtDacDiemSP.Focus();
                return false;
            }
            if (txtMoTaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng điền mô tả sản phẩm", "Thông báo");
                txtMoTaSP.Focus();
                return false;
            }
            if (ptbAnh.Image == null)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh sản phẩm, bấm vào khung ảnh", "Thông báo");
                ptbAnh.Focus();
                return false;
            }
            return true;
        }

        private void ptbAnh_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtIDSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chọn sản phẩm muốn sửa", "Thông báo");
                return;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.gif;*.bmp;*.png;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ptbAnh.Image = Image.FromFile(openFileDialog.FileName);
                string destinationPath = projectDirectory + "GUI\\ImageSanPham\\" + txtIDSP.Text + ".png";
                File.Copy(openFileDialog.FileName, destinationPath, true); //copy ảnh đã chọn vào folder lưu ảnh sản phẩm
            }
        }
    }


}