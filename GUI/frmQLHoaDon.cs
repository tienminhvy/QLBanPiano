using QLBanPiano.BUS;
using QLBanPiano.GUI.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanPiano.GUI
{
    public partial class frmQLHoaDon : Form
    {
        private HoaDonBUS hoaDonMaxBus = new HoaDonBUS();
        public static int doubleClickRowID = -1;
        public frmQLHoaDon()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            DataTable dt = hoaDonMaxBus.LayToanBoDS();
            hoaDonGridView.DataSource = null;
            hoaDonGridView.Rows.Clear();
            hoaDonGridView.DataSource = dt;
            hoaDonGridView.ReadOnly = true;
            hoaDonGridView.AllowUserToResizeColumns = false;
            hoaDonGridView.AllowUserToResizeRows = false;
            hoaDonGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hoaDonGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            hoaDonGridView.Columns["Thời gian"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm:ss tt";
            foreach (DataGridViewColumn col in hoaDonGridView.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            hoaDonCountTxtBox.Text = hoaDonMaxBus.SoLuong("id > -1").ToString();
            //Init cho combobox tiêu chí
            string[] items = { "ID", "Thời gian", "Mã nhân viên", "Mã khách hàng", "Tên nhân viên", "Tên khách hàng" };
            cbbTieuChi.Items.AddRange(items);
            cbbTieuChi.SelectedIndex = 0;
        }


        private void QLHD_Load(object sender, EventArgs e)
        {

        }

        private void hoaDonGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được click
                DataGridViewRow selectedRow = hoaDonGridView.Rows[e.RowIndex];
                // Lấy giá trị từ các cột của dòng được chọn
                try
                {
                    idTextbox.Text = selectedRow.Cells[0].Value.ToString();
                    DateTime result = (DateTime)selectedRow.Cells[1].Value;
                    dateTimePicker1.Value = result;
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy hh:mm:ss tt";
                    // Hiển thị giá trị trong id textbox
                    nv_idTextBox.Text = selectedRow.Cells[2].Value.ToString();
                    nv_nameTextBox.Text = selectedRow.Cells[3].Value.ToString();
                    kh_idTextBox.Text = selectedRow.Cells[4].Value.ToString();
                    kh_nameTextBox.Text = selectedRow.Cells[5].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không có giá trị trong dòng này ");
                }

            }
        }

        private void hoaDonGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = hoaDonGridView.Rows[e.RowIndex];
                doubleClickRowID = (int)selectedRow.Cells[0].Value;
                frmChiTietHoaDon ct = new();
                ct.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chọn quá nhiều mục");
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void cbbTieuChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbTieuChi.SelectedIndex)
            {
                case 0:
                    txtTieuChi.PlaceholderText = "Nhập ID (VD: 0 )";
                    txtTieuChi.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
                case 1:
                    txtTieuChi.PlaceholderText = "Nhập thời gian (VD: 19-05-2023)";
                    txtTieuChi.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
                case 2:
                    txtTieuChi.PlaceholderText = "Nhập mã nhân viên (VD: 2 )";
                    txtTieuChi.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
                case 3:
                    txtTieuChi.PlaceholderText = "Nhập mã khách hàng (VD: 5 )";
                    txtTieuChi.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
                case 4:
                    txtTieuChi.PlaceholderText = "Nhập tên nhân viên (VD: Minh Vy )";
                    txtTieuChi.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
                case 5:
                    txtTieuChi.PlaceholderText = "Nhập tên khách hàng (VD: Văn A )";
                    txtTieuChi.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
                default:
                    break;
            }
        }
    }
}
