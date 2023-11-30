using QLBanPiano.BUS;
using QLBanPiano.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanPiano.GUI.SubForm
{
    public partial class frmLienKetTK : Form
    {
        public frmLienKetTK()
        {
            InitializeComponent();
        }
        private string nv_id;
        public frmLienKetTK(string nhanvien_id)
        {
            InitializeComponent();
            nv_id = nhanvien_id;
            Init();
        }
        private void Init()
        {
            TaiKhoanBUS tkBUS = new TaiKhoanBUS();
            if (tkBUS.SoLuong("nhanvien_id = " + nv_id) > 0)
            {
                // Đã liên kết tk
                bool enabled = (bool) tkBUS.GiaTriTruong("trangthai", "nhanvien_id = " + nv_id);

                if (enabled)
                {
                    label_stateResult.Text = "Đã liên kết tài khoản!";
                    List<DoiTuong> taiKhoans = tkBUS.LayDS("nhanvien_id = " + nv_id);

                    foreach (TaiKhoan tk in taiKhoans)
                    {
                        txtTenDangNhap.Text = tk.TenDangNhap;
                        txtMatKhau.Text = tk.MatKhau;
                        break;
                    }
                } else
                {
                    label_stateResult.Text = "Tài khoản đã bị khoá!";
                    txtTenDangNhap.Enabled = false;
                    txtMatKhau.Enabled = false;
                }
                
            } else
            {
                // Chưa
                label_stateResult.Text = "Chưa liên kết tài khoản!";
            }
        }

    }
}
