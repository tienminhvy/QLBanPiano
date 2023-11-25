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

namespace QLBanPiano.GUI
{
    public partial class frmQLKhachHang : Form
    {
        KhachHangBUS khachhang = new KhachHangBUS();
        public frmQLKhachHang()
        {
            InitializeComponent();
            HienDSKhachHang();
        }

        private void HienDSKhachHang()
        {
            dgvKhachHang.DataSource = khachhang.LayToanBoDS();
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewCellCollection Cells = dgvKhachHang.SelectedRows[0].Cells;
                string id = Cells[1].Value.ToString();
                string hoLot = Cells[2].Value.ToString();
                string ten = Cells[3].Value.ToString();
                string diaChi = Cells[4].Value.ToString();
                string sdt = Cells[5].Value.ToString();
                txtMaKH.Text = ten;
                txtHoLot.Text = hoLot;
                txtTen.Text = ten;
                txtDiaChi.Text = diaChi;
                txtSoDienThoai.Text = sdt;
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
                resetTextBoxes();
                dgvKhachHang.ClearSelection();
            }
            else
            {
                if ( khachhang.Validate (
                    txtHoLot.Text,
                    txtTen.Text,
                    txtDiaChi.Text,
                    txtSoDienThoai.Text))
                {
                    if (khachhang.Them(
                        txtHoLot.Text,
                        txtTen.Text,
                        txtDiaChi.Text,
                        txtSoDienThoai.Text,                       
                        "0"))
                    {
                        MessageBox.Show("Thêm khách hàng!");
                        HienDSKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng thất bại!");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                if (dgvKhachHang.SelectedRows.Count > 0)
                {
                    if (khachhang.Xoa(dgvKhachHang.SelectedRows[0].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Xóa khách hàng thành công!");
                        HienDSKhachHang();
                    }
                    else MessageBox.Show("Xóa khách hàng thật bại!");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn khách hàng đẻ xóa!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                if (Validate())
                {
                    DataGridViewCellCollection Cells = dgvKhachHang.SelectedRows[0].Cells;
                    string id = Cells[1].Value.ToString();
                    string hoLot = Cells[2].Value.ToString();
                    string ten = Cells[3].Value.ToString();
                    string diaChi = Cells[4].Value.ToString();
                    string sdt = Cells[5].Value.ToString();
                    txtMaKH.Text = ten;
                    txtHoLot.Text = hoLot;
                    txtTen.Text = ten;
                    txtDiaChi.Text = diaChi;
                    txtSoDienThoai.Text = sdt;

                    if (khachhang.Sua(
                        hoLot,
                        ten,
                        diaChi,
                        sdt,
                        id))
                    {
                        MessageBox.Show("Sửa khách hàng thành công!");
                        HienDSKhachHang();
                    }
                }
                else MessageBox.Show("Sửa khách hàng thất bại!");
            }
            else MessageBox.Show("Vui lòng chọn khách hàng để sửa!");
        }


    }
}
