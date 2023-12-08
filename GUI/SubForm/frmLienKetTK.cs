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
        private bool enabled;
        public frmLienKetTK(string nhanvien_id)
        {
            InitializeComponent();
            nv_id = nhanvien_id;
            Init();
        }
        private TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        private VaiTro[] layDSVaiTro()
        {
            List<DoiTuong> lsDoiTuong = vtBUS.LayDS("1=1");
            List<VaiTro> lsVaiTro = new List<VaiTro>();
            foreach (VaiTro vt in lsDoiTuong)
            {
                lsVaiTro.Add(vt);
            }
            return lsVaiTro.ToArray();
        }
        private VaiTroBUS vtBUS = new VaiTroBUS();
        private void DisableAll()
        {
            cbVaiTro.Enabled = false;
            txtMatKhau.Enabled = false;
            txtTenDangNhap.Enabled = false;
            btnCapNhat.Enabled = false;
            btnThaoTac.Enabled = false;
        }
        private void EnableAll()
        {

        }

        private bool LaAdminToiCao()
        {
            if (frmChinh.vaitro_id == "1") return true;
            return false;
        }

        private void Init()
        {
            cbVaiTro.DisplayMember = "Ten";
            cbVaiTro.ValueMember = "Id";
            cbVaiTro.DataSource = new BindingSource(layDSVaiTro(), null);

            if (tkBUS.SoLuong("nhanvien_id = " + nv_id) > 0)
            {
                // Đã liên kết tk
                enabled = (bool)tkBUS.GiaTriTruong("trangthai", "nhanvien_id = " + nv_id);

                if (enabled)
                {
                    txtTenDangNhap.Enabled = true;
                    txtMatKhau.Enabled = true;
                    cbVaiTro.Enabled = true;
                    btnCapNhat.Enabled = true;
                    label_stateResult.Text = "Đã liên kết tài khoản!";
                    List<DoiTuong> taiKhoans = tkBUS.LayDS("nhanvien_id = " + nv_id);

                    string id_vaitro = "";
                    foreach (TaiKhoan tk in taiKhoans)
                    {
                        txtTenDangNhap.Text = tk.TenDangNhap;
                        txtMatKhau.Text = tk.MatKhau;
                        id_vaitro = tk.VaiTro.Id.ToString();
                        cbVaiTro.SelectedValue = tk.VaiTro.Id;
                        break;
                    }
                    btnCapNhat.Text = "Cập nhật";
                    btnThaoTac.Text = "Khoá";

                    if (!LaAdminToiCao() && id_vaitro == "1")
                    {
                        new Msg("Bạn không có đủ quyền hạn để thực hiện thao tác này!");
                        DisableAll();
                        return;
                    }

                    if (!LaAdminToiCao())
                    {
                        cbVaiTro.DataSource = new BindingSource(layDSVaiTro().Where((val, i) =>
                        {
                            return val.Id != 1;
                        }), null);
                        cbVaiTro.SelectedValue = int.Parse(id_vaitro);
                    }
                }
                else
                {
                    label_stateResult.Text = "Tài khoản đã bị khoá!";
                    txtTenDangNhap.Enabled = false;
                    txtMatKhau.Enabled = false;
                    btnCapNhat.Enabled = false;
                    cbVaiTro.Enabled = false;
                    btnThaoTac.Text = "Mở khoá";
                }

            }
            else
            {
                // Chưa
                label_stateResult.Text = "Chưa liên kết tài khoản!";
                btnCapNhat.Text = "Tạo mới";
                btnThaoTac.Enabled = false;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (cbVaiTro.SelectedIndex == -1)
            {
                new Msg("Vui lòng chọn vai trò trước khi thực hiện thao tác này!", "err");
                return;
            }
            if (tkBUS.SoLuong("nhanvien_id = " + nv_id) > 0)
            {
                // Đã có, cập nhật
                if (tkBUS.Validate(txtTenDangNhap.Text, txtMatKhau.Text, nv_id, cbVaiTro.SelectedValue.ToString()))
                {
                    if (tkBUS.Sua(txtTenDangNhap.Text, txtMatKhau.Text, nv_id, cbVaiTro.SelectedValue.ToString()))
                    {
                        new Msg("Sửa nhân viên thành công!");
                        Init();
                    }
                }
            }
            else
            {
                // Khởi tạo
                if (tkBUS.Validate(txtTenDangNhap.Text, txtMatKhau.Text, "-1", cbVaiTro.SelectedValue.ToString()))
                {
                    if (tkBUS.Them(txtTenDangNhap.Text, txtMatKhau.Text, nv_id, cbVaiTro.SelectedValue.ToString()))
                    {
                        new Msg("Thêm nhân viên thành công!");
                        Init();
                    }
                }
            }
        }

        private void btnThaoTac_Click(object sender, EventArgs e)
        {
            if (enabled)
            {
                DialogResult res = (new Msg("Bạn có muốn khoá tài khoản nhân viên này?", "warn")).Res;

                if (res == DialogResult.OK)
                {
                    tkBUS.Khoa(nv_id);
                    new Msg("Khoá thành công!");
                    Init();
                }
            }
            else
            {
                DialogResult res = (new Msg("Bạn có muốn mở khoá tài khoản nhân viên này?", "warn")).Res;

                if (res == DialogResult.OK)
                {
                    tkBUS.MoKhoa(nv_id);
                    new Msg("Mở khoá thành công!");
                    Init();
                }
            }
        }

        private void cbVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmLienKetTK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
