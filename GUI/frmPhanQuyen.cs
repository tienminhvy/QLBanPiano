using QLBanPiano.BUS;
using QLBanPiano.DTO;
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

namespace QLBanPiano.GUI
{
    public partial class frmPhanQuyen : Form
    {
        VaiTroBUS vaiTroBUS = new VaiTroBUS();
        public frmPhanQuyen()
        {
            InitializeComponent();
            Init();
            uncheckAll();
        }
        private VaiTro[] layDSVaiTro()
        {
            List<DoiTuong> lsDoiTuong = vaiTroBUS.LayDS("1=1");
            List<VaiTro> lsVaiTro = new List<VaiTro>();
            foreach (VaiTro vt in lsDoiTuong)
            {
                lsVaiTro.Add(vt);
            }
            return lsVaiTro.ToArray();
        }
        private void Init()
        {
            dsVaiTro.ValueMember = "Id";
            dsVaiTro.DisplayMember = "Ten";
            dsVaiTro.DataSource = new BindingSource(layDSVaiTro(), null);
            dsVaiTro.ClearSelected();
        }
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            frmThemVaiTro f = new frmThemVaiTro();
            f.ShowDialog();
        }

        private void uncheckAll()
        {
            ckBanHang.Checked = false;
            ckQLHoaDon.Checked = false;
            ckQLNhapHang.Checked = false;
            ckQLNhacCu.Checked = false;
            ckQLKhachHang.Checked = false;
            ckQLNhanVien.Checked = false;
            ckNhapXuat.Checked = false;
        }

        private void dsVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            uncheckAll();
            if (dsVaiTro.SelectedIndex > -1)
            {
                VaiTro vt = layDSVaiTro()[dsVaiTro.SelectedIndex];

                foreach (string quyen in vt.DsQuyen)
                {
                    if (quyen.Equals("banHang"))
                        ckBanHang.Checked = true;
                    if (quyen.Equals("quanLyNhapHang"))
                        ckQLNhapHang.Checked = true;
                    if (quyen.Equals("quanLyHoaDon"))
                        ckQLHoaDon.Checked = true;
                    if (quyen.Equals("quanLyNhacCu"))
                        ckQLNhacCu.Checked = true;
                    if (quyen.Equals("quanLyKhachHang"))
                        ckQLKhachHang.Checked = true;
                    if (quyen.Equals("quanLyNhanVien"))
                        ckQLNhanVien.Checked = true;
                    if (quyen.Equals("nhapXuat"))
                        ckNhapXuat.Checked = true;
                }
            }
        }

        private string dsQuyen(VaiTro vt)
        {
            return string.Join(",", vt.DsQuyen.ToArray());
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dsVaiTro.SelectedIndex > -1)
            {
                VaiTro vt = (VaiTro)dsVaiTro.SelectedItem;
                vt.DsQuyen.Clear();
                foreach (Control control in gbDSQuyen.Controls)
                {
                    if (control is CheckBox)
                    {
                        CheckBox ck = (CheckBox)control;
                        if (ck.Checked)
                        {
                            if (ck.Name.Equals("ckBanHang"))
                                vt.DsQuyen.Add("banHang");
                            if (ck.Name.Equals("ckQLHoaDon"))
                                vt.DsQuyen.Add("quanLyHoaDon");
                            if (ck.Name.Equals("ckQLNhapHang"))
                                vt.DsQuyen.Add("quanLyNhapHang");
                            if (ck.Name.Equals("ckQLNhacCu"))
                                vt.DsQuyen.Add("quanLyNhacCu");
                            if (ck.Name.Equals("ckQLKhachHang"))
                                vt.DsQuyen.Add("quanLyKhachHang");
                            if (ck.Name.Equals("ckQLNhanVien"))
                                vt.DsQuyen.Add("quanLyNhanVien");
                            if (ck.Name.Equals("ckNhapXuat"))
                                vt.DsQuyen.Add("nhapXuat");
                        }
                    }
                }

                if (vaiTroBUS.Sua(vt.Id.ToString(), vt.Ten, dsQuyen(vt)))
                {
                    MessageBox.Show("Cập nhật vai trò thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn vai trò trước khi cập nhật!");
            }
        }
    }
}
