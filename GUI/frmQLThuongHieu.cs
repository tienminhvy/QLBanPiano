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
using System.Windows.Controls;
using System.Windows.Forms;

namespace QLBanPiano.GUI
{
    public partial class frmQLThuongHieu : Form
    {
        public frmQLThuongHieu()
        {
            InitializeComponent();
            LoadDSThuongHieu();
            cbTimKiem.SelectedIndex = 0;
        }

        ThuongHieuBUS thBUS = new ThuongHieuBUS();

        private void themCot()
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = "ID";
            col.DataPropertyName = "Id";

            dgvThuongHieu.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Mã";
            col.DataPropertyName = "Ma";

            dgvThuongHieu.Columns.Add(col);
            col = new DataGridViewTextBoxColumn();
            col.Name = "Tên";
            col.DataPropertyName = "Ten";

            dgvThuongHieu.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Mô tả";
            col.DataPropertyName = "Mota";

            dgvThuongHieu.Columns.Add(col);
        }
        private static bool thaydoiND = false;

        private void LoadDSThuongHieu(List<DoiTuong> dsThuongHieu = null)
        {
            thaydoiND = true;
            if (dsThuongHieu == null)
            {
                dgvThuongHieu.DataSource = thBUS.LayToanBoDS();
                thaydoiND = false;
                return;
            }
            dgvThuongHieu.Columns.Clear();
            dgvThuongHieu.DataSource = null;
            themCot();
            BindingSource bs = new BindingSource();

            foreach (ThuongHieu th in dsThuongHieu)
                bs.Add(th);
            dgvThuongHieu.DataSource = bs;
            thaydoiND = false;
        }

        private void frmQLThuongHieu_Load(object sender, EventArgs e)
        {

        }

        private void dgvThuongHieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void dgvThuongHieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThuongHieu.SelectedRows.Count > 0 && !thaydoiND)
            {
                DataGridViewCellCollection Cells = dgvThuongHieu.SelectedRows[0].Cells;
                string id = Cells[0].Value.ToString();
                string ma = Cells[1].Value.ToString();
                string ten = Cells[2].Value.ToString();
                string moTa = Cells[3].Value.ToString();

                txtId.Text = id;
                txtMa.Text = ma;
                txtTen.Text = ten;
                txtMoTa.Text = moTa;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tieuChi = cbTimKiem.SelectedItem.ToString();
            string giaTri = txtTieuChi.Text.Trim();
            if (giaTri == string.Empty && tieuChi != "Xem tất cả")
            {
                new Msg("Vui lòng nhập thông tin tìm kiếm!", "err");
                return;
            }
            List<DoiTuong> DSKetQuaTimKiem = thBUS.TimKiem(tieuChi, giaTri);
            LoadDSThuongHieu(DSKetQuaTimKiem);
        }

        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTimKiem.SelectedIndex > -1)
            {
                if (cbTimKiem.SelectedItem == "Xem tất cả")
                {
                    txtTieuChi.Enabled = false;
                }
                else
                    txtTieuChi.Enabled = true;
            }
        }

        private void refreshTextBox()
        {
            txtId.Text = "";
            txtMa.Text = "";
            txtTen.Text = "";
            txtMoTa.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvThuongHieu.SelectedRows.Count > 0)
            {
                refreshTextBox();
                dgvThuongHieu.ClearSelection();
            }
            else
            {
                if (thBUS.Validate(txtMa.Text, txtTen.Text, txtMoTa.Text, "-1"))
                {
                    if (thBUS.Them(txtMa.Text, txtTen.Text, txtMoTa.Text))
                    {
                        new Msg("Thêm thương hiệu thành công!");
                        LoadDSThuongHieu();
                    }
                    else
                    {
                        new Msg("Thêm thương hiệu thất bại!", "err");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvThuongHieu.SelectedRows.Count > 0)
            {
                DataGridViewCellCollection Cells = dgvThuongHieu.SelectedRows[0].Cells;
                string id = Cells[0].Value.ToString();

                if (thBUS.Validate(txtMa.Text, txtTen.Text, txtMoTa.Text, id))
                {
                    if (thBUS.Sua(id, txtMa.Text, txtTen.Text, txtMoTa.Text))
                    {
                        new Msg("Sửa thương hiệu thành công!");
                        LoadDSThuongHieu();
                    }
                    else
                    {
                        new Msg("Sửa thương hiệu thất bại!", "err");
                    }
                }
            }
            else new Msg("Vui lòng chọn thương hiệu để sửa", "err");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvThuongHieu.SelectedRows.Count > 0)
            {
                DialogResult res = new Msg("Bạn có muốn xoá thương hiệu này?", "warn").Res;
                if (res != DialogResult.OK)
                    return;
                DataGridViewCellCollection Cells = dgvThuongHieu.SelectedRows[0].Cells;
                string id = Cells[0].Value.ToString();

                if (thBUS.Xoa("id = "+id))
                {
                    new Msg("Xoá thương hiệu thành công!");
                    LoadDSThuongHieu();
                    refreshTextBox();
                }
                else
                {
                    new Msg("Xoá thương hiệu thất bại!", "err");
                }
            }
            else new Msg("Vui lòng chọn thương hiệu để xoá", "err");
        }
    }
}
