﻿using QLBanPiano.BUS;
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

namespace QLBanPiano.GUI.SubForm
{
    public partial class frmQLNhanVien : Form
    {
        NhanVienBUS nhanvien = new NhanVienBUS();

        public frmQLNhanVien()
        {
            InitializeComponent();
            HienThiDSNhanVien();
            btn_reset.Enabled = false;
            cbbTypeSearch.SelectedIndex = 0;
        }

        private void themCot()
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = "Mã nhân viên";
            col.DataPropertyName = "Id";

            dgvNhanVien.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Họ lót";
            col.DataPropertyName = "HoLot";

            dgvNhanVien.Columns.Add(col);
            col = new DataGridViewTextBoxColumn();
            col.Name = "Tên";
            col.DataPropertyName = "Ten";

            dgvNhanVien.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Ngày vào làm";
            col.DataPropertyName = "NgayVaoLam";

            dgvNhanVien.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Số điện thoại";
            col.DataPropertyName = "SoDienThoai";

            dgvNhanVien.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Địa chỉ";
            col.DataPropertyName = "DiaChi";

            dgvNhanVien.Columns.Add(col);
        }
        private static bool thaydoiND = false;

        private void HienThiDSNhanVien(List<DoiTuong> danhSachNhanVien = null)
        {
            thaydoiND = true;
            if (danhSachNhanVien != null)
            {
                dgvNhanVien.DataSource = null;
                themCot();
                BindingSource bs = new BindingSource();
                foreach (NhanVien nv in danhSachNhanVien)
                {
                    bs.Add(nv);
                }
                dgvNhanVien.DataSource = bs;
            }
            else
                dgvNhanVien.DataSource = nhanvien.LayToanBoDS();
            thaydoiND = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection Cells = dgvNhanVien.SelectedRows[0].Cells;
            string id = Cells[0].Value.ToString();
            frmLienKetTK linkAccount = new frmLienKetTK(id);
            linkAccount.Show();

        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0 && !thaydoiND)
            {
                btn_reset.Enabled = true;
                //lay du lieu tu cac cot cua datagridview
                DataGridViewCellCollection Cells = dgvNhanVien.SelectedRows[0].Cells;
                string id = Cells[0].Value.ToString();
                string hoLot = Cells[1].Value.ToString();
                string ten = Cells[2].Value.ToString();
                DateTime ngayVaoLam = Convert.ToDateTime(Cells[3].Value);
                string sdt = Cells[4].Value.ToString();
                string diaChi = Cells[5].Value.ToString();

                txt_id.Text = id;
                txt_midName.Text = hoLot;
                txt_name.Text = ten;
                txt_sdt.Text = sdt;
                dtpNgayVaoLam.Value = ngayVaoLam;
                txt_address.Text = diaChi;


            }
        }

        private void refreshTextBox()
        {
            txt_id.Text = "";
            txt_midName.Text = "";
            txt_name.Text = "";
            dtpNgayVaoLam.Value = DateTime.Now;
            txt_sdt.Text = "";
            txt_address.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                refreshTextBox();
                dgvNhanVien.ClearSelection();
            }
            else
            {
                if (nhanvien.Validate(txt_midName.Text, txt_name.Text,
                     dtpNgayVaoLam.Value.ToShortDateString(), txt_sdt.Text, txt_address.Text, "-1"))
                {

                    if (nhanvien.Them(txt_midName.Text, txt_name.Text,
                        dtpNgayVaoLam.Value.ToShortDateString(), txt_sdt.Text, txt_address.Text))
                    {
                        new Msg("Thêm nhân viên thành công!");
                        HienThiDSNhanVien();
                    }
                    else
                    {
                        new Msg("Thêm nhân viên thất bại!", "err");
                    }
                }
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewCellCollection Cells = dgvNhanVien.SelectedRows[0].Cells;
                string id = Cells[0].Value.ToString();
                if (nhanvien.Validate(txt_midName.Text, txt_name.Text, dtpNgayVaoLam.Value.ToShortDateString()
                    , txt_sdt.Text, txt_address.Text, id))
                {
                    txt_id.Text = id;
                    string hoLot = txt_midName.Text;
                    string ten = txt_name.Text;
                    string sdt = txt_sdt.Text;
                    string address = txt_address.Text;

                    if (nhanvien.Validate(hoLot, ten, dtpNgayVaoLam.Value.ToShortDateString(), sdt, address, id))
                    {
                        if (nhanvien.Sua(hoLot, ten, dtpNgayVaoLam.Value.ToShortDateString(), sdt, address, id))
                            MessageBox.Show("Sửa nhân viên thành công!");
                        else
                            MessageBox.Show("Sửa nhân viên thất bại!");
                        HienThiDSNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Sửa nhân viên thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa!");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                DialogResult res = new Msg("Bạn có muốn xoá nhân viên này?", "warn").Res;
                if (res != DialogResult.OK)
                    return;
                //xet tieu chi la ma nhan vien de xoa hang do ra khoi bang
                if (nhanvien.Xoa("id = " + dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Xoá nhân viên thành công!");
                    HienThiDSNhanVien();
                }
                else
                {
                    MessageBox.Show("Xoá nhân viên thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xoá!");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tieuChi = cbbTypeSearch.SelectedItem.ToString();
            string giaTri = txtSearch.Text.Trim();
            if (giaTri == string.Empty && tieuChi != "Xem tất cả")
            {
                new Msg("Vui lòng nhập thông tin tìm kiếm!", "err");
                return;
            }
            List<DoiTuong> DSKetQuaTimKiem = nhanvien.TimKiem(tieuChi, giaTri);
            HienThiDSNhanVien(DSKetQuaTimKiem);
        }

        private void cbbTypeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTypeSearch.SelectedIndex > -1)
            {
                if (cbbTypeSearch.SelectedItem == "Xem tất cả")
                {
                    txtSearch.Enabled = false;
                }
                else
                    txtSearch.Enabled = true;
            }
        }
    }
}
