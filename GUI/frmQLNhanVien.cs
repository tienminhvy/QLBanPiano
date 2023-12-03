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

namespace QLBanPiano.GUI.SubForm
{
    public partial class frmQLNhanVien : Form
    {
        NhanVienBUS nhanvien = new NhanVienBUS();

        public frmQLNhanVien()
        {
            InitializeComponent();
            HienThiDSNhanVien();
            btn_link_acc.Enabled = false;
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
                dgvNhanVien.Columns.Clear();
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

        private void btn_link_acc_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewCellCollection Cells = dgvNhanVien.SelectedRows[0].Cells;
                string id = Cells[0].Value.ToString();

                if (id == frmChinh.nhanvien_id)
                {
                    new Msg("Bạn không được thực hiện thao tác này trên tài khoản của bản thân", "err");
                    return;
                }

                frmLienKetTK linkAccount = new frmLienKetTK(id);
                linkAccount.Show();
            }
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0 && !thaydoiND)
            {
                btn_link_acc.Enabled = true;
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

                TaiKhoanBUS tkBUS = new TaiKhoanBUS();

                string id_vai_tro = tkBUS.GiaTriTruong("vaitro_id", "nhanvien_id = " + id).ToString();

                if (id_vai_tro == "1" && frmChinh.vaitro_id != "1")
                {
                    btn_delete.Enabled = false;
                    btn_update.Enabled = false;
                } else
                {
                    btn_delete.Enabled = true;
                    btn_update.Enabled = true;
                }
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
            btn_delete.Enabled = true;
            btn_update.Enabled = true;
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
                            new Msg("Sửa nhân viên thành công!");
                        else
                            new Msg("Sửa nhân viên thất bại!", "err");
                        HienThiDSNhanVien();
                    }
                    else
                    {
                        new Msg("Sửa nhân viên thất bại!");
                    }
                }
            }
            else
            {
                new Msg("Vui lòng chọn nhân viên để sửa!", "err");
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
                    new Msg("Xoá nhân viên thành công!");
                    HienThiDSNhanVien();
                }
                else
                {
                    new Msg("Xoá nhân viên thất bại!", "err");
                }
            }
            else
            {
                new Msg("Vui lòng chọn nhân viên để xoá!", "err");
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
