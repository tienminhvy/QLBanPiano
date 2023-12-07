using QLBanPiano.BUS;
using QLBanPiano.DTO;
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
    public partial class frmChinhSuaThongTin : Form
    {
        public frmChinhSuaThongTin()
        {
            InitializeComponent();
            Init();
        }
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        private void Init()
        {
            StartPosition = FormStartPosition.CenterParent;
            txtTenDangNhap.Enabled = false;
            txtVaiTro.Enabled = false;

            txtTenDangNhap.Text = tkBUS.GiaTriTruong("tenDangNhap", " nhanvien_id = " + frmChinh.nhanvien_id).ToString();
            txtMatKhau.Text = tkBUS.GiaTriTruong("matKhau", " nhanvien_id = " + frmChinh.nhanvien_id).ToString();

            DoiTuong[] dts = tkBUS.LayDS(" nhanvien_id = " + frmChinh.nhanvien_id).ToArray();

            VaiTro vt = ((TaiKhoan)dts[0]).VaiTro;
            txtVaiTro.Text = vt.Ten;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == string.Empty)
            {
                new Msg("Vui lòng nhập mật khẩu!", "err");
                txtMatKhau.Focus();
                return;
            }
            if (tkBUS.DoiMatKhau(txtMatKhau.Text, frmChinh.nhanvien_id))
            {
                new Msg("Đổi mật khẩu thành công!");
            }
        }
    }
}
