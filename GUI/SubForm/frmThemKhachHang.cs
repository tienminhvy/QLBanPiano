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
    public partial class frmThemKhachHang : Form
    {
        private frmBanHang fBanHang;
        private KhachHangBUS khBUS = new KhachHangBUS();
        public TextBox f_txtHoLot { get { return txtHoLot; } }
        public TextBox f_txtTen { get { return txtTen; } }
        public TextBox f_txtDiaChi { get { return txtDiaChi; } }
        public TextBox f_txtSDT { get { return txtSoDienThoai; } }
        public frmThemKhachHang(Form fParent)
        {
            if (fParent is frmBanHang)
            {
                fBanHang = (frmBanHang)fParent;
            }
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (khBUS.Validate(this, txtHoLot.Text, txtTen.Text, txtDiaChi.Text, txtSoDienThoai.Text, "-1"))
            {
                if (khBUS.Them(txtHoLot.Text, txtTen.Text, txtDiaChi.Text, txtSoDienThoai.Text))
                {
                    new Msg("Thêm khách hàng mới thành công!");
                    fBanHang.Init();
                    Dispose();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHoLot.Text = string.Empty;
            txtTen.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSoDienThoai.Text = string.Empty;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            fBanHang.Init();
            Dispose();
        }

        private void frmThemKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
