﻿using DocumentFormat.OpenXml.Office2010.CustomUI;
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
            UncheckAll();
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
        public void Init()
        {
            dsVaiTro.ValueMember = "Id";
            dsVaiTro.DisplayMember = "Ten";
            dsVaiTro.DataSource = new BindingSource(layDSVaiTro(), null);
            dsVaiTro.ClearSelected();
            txtTenVaiTro.Enabled = false;
        }
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            frmThemVaiTro f = new frmThemVaiTro(this);
            f.ShowDialog();
        }

        private void UncheckAll()
        {
            ckBanHang.Checked = false;
            ckQLHoaDon.Checked = false;
            ckQLNhapHang.Checked = false;
            ckQLNhacCu.Checked = false;
            ckQLKhachHang.Checked = false;
            ckQLNhanVien.Checked = false;
            ckNhapXuat.Checked = false;
            ckThongKe.Checked = false;
            ckQLThuongHieu.Checked = false;
            ckVaiTro.Checked = false;
        }

        private void CheckAll()
        {
            ckBanHang.Checked = true;
            ckQLHoaDon.Checked = true;
            ckQLNhapHang.Checked = true;
            ckQLNhacCu.Checked = true;
            ckQLKhachHang.Checked = true;
            ckQLNhanVien.Checked = true;
            ckNhapXuat.Checked = true;
            ckThongKe.Checked = true;
            ckQLThuongHieu.Checked = true;
            ckVaiTro.Checked = true;
        }

        private void DisableAll()
        {
            ckBanHang.Enabled = false;
            ckQLHoaDon.Enabled = false;
            ckQLNhapHang.Enabled = false;
            ckQLNhacCu.Enabled = false;
            ckQLKhachHang.Enabled = false;
            ckQLNhanVien.Enabled = false;
            ckNhapXuat.Enabled = false;
            ckThongKe.Enabled = false;
            ckQLThuongHieu.Enabled = false;
            ckVaiTro.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            txtTenVaiTro.Enabled = false;
        }
        private void EnableAll()
        {
            ckBanHang.Enabled = true;
            ckQLHoaDon.Enabled = true;
            ckQLNhapHang.Enabled = true;
            ckQLNhacCu.Enabled = true;
            ckQLKhachHang.Enabled = true;
            ckQLNhanVien.Enabled = true;
            ckNhapXuat.Enabled = true;
            ckThongKe.Enabled = true;
            ckQLThuongHieu.Enabled = true;
            ckVaiTro.Enabled = true;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
            txtTenVaiTro.Enabled = true;
        }

        private void dsVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            UncheckAll();
            if (dsVaiTro.SelectedIndex > -1)
            {
                EnableAll();
                VaiTro vt = layDSVaiTro()[dsVaiTro.SelectedIndex];
                txtTenVaiTro.Enabled = true;

                txtTenVaiTro.Text = vt.Ten;

                foreach (string quyen in vt.DsQuyen)
                {
                    if (quyen.Equals("*"))
                        CheckAll();
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
                    if (quyen.Equals("thongKe"))
                        ckThongKe.Checked = true;
                    if (quyen.Equals("quanLyThuongHieu"))
                        ckQLThuongHieu.Checked = true;
                    if (quyen.Equals("quanLyVaiTro"))
                        ckVaiTro.Checked = true;
                }

                if (dsVaiTro.SelectedIndex == 0)
                {
                    DisableAll();
                    return;
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
                    if (control is System.Windows.Forms.CheckBox)
                    {
                        System.Windows.Forms.CheckBox ck = (System.Windows.Forms.CheckBox)control;
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
                            if (ck.Name.Equals("ckThongKe"))
                                vt.DsQuyen.Add("thongKe");
                            if (ck.Name.Equals("ckQLThuongHieu"))
                                vt.DsQuyen.Add("quanLyThuongHieu");
                            if (ck.Name.Equals("ckVaiTro"))
                                vt.DsQuyen.Add("quanLyVaiTro");
                        }
                    }
                }

                if (vaiTroBUS.Sua(vt.Id.ToString(), txtTenVaiTro.Text, dsQuyen(vt)))
                {
                    new Msg("Cập nhật vai trò thành công", "");
                    Init();
                }
            }
            else
            {
                new Msg("Chọn ít nhất một vai trò trước khi cập nhật", "err");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dsVaiTro.SelectedIndex > -1)
            {
                VaiTro vt = (VaiTro)dsVaiTro.SelectedItem;
                DialogResult res = new Msg("Bạn có muốn xoá vai trò này?", "warn").Res;
                if (res is DialogResult.OK)
                {
                    if (vaiTroBUS.Xoa(string.Format("id = {0}", vt.Id)))
                    {
                        Init();
                        new Msg("Xoá thành công");
                    }
                }
            }
            else
            {
                new Msg("Chọn ít nhất một vai trò trước khi xoá", "err");
            }
        }
    }
}
