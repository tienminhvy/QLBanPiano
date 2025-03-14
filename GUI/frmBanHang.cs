﻿using QLBanPiano.BUS;
using QLBanPiano.DTO;
using QLBanPiano.GUI;
using QLBanPiano.GUI.SubForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLBanPiano
{
    public partial class frmBanHang : Form
    {
        string projectDirectory = Directory.GetCurrentDirectory() + "..\\..\\..\\..\\"; // lấy dường dẫn tính tới folder QLBanPIano

        KhachHangBUS khachHangBUS = new KhachHangBUS();
        KhachHang khachHangDuocChon = new KhachHang();
        PianoBUS pianoBUS = new PianoBUS();
        HoaDonBUS HoaDonBUS = new HoaDonBUS();
        ChiTietHoaDonBUS chiTietHoaDonBUS = new ChiTietHoaDonBUS();

        List<DoiTuong> danhSachSanPham;
        List<DoiTuong> danhSachKhachHang;
        List<SanPhamDuocChon> DSSanPhamDaChon = new List<SanPhamDuocChon>();

        public frmBanHang()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            cbbTieuChiSanPham.SelectedIndex = 0;
            cbbTieuChiKhachHang.SelectedIndex = 0;
            danhSachSanPham = pianoBUS.LayDS("1=1");
            danhSachKhachHang = khachHangBUS.LayDS("1=1");
            LoadDSSanPham(danhSachSanPham);
            LoadDSKhachHang(danhSachKhachHang);
        }

        public void LoadLaiComponent()
        {
            cbbTieuChiSanPham.SelectedIndex = 0;
            cbbTieuChiKhachHang.SelectedIndex = 0;
            danhSachSanPham = pianoBUS.LayDS("1=1");
            danhSachKhachHang = khachHangBUS.LayDS("1=1");
            DSSanPhamDaChon.Clear();
            LoadDSSanPham(danhSachSanPham);
            LoadDSKhachHang(danhSachKhachHang);
            LoadDSSanPhamDaChon();

            txtTimKiemKhachHang.Text = "";
            txtTimKiemSanPham.Text = "";
            fillThongTinKhachHang(null);
            fillThongTinSanPham(null);

            txtTongTienNhan.Text = "";
            txtTienThoiLai.Text = "";

        }
        public void LoadDSSanPham(List<DoiTuong> danhSachSanPham)
        {
            lvSanPham.Items.Clear();

            foreach (DoiTuong dt in danhSachSanPham)
            {
                QLBanPiano.DTO.Piano piano = (QLBanPiano.DTO.Piano)dt;
                ListViewItem listViewItem = new ListViewItem(new String[]
                {
                    piano.Id.ToString(),
                    piano.Ma,
                    piano.Ten,
                    piano.ThuongHieu.Ten,
                    piano.Phanloai,
                    piano.Gia.ToString(),
                });
                lvSanPham.Items.Add(listViewItem);
            }
        }

        public void LoadDSKhachHang(List<DoiTuong> danhSachKhachHang)
        {
            lvKhachHang.Items.Clear();
            foreach (DoiTuong dt in danhSachKhachHang)
            {
                KhachHang khachHang = (KhachHang)dt;
                ListViewItem listViewItem = new ListViewItem(new String[]
                {
                    khachHang.Id.ToString(),
                    khachHang.HoLot,
                    khachHang.Ten,
                    khachHang.SoDienThoai
                });
                lvKhachHang.Items.Add(listViewItem);
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTimKiemKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if (cbbTieuChiKhachHang.SelectedItem.ToString().Equals("ID") || cbbTieuChiKhachHang.SelectedItem.ToString().Equals("SDT"))
                {
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true; // khi tiêu chí là ID với SDT thì chỉ nhập số
                    }
                }
                else
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                    {
                        e.Handled = true; // Nếu không, hủy bỏ sự kiện
                    }
                }
            }
            catch (Exception ex)
            {
                new Msg(ex.Message, "err");
            }

        }

        private void txtTimKiemSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (cbbTieuChiSanPham.SelectedItem.ToString().Equals("ID"))
                {
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true; // khi tiêu chí là ID với SDT thì chỉ nhập số
                    }
                }
                else
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '_' && e.KeyChar != '-')
                    {
                        e.Handled = true; // Nếu không, hủy bỏ sự kiện
                    }
                }
            }
            catch (Exception ex)
            {
                new Msg(ex.Message, "err");
            }


        }

        public void fillThongTinKhachHang(KhachHang khachHang)
        {
            if (khachHang != null)
            {
                txtIDKH.Text = khachHang.Id.ToString();
                txtSDTKH.Text = khachHang.SoDienThoai;
                txtHoLotKH.Text = khachHang.HoLot;
                txtTenKH.Text = khachHang.Ten;
                txtDiaChiKH.Text = khachHang.DiaChi;
            }
            else
            {
                txtIDKH.Text = "";
                txtSDTKH.Text = "";
                txtHoLotKH.Text = "";
                txtTenKH.Text = "";
                txtDiaChiKH.Text = "";
            }

        }

        public void fillThongTinSanPham(QLBanPiano.DTO.Piano piano)
        {
            if (piano != null)
            {
                txtIDSP.Text = piano.Id.ToString();
                txtMaSP.Text = piano.Ma;
                txtTenSP.Text = piano.Ten;
                txtThuongHieuSP.Text = piano.ThuongHieu.Ten;
                txtMoTaSP.Text = piano.MoTaChiTiet;
                txtDacDiemSP.Text = piano.DacDiemNoiBat;
                txtGiaSP.Text = piano.Gia.ToString();
                txtSoLuongCon.Text = piano.SoLuong.ToString();
                txtLoaiSP.Text = piano.Phanloai;
                string imagelink = projectDirectory + "GUI\\ImageSanPham\\" + piano.HinhAnh;
                ptbAnh.Image = Image.FromFile(imagelink);
                cbbSoLuongMua.Items.Clear();
                cbbSoLuongMua.Items.Add("1");
                for (int i = 2; i <= piano.SoLuong; i++)
                {
                    cbbSoLuongMua.Items.Add(i.ToString());
                }
                cbbSoLuongMua.SelectedIndex = 0;
            }
            else
            {
                txtIDSP.Text = "";
                txtMaSP.Text = "";
                txtTenSP.Text = "";
                txtThuongHieuSP.Text = "";
                txtMoTaSP.Text = "";
                txtDacDiemSP.Text = "";
                txtGiaSP.Text = "";
                txtSoLuongCon.Text = "";
                txtLoaiSP.Text = "";
                ptbAnh.Image = null;
                cbbSoLuongMua.Items.Clear();
            }

        }

        public void LoadDSSanPhamDaChon()
        {
            lvSanPhamDaChon.Items.Clear();
            long tongTien = 0;
            int tongSanPham = 0;
            if (DSSanPhamDaChon != null)
            {
                foreach (SanPhamDuocChon sp in DSSanPhamDaChon)
                {
                    QLBanPiano.DTO.Piano piano = (QLBanPiano.DTO.Piano)pianoBUS.LayDS("piano.id=" + sp.IdSanPham)[0];
                    tongSanPham += sp.SoLuong;
                    tongTien += piano.Gia * sp.SoLuong;
                    ListViewItem listViewItem = new ListViewItem(new String[]
                    {
                    piano.Id.ToString(),
                    piano.Ten,
                    piano.Gia.ToString(),
                    sp.SoLuong.ToString()
                    });
                    lvSanPhamDaChon.Items.Add(listViewItem);
                }
            }

            txtTongSoSP.Text = tongSanPham.ToString();
            txtTongTien.Text = tongTien.ToString();
        }


        private void txtTongTienNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTongTienNhan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTongTienNhan.Text.Length == 0) { return; }
                long tongTien = long.Parse(txtTongTien.Text);
                long tienNhan = long.Parse(txtTongTienNhan.Text);
                if (tienNhan > tongTien)
                {
                    long tienThoi = tienNhan - tongTien;
                    txtTienThoiLai.Text = tienThoi.ToString();
                }
                else
                {
                    txtTienThoiLai.Text = "0";
                }
            }
            catch (Exception ex)
            {
                new Msg("Có lỗi xảy ra, vui lòng thực hiện đúng thao tác", "err");
            }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            frmThemKhachHang frmKhachHang = new frmThemKhachHang(this);
            frmKhachHang.ShowDialog();
            danhSachKhachHang = khachHangBUS.LayDS("1=1");
            LoadDSKhachHang(danhSachKhachHang);
        }

        /*    private void btnChonKhachHang_Click(object sender, EventArgs e)
            {
                if (txtIDKH.Text.Length == 0)
                {
                    new Msg("Vui lòng chọn khách hàng trong danh sách trước khi khóa", "Thông bá0");
                    return;
                }
            }*/

        private void btnChonSanPham_Click(object sender, EventArgs e)
        {
            if (txtIDSP.Text.Length == 0)
            {
                new Msg("Vui lòng chọn sản phẩm muốn mua trong danh sách trước khi khóa", "err");
                return;
            }

            string idSanPham = txtIDSP.Text;
            int soLuong = int.Parse(cbbSoLuongMua.Text);
            int soLuongCon = int.Parse(txtSoLuongCon.Text);
            if (soLuong > soLuongCon)
            {
                new Msg("Số lượng sản phẩm muốn mua không còn đủ", "err");
                return;
            }

            foreach (SanPhamDuocChon sp in DSSanPhamDaChon)
            {
                if (sp.IdSanPham.Equals(idSanPham))
                {
                    sp.SoLuong = soLuong;
                    return;
                }
            }
            SanPhamDuocChon sanPhamDuocChon = new SanPhamDuocChon(idSanPham, soLuong);
            DSSanPhamDaChon.Add(sanPhamDuocChon);
            LoadDSSanPhamDaChon();
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                string idSanPhamDuocChon = lvSanPham.SelectedItems[0].SubItems[0].Text;
                QLBanPiano.DTO.Piano piano = (QLBanPiano.DTO.Piano)pianoBUS.LayDS("piano.id = " + idSanPhamDuocChon)[0];
                fillThongTinSanPham(piano);
            }

        }

        private void lvKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKhachHang.SelectedItems.Count > 0)
            {
                string idKhachHangDuocChon = lvKhachHang.SelectedItems[0].SubItems[0].Text;
                KhachHang khachHang = (KhachHang)khachHangBUS.LayDS("id = " + idKhachHangDuocChon)[0];
                fillThongTinKhachHang(khachHang);
            }
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTongTienNhan.Text.Length == 0) { return; }
                long tongTien = long.Parse(txtTongTien.Text);
                long tienNhan = long.Parse(txtTongTienNhan.Text);
                if (tienNhan > tongTien)
                {
                    long tienThoi = tienNhan - tongTien;
                    txtTienThoiLai.Text = tienThoi.ToString();
                }
                else
                {
                    txtTienThoiLai.Text = "0";
                }
            }
            catch (Exception ex)
            {
                new Msg("Có lỗi xảy ra, vui lòng thực hiện đúng thao tác", "err");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSanPhamDaChon.SelectedItems.Count <= 0)
            {
                new Msg("Chọn sản phẩm muốn xóa khỏi danh sách đã chọn", "err");
                return;
            }
            string idDuocChon = lvSanPhamDaChon.SelectedItems[0].SubItems[0].Text;
            SanPhamDuocChon sanPhamDuocChon = new SanPhamDuocChon();
            foreach (SanPhamDuocChon sanPham in DSSanPhamDaChon)
            {
                if (sanPham.IdSanPham.Equals(idDuocChon))
                {
                    sanPhamDuocChon = sanPham; // không xóa trực tiếp mà đặt biến phụ để không bị đổi danh sách đang duyệt
                }
            }
            if (DSSanPhamDaChon.Contains(sanPhamDuocChon))
            {
                DSSanPhamDaChon.Remove(sanPhamDuocChon);
                LoadDSSanPhamDaChon();
            }

        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new Msg("Bạn có muốn xóa tất cả sản phẩm đã chọn không?", "warn").Res;
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            DSSanPhamDaChon.Clear();
            LoadDSSanPhamDaChon();
        }

        private void btnTimKhachHang_Click(object sender, EventArgs e)
        {
            string tieuChi = cbbTieuChiKhachHang.SelectedItem.ToString();
            string giaTri = txtTimKiemKhachHang.Text.Trim();
            if (giaTri == string.Empty)
            {
                new Msg("Vui lòng nhập thông tin tìm kiếm!", "err");
                return;
            }
            List<DoiTuong> DSKetQuaTimKiem = khachHangBUS.TimKiem(tieuChi, giaTri);
            LoadDSKhachHang(DSKetQuaTimKiem);
        }

        private void btnTimSanPham_Click(object sender, EventArgs e)
        {
            string tieuChi = cbbTieuChiSanPham.SelectedItem.ToString();
            string giaTri = txtTimKiemSanPham.Text.Trim();
            if (giaTri == string.Empty)
            {
                new Msg("Vui lòng nhập thông tin tìm kiếm!", "err");
                return;
            }
            List<DoiTuong> DSKetQuaTimKiem = pianoBUS.TimKiem(tieuChi, giaTri);
            LoadDSSanPham(DSKetQuaTimKiem);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtIDKH.Text.Length == 0)
            {
                new Msg("Chưa chọn khách hàng", "err");
                return;
            }
            if (DSSanPhamDaChon.Count == 0)
            {
                new Msg("Chưa chọn sản phẩm", "err");
                return;
            }
            try
            {
                if (txtTongTienNhan.Text.Length == 0)
                {
                    new Msg("Nhập số tiền nhận vào", "err");
                    txtTongTienNhan.Focus();
                    return;
                }
                long tongTien = long.Parse(txtTongTien.Text);
                long tienNhan = long.Parse(txtTongTienNhan.Text);
                if (tienNhan < tongTien)
                {
                    new Msg("Tiền nhận chưa đủ, vui lòng nhập lại", "err");
                    txtTongTienNhan.Focus();
                    return;
                }

                DateTime now = DateTime.Now;
                string strNow = now.ToString("yyyy-MM-dd HH:mm:ss tt");
                string nhanVien_id = frmDangNhap.nhanVien_id;
                string khachHang_id = txtIDKH.Text;
                string[] dsTruongHoaDon = { strNow, nhanVien_id, khachHang_id };
                int hoaDon_id = HoaDonBUS.TraVeID(dsTruongHoaDon);
                if (hoaDon_id == -1)
                {
                    new Msg("Tạo hóa đơn thất bại, vui lòng thực hiện lại ", "err");
                    return;
                }
                foreach (SanPhamDuocChon sanPham in DSSanPhamDaChon)
                {
                    QLBanPiano.DTO.Piano piano = (QLBanPiano.DTO.Piano)pianoBUS.LayDS("piano.id = " + sanPham.IdSanPham)[0];
                    string[] dsTruongChiTietHD = { sanPham.IdSanPham, hoaDon_id.ToString(), piano.Gia.ToString(), sanPham.SoLuong.ToString() };

                    if (!chiTietHoaDonBUS.Them(dsTruongChiTietHD))
                    {
                        new Msg("Tạo chi tiết hóa đơn thất bại, vui lòng thực hiện lại ", "err");
                        return;
                    }
                    pianoBUS.SuaSoLuong(int.Parse(sanPham.IdSanPham), sanPham.SoLuong);
                }

                new Msg("Thanh toán thành công");

                frmChiTietHoaDon f = new(hoaDon_id);
                f.ShowDialog();

                LoadLaiComponent();

                //---------------------------------------Code xuất pdf Hóa đơn-------------------------------------------------------------
            }
            catch (Exception ex)
            {
                new Msg(ex.Message, "err");
                new Msg("Có lỗi không mong muốn xảy ra, vui lòng thực hiện đúng thao tác", "err");
                return;
            }

        }

        private void cbbTieuChiKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiemKhachHang.Text = string.Empty;
        }

        private void cbbTieuChiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiemSanPham.Text = string.Empty;
        }
    }

    class SanPhamDuocChon
    {
        string idSanPham;
        int soLuong;

        public SanPhamDuocChon()
        {
            idSanPham = "";
            soLuong = 0;
        }

        public SanPhamDuocChon(string idSanPham, int soLuong)
        {
            this.idSanPham = idSanPham;
            this.soLuong = soLuong;
        }
        public string IdSanPham { get => idSanPham; set => idSanPham = value; }

        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
