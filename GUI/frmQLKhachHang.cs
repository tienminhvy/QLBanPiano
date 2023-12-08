using QLBanPiano.BUS;
using QLBanPiano.DTO;
using QLBanPiano.GUI.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanPiano.GUI
{
    public partial class frmQLKhachHang : Form
    {

        public TextBox f_txtHoLot { get { return txtHoLot; } }
        public TextBox f_txtTen { get { return txtTen; } }
        public TextBox f_txtDiaChi { get { return txtDiaChi; } }
        public TextBox f_txtSDT { get { return txtSoDienThoai; } }

        KhachHangBUS khachhang = new KhachHangBUS();
        public frmQLKhachHang()
        {
            InitializeComponent();
            HienDSKhachHang();
            cbbTimKiem.SelectedItem = "Xem tất cả";
        }

        private void themCot()
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = "Mã khách hàng";
            col.DataPropertyName = "Id";

            dgvKhachHang.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Họ lót";
            col.DataPropertyName = "HoLot";

            dgvKhachHang.Columns.Add(col);
            col = new DataGridViewTextBoxColumn();
            col.Name = "Tên";
            col.DataPropertyName = "Ten";

            dgvKhachHang.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Địa chỉ";
            col.DataPropertyName = "DiaChi";

            dgvKhachHang.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Số điện thoại";
            col.DataPropertyName = "SoDienThoai";

            dgvKhachHang.Columns.Add(col);
        }
        private static bool thaydoiND = false;
        private void HienDSKhachHang(List<DoiTuong> danhSachKhachHang = null)
        {
            thaydoiND = true;
            if (danhSachKhachHang != null)
            {
                dgvKhachHang.Columns.Clear();
                dgvKhachHang.DataSource = null;
                themCot();
                BindingSource bs = new BindingSource();
                foreach (KhachHang kh in danhSachKhachHang)
                {
                    bs.Add(kh);
                }
                dgvKhachHang.DataSource = bs;
            }
            else
                dgvKhachHang.DataSource = khachhang.LayToanBoDS();
            thaydoiND = false;
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0 && !thaydoiND)
            {
                DataGridViewCellCollection Cells = dgvKhachHang.SelectedRows[0].Cells;
                string id = Cells[0].Value.ToString();
                string hoLot = Cells[1].Value.ToString();
                string ten = Cells[2].Value.ToString();
                string diaChi = Cells[3].Value.ToString();
                string sdt = Cells[4].Value.ToString();
                txtMaKH.Text = id;
                txtHoLot.Text = hoLot;
                txtTen.Text = ten;
                txtDiaChi.Text = diaChi;
                txtSoDienThoai.Text = sdt;
            }
            else
            {
                resetTextBoxes();
            }
        }

        private void resetTextBoxes()
        {
            txtMaKH.Text = "";
            txtHoLot.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                //resetTextBoxes();
                dgvKhachHang.ClearSelection();
                return;
            }
            else
            {
                if (khachhang.Validate(
                    this,
                    txtHoLot.Text,
                    txtTen.Text,
                    txtDiaChi.Text,
                    txtSoDienThoai.Text, "0"))
                {
                    if (khachhang.Them(
                        txtHoLot.Text,
                        txtTen.Text,
                        txtDiaChi.Text,
                        txtSoDienThoai.Text))
                    {
                        new Msg("Thêm khách hàng thành công!");
                        HienDSKhachHang();
                        resetTextBoxes();
                    }
                    else
                    {
                        new Msg("Thêm khách hàng thất bại!", "err");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (txtMaKH.Text.Trim().Length == 0)
            {
                new Msg("Chọn khách hàng muốn xóa", "err");
                return;
            }
            int id = int.Parse(txtMaKH.Text.Trim());

            DialogResult dialogResult = new Msg("Bạn có muốn xóa khách hàng có mã là: " + id + " không?", "warn").Res;
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            if (khachhang.Xoa("Id=" + id))
            {
                new Msg("Xóa khách hàng thành công!");
                HienDSKhachHang();
                txtMaKH.Text = string.Empty;
                txtHoLot.Text = string.Empty;
                txtTen.Text = string.Empty;
                txtDiaChi.Text = string.Empty;
                txtSoDienThoai.Text = string.Empty;
            }
            else
            {
                new Msg("Xóa khách hàng thất bại!", "err");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {


                if (khachhang.Validate(this,txtHoLot.Text, txtTen.Text, txtDiaChi.Text, txtSoDienThoai.Text, "0"))
                {
                    DataGridViewCellCollection Cells = dgvKhachHang.SelectedRows[0].Cells;
                    string id = Cells[0].Value.ToString();
                    txtMaKH.Text = id;
                    string hoLot = txtHoLot.Text;
                    string ten = txtTen.Text;
                    string diaChi = txtDiaChi.Text;
                    string sdt = txtSoDienThoai.Text;

                    if (khachhang.Sua(
                        hoLot,
                        ten,
                        diaChi,
                        sdt,
                        id))
                    {
                        new Msg("Sửa khách hàng thành công!");
                        resetTextBoxes();
                        HienDSKhachHang();
                    }
                }
            }
            else new Msg("Vui lòng chọn khách hàng để sửa!", "err");
        }

        private void frmQLKhachHang_Load_1(object sender, EventArgs e)
        {
            cbbTimKiem.Text = "Mã khách hàng";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tieuChi = cbbTimKiem.SelectedItem.ToString();
            string giaTri = txtTimKiem.Text.Trim();
            if (giaTri == string.Empty && tieuChi != "Xem tất cả")
            {
                new Msg("Vui lòng nhập thông tin tìm kiếm!", "err");
                return;
            }
            List<DoiTuong> DSKetQuaTimKiem = khachhang.TimKiem(tieuChi, giaTri);
            HienDSKhachHang(DSKetQuaTimKiem);
        }

        private void cbbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTimKiem.SelectedIndex > -1)
            {
                if (cbbTimKiem.SelectedItem == "Xem tất cả")
                {
                    txtTimKiem.Enabled = false;
                }
                else
                    txtTimKiem.Enabled = true;
            }
        }
    }
}
