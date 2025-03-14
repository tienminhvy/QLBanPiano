﻿using QLBanPiano.BUS;
using QLBanPiano.DTO;
using QLBanPiano.GUI.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanPiano.GUI
{
    public partial class frmQLPhieuNhap : Form
    {

        private PhieuNhapBUS phieuNhapBUS = new();
        private ChiTietPhieuNhapBUS chiTietPhieuNhapBUS = new();
        public static int doubleClickRowID = -1;
        private bool searchClicked = false;
        private IOFileBUS fileHandler = new();
        private NhacCuBUS nhacCuBUS = new();
        private List<string> list = new List<string> { "ID", "Thời gian", "Mã nhân viên", "Mã nhạc cụ", "Đơn giá", "SL" };
        private DataTable tableToExport = new();
        private List<PhieuNhapExcel> ExportList = new();
        private bool imported = true;
        public frmQLPhieuNhap()
        {
            InitializeComponent();
            Timer.Start();
            Init();
            SearchTextBox_Init();

            exportFileBtn.Enabled = false;
            exportFileBtn.Visible = false;
            importFileBtn.Enabled = false;
            importFileBtn.Visible = false;
            foreach (string quyen in frmChinh.dsQuyen)
            {
                if (quyen == "nhapXuat")
                {
                    exportFileBtn.Enabled = true;
                    exportFileBtn.Visible = true;
                    importFileBtn.Enabled = true;
                    importFileBtn.Visible = true;
                    break;
                }
            }
        }
        void Init()
        {
            //Set value và định dạng cho data grid view 
            DataTable dt = phieuNhapBUS.LayToanBoDS();
            tableToExport = dt;
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
            string[] list = { "ID", "Thời gian", "Mã nhân viên" };
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
                    searchTextBox.PlaceholderText = "Nhập thời gian (VD: 2023-11-11 8:30:00 AM )";
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
                    new Msg("Không có giá trị trong dòng này ", "err");
                }
            }
        }

        private void phieuNhapGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = phieuNhapGridView.Rows[e.RowIndex];
                doubleClickRowID = (int)selectedRow.Cells[0].Value;
                frmChiTietPhieuNhap ctpn = new();
                ctpn.ShowDialog();
            }
            catch (Exception ex)
            {
                new Msg(ex.Message, "err");
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
            searchTextBox.Enabled = true;
            switch (cbbTieuChi.SelectedIndex)
            {
                case 0:
                    searchTextBox.Text = string.Empty;
                    searchTextBox.PlaceholderText = "Nhập ID (VD: 2 )";
                    searchTextBox.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
                case 1: // date
                    searchTextBox.Text = string.Empty;
                    searchTextBox.Enabled = false;
                    searchTextBox.PlaceholderText = "";
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

        public void LoadDt(DataTable dt)
        {
            phieuNhapGridView.DataSource = dt;
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
                        new Msg("Vui lòng nhập nội dung cần tìm kiếm !", "err");
                    }
                    searchClicked = false;
                    break;
                case 1: // date
                    // new frmT
                    frmTimPhieuNhap f = new frmTimPhieuNhap(this);
                    f.ShowDialog();
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
                        new Msg("Vui lòng nhập nội dung cần tìm kiếm !", "err");
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
                        new Msg("Vui lòng nhập nội dung cần tìm kiếm !", "err");
                    }
                    searchClicked = false;
                    break;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            frmThemPhieuNhap themphieunhap = new();
            themphieunhap.ShowDialog();
            Init();
        }

        private void importFileBtn_Click(object sender, EventArgs e)
        {
            imported = true;
            try
            {
                OpenFileDialog ofd = new();
                // Thiết lập các thuộc tính của OpenFileDialog
                ofd.Title = "Chọn file Excel";
                ofd.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"; // Chỉ cho phép chọn các file Excel
                ofd.CheckFileExists = true; // Kiểm tra file tồn tại
                ofd.CheckPathExists = true; // Kiểm tra đường dẫn hợp lệ
                // Mở cửa sổ OpenFileDialog và xử lý kết quả
                DialogResult result = ofd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string selectedFilePath = ofd.FileName;
                    List<string> temp = fileHandler.GetListHeader(selectedFilePath);
                    List<PhieuNhapExcel> listImport = new();
                    if (temp.SequenceEqual(list) == true)
                    {
                        DataTable raw = fileHandler.ImportFormExcelToDataTable(selectedFilePath);
                        DataTable rawClone = phieuNhapBUS.getClone(raw);
                        int rowCount = raw.Rows.Count;
                        while (rowCount > 0)
                        {
                            string minId = rawClone.AsEnumerable().Min(row => row.Field<string>("ID"));
                            int min = int.Parse(minId);
                            DataTable processed = phieuNhapBUS.splitFromExcelTableById(rawClone, min);
                            PhieuNhapExcel ph = new();
                            ph = phieuNhapBUS.getPhieuNhap(processed);
                            int numberOfRowMin = fileHandler.returnIdCount(rawClone, min);
                            if (chiTietPhieuNhapBUS.ValidateList(ph.PhieuNhapList) == true)
                            {
                                listImport.Add(ph);

                                rowCount -= numberOfRowMin;
                                while (numberOfRowMin > 0)
                                {
                                    rawClone.Rows.RemoveAt(0);
                                    numberOfRowMin--;
                                }
                            }
                            else
                            {
                                new Msg("Định dạng excel không hợp lệ !", "err");
                                imported = false;
                                break;
                            }
                        }
                        if (phieuNhapBUS.ValidateList(listImport))
                        {
                            foreach (PhieuNhapExcel ph in listImport)
                            {
                                try
                                {
                                    DataTable chitietTable = chiTietPhieuNhapBUS.convertToDataTable(ph.PhieuNhapList);
                                    DataTable updateNhaccu = chitietTable.Clone();
                                    updateNhaccu.Columns.Remove("ID");
                                    updateNhaccu.Columns.Remove("Đơn giá");
                                    foreach (DataRow row in chitietTable.Rows)
                                    {
                                        updateNhaccu.ImportRow(row);
                                    }
                                    chitietTable.Columns["ID"].ColumnName = "id_hdpn";
                                    chitietTable.Columns["Mã nhạc cụ"].ColumnName = "nhaccu_id";
                                    chitietTable.Columns["Đơn giá"].ColumnName = "donGia";
                                    chitietTable.Columns["SL"].ColumnName = "soLuong";
                                    if (fileHandler.ImportConstraint(chitietTable, "chitiet_hdpn", phieuNhapBUS.getSqlString(ph)) == true)
                                    {
                                        foreach (DataRow row in updateNhaccu.Rows)
                                        {
                                            nhacCuBUS.tangSL(Convert.ToInt32(row["Mã nhạc cụ"]), Convert.ToInt16(row["SL"]));
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    imported = false;
                                    new Msg("Lỗi : " + ex.Message, "err");
                                }
                            }
                        }
                        else
                        {
                            new Msg("Thông tin import vào không hợp lệ !", "err");
                            imported = false;
                        }
                    }
                    else
                    {
                        new Msg("Format của file nhập không hợp lệ", "err");
                        imported = false;
                    }
                }
                else
                {
                    new Msg("Người dùng đã hủy việc chọn file.", "err");
                    imported = false;
                }
                if (imported == true)
                {
                    new Msg("Import file thành công");
                    ResetBtn_Click(sender, e);
                }

            }
            catch (Exception ex)
            {
                new Msg(ex.Message);
            }
            Init();
        }

        private void exportFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Xuất phiếu nhập";
                sfd.Filter = "Excel Files|*.xlsx;*.xls";
                DialogResult result = sfd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string filename = sfd.FileName;
                    DataTable table = phieuNhapBUS.formatToExport(phieuNhapBUS.convertDataTableToList(tableToExport));
                    if (fileHandler.ExportToExcel(table, filename))
                    {
                        new Msg("Xuất file excel thành công");
                        Process.Start(new ProcessStartInfo(filename) { UseShellExecute = true });
                    }
                    else
                    {
                        new Msg("Xuất file thất bại", "err");
                    }
                }
            }
            catch (Exception ex)
            {
                new Msg(ex.Message, "err");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
            CalendarLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
            ClockLabel.ForeColor = Color.FromArgb(153, 50, 204);
            CalendarLabel.ForeColor = Color.FromArgb(153, 50, 204);

        }
    }
}

