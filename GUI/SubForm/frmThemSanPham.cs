using QLBanPiano.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanPiano.GUI.SubForm
{
    public partial class frmThemSanPham : Form
    {
        string projectDirectory = Directory.GetCurrentDirectory() + "..\\..\\..\\..\\"; // lấy dường dẫn tính tới folder QLBanPIano
        PianoBUS pianoBUS = new PianoBUS();
        ThuongHieuBUS thuongHieuBUS = new ThuongHieuBUS();
        public frmThemSanPham()
        {
            InitializeComponent();
            LoadTrangThaiComponents();
        }

        public void LoadTrangThaiComponents()
        {
            txtID.Text = (pianoBUS.SoLuong("1=1") + 1).ToString();
            cbbThuongHieu.DataSource = thuongHieuBUS.LayDSTenThuongHieu();
            cbbThuongHieu.SelectedIndex = 0;
            cbbLoai.SelectedIndex = 0;
            ptbAnh.Image = null;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMa.Text = string.Empty;
            txtTen.Text = string.Empty;
            txtGia.Text = string.Empty;
            txtMoTa.Text = string.Empty;
            txtDacDiem.Text = string.Empty;
            cbbLoai.SelectedIndex = 0;
            cbbThuongHieu.SelectedIndex = 0;
        }

        private void txtMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; // cho phép nhập kí tự không dấu và số và dấu '_'

            if (!Char.IsDigit(ch) && !Char.IsLetter(ch) && ch != '_' && ch != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; // cho phép nhập kí tự không dấu và số và dấu '_'

            if (!Char.IsDigit(ch) && !Char.IsLetter(ch) && ch != '-' && ch != ' ' && !char.IsControl(e.KeyChar) && ch != '_')
            {
                e.Handled = true;
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDacDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; // cho phép nhập kí tự không dấu và số và dấu '_'

            if (!Char.IsDigit(ch) && !Char.IsLetter(ch) && ch != '-' && ch != ' ' && !char.IsControl(ch) && ch != '_')
            {
                e.Handled = true;
            }
        }

        private void txtMoTa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; // cho phép nhập kí tự không dấu và số và dấu '_'

            if (!Char.IsDigit(ch) && !Char.IsLetter(ch) && ch != '-' && ch != ' ' && !char.IsControl(ch) && ch != '_')
            {
                e.Handled = true;
            }
        }

        private void ptbAnh_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.gif;*.bmp;*.png;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ptbAnh.Image = Image.FromFile(openFileDialog.FileName);
                string destinationPath = projectDirectory + "GUI\\ImageSanPham\\" + txtID.Text + ".png";
                File.Copy(openFileDialog.FileName, destinationPath, true); //copy ảnh đã chọn vào folder lưu ảnh sản phẩm
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new Msg("Bạn có muốn thoát không?").Res;
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (DuThongTin())
                {
                    int id = int.Parse(txtID.Text);
                    string ma = txtMa.Text.Trim();
                    string ten = txtTen.Text.Trim();
                    long gia = long.Parse(txtGia.Text.Trim());
                    string loai = cbbLoai.SelectedItem.ToString();
                    string thuongHieu = cbbThuongHieu.SelectedItem.ToString();
                    string moTa = txtMoTa.Text.Trim();
                    string dacDiem = txtDacDiem.Text.Trim();
                    string hinhAnh = id + ".png";
                    if (!pianoBUS.ThongTinSanPhamChinhXac(id, ma, ten, gia, hinhAnh, loai, thuongHieu, dacDiem, moTa))
                    {
                        return;
                    }

                    string idThuongHieu = thuongHieuBUS.GiaTriTruong("id", "ten = '" + thuongHieu + "'").ToString();
                    string[] dsTruong = { ma, ten, dacDiem, moTa, gia.ToString(), hinhAnh, loai, idThuongHieu };

                    if (pianoBUS.Them(dsTruong))
                    {
                        new Msg("Thêm thành công");
                        btnNhapLai_Click(null, null);
                        LoadTrangThaiComponents();
                    }
                    else
                    {
                        new Msg("Thêm thất bại, vui lòng thực hiện đúng thao tác", "err");
                    }


                }
            }
            catch (Exception ex)
            {
                new Msg("Có lỗi không mong muốn xảy ra, vui lòng thực hiện đúng thao tác", "err");
                return;
            }
        }

        public bool DuThongTin()
        {
            if (txtMa.Text.Trim().Length == 0)
            {
                new Msg("Vui lòng điền mã sản phẩm", "err");
                txtMa.Focus();
                return false;
            }
            if (txtTen.Text.Trim().Length == 0)
            {
                new Msg("Vui lòng điền tên sản phẩm", "err");
                txtTen.Focus();
                return false;
            }
            if (txtGia.Text.Trim().Length == 0)
            {
                new Msg("Vui lòng điền giá sản phẩm", "err");
                txtGia.Focus();
                return false;
            }
            if (txtDacDiem.Text.Trim().Length == 0)
            {
                new Msg("Vui lòng điền đặc điểm sản phẩm", "err");
                txtDacDiem.Focus();
                return false;
            }
            if (txtMoTa.Text.Trim().Length == 0)
            {
                new Msg("Vui lòng điền mô tả sản phẩm", "Thông báo");
                txtMoTa.Focus();
                return false;
            }
            if (ptbAnh.Image == null)
            {
                new Msg("Vui lòng chọn hình ảnh sản phẩm, bấm vào khung ảnh", "err");
                ptbAnh.Focus();
                return false;
            }
            return true;
        }

        private void frmThemSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
