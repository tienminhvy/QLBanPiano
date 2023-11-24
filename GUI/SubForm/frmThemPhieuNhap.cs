using QLBanPiano.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanPiano.GUI.QuanLyHoaDon_PhieuNhap
{
    public partial class frmThemPhieuNhap : Form
    {
        PhieuNhapBUS phieuNhapBUS = new();
        public static int doubleClickRowID = -1;
        bool searchClicked = false;
        public QLPN()
        {
            InitializeComponent();
            Init();
            SearchTextBox_Init();
        }
        void Init()
        {
            //Set value và định dạng cho data grid view 
            DataTable dt = phieuNhapBUS.LayToanBoDS();
            phieuNhapGridView.DataSource = null;
            phieuNhapGridView.Rows.Clear();
            phieuNhapGridView.DataSource = dt;
            phieuNhapGridView.ReadOnly = true;
            phieuNhapGridView.AllowUserToResizeColumns = false;
            phieuNhapGridView.AllowUserToResizeRows = false;
            phieuNhapGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            phieuNhapGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            phieuNhapGridView.Columns["Thời gian"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm:ss tt";
            foreach (DataGridViewColumn col in phieuNhapGridView.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            //Set Value cho cbbTieuChi
            string[] list = { "ID", "Thời gian", "Mã nhân viên", "Tên nhân viên" };
            cbbTieuChi.Items.Clear();
            cbbTieuChi.Items.AddRange(list);
            cbbTieuChi.SelectedIndex = 0;
        }
        void SearchTextBox_Init()
        {
            switch (cbbTieuChi.SelectedIndex)
            {
                case 0:
                    searchTextBox.PlaceholderText = "Nhập ID (VD: 2)";
                    searchTextBox.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
                case 1:
                    searchTextBox.PlaceholderText = "Nhập thời gian (VD: 2023-11-11 8:30:00 )";
                    searchTextBox.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
                case 2:
                    searchTextBox.PlaceholderText = "Nhập mã nhân viên (VD: 4)";
                    searchTextBox.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
                case 3:
                    searchTextBox.PlaceholderText = "Nhập tên nhân viên (VD: Minh Vy)";
                    searchTextBox.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
            }
        }
        void Load(DataTable dt)
        {
            phieuNhapGridView.DataSource = null;
            phieuNhapGridView.Rows.Clear();
            phieuNhapGridView.DataSource = dt;
            phieuNhapGridView.ReadOnly = true;
            phieuNhapGridView.AllowUserToResizeColumns = false;
            phieuNhapGridView.AllowUserToResizeRows = false;
            phieuNhapGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            phieuNhapGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewColumn col in phieuNhapGridView.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void phieuNhapGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = phieuNhapGridView.Rows[e.RowIndex];
                try
                {
                    idPhieuNhapTxtBox.Text = selectedRow.Cells[0].Value.ToString();
                    idNhanVienTextBox.Text = selectedRow.Cells[2].Value.ToString();
                    nv_nameTextBox.Text = selectedRow.Cells[3].Value.ToString();
                    DateTime result = (DateTime)selectedRow.Cells[1].Value;
                    dateTimePicker.Value = result;
                    dateTimePicker.Format = DateTimePickerFormat.Custom;
                    dateTimePicker.CustomFormat = "dd-MM-yyyy hh:mm:ss tt";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không có giá trị trong dòng này ");
                }
            }
        }

        private void phieuNhapGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = phieuNhapGridView.Rows[e.RowIndex];
                doubleClickRowID = (int)selectedRow.Cells[0].Value;
                ChiTietPhieuNhap ctpn = new();
                ctpn.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void searchTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            searchTextBox.Text = string.Empty;
            searchTextBox.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void cbbTieuChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbTieuChi.SelectedIndex)
            {
                case 0:
                    searchTextBox.Text = string.Empty;
                    searchTextBox.PlaceholderText = "Nhập ID (VD: 2 )";
                    searchTextBox.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
                case 1:
                    searchTextBox.Text = string.Empty;
                    searchTextBox.PlaceholderText = "Nhập thời gian (VD: 2023-11-11 8:30:00 AM)";
                    searchTextBox.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
                case 2:
                    searchTextBox.Text = string.Empty;
                    searchTextBox.PlaceholderText = "Nhập mã nhân viên (VD: 4 )";
                    searchTextBox.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
                case 3:
                    searchTextBox.Text = string.Empty;
                    searchTextBox.PlaceholderText = "Nhập tên nhân viên (VD: Minh Vy )";
                    searchTextBox.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
            }
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchClicked = true;
            DataTable dt = new();
            switch (cbbTieuChi.SelectedIndex)
            {
                case 0:
                    if (searchTextBox.Text != string.Empty)
                    {
                        dt = phieuNhapBUS.TimKiem(cbbTieuChi.SelectedIndex, searchTextBox.Text);
                        Load(dt);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập nội dung cần tìm kiếm !");
                    }
                    searchClicked = false;
                    break;
                case 1:
                    if (searchTextBox.Text != string.Empty)
                    {
                        dt = phieuNhapBUS.TimKiem(cbbTieuChi.SelectedIndex, searchTextBox.Text);
                        Load(dt);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập nội dung cần tìm kiếm !");
                    }
                    searchClicked = false;
                    break;
                case 2:
                    if (searchTextBox.Text != string.Empty)
                    {
                        dt = phieuNhapBUS.TimKiem(cbbTieuChi.SelectedIndex, searchTextBox.Text);
                        Load(dt);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập nội dung cần tìm kiếm !");
                    }
                    searchClicked = false;
                    break;
                case 3:
                    if (searchTextBox.Text != string.Empty)
                    {
                        dt = phieuNhapBUS.TimKiem(cbbTieuChi.SelectedIndex, searchTextBox.Text);
                        Load(dt);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập nội dung cần tìm kiếm !");
                    }
                    searchClicked = false;
                    break;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ThemPhieuNhap themphieunhap = new();
            themphieunhap.ShowDialog();
        }
    }
}
