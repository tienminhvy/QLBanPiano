using Microsoft.VisualBasic;
using QLBanPiano.BUS;
using QLBanPiano.DTO;
using QLBanPiano.GUI.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private ChiTietHoaDonBUS chitietBus = new();
        private HoaDonBUS hoaDonBus = new HoaDonBUS();
        private int doubleClickRowID = -1;
        private DataTable searchResult = new();
        private IOFileBUS fileHandler = new();
        private DataTable exportTable = new();
        private HoaDonPdfExcelBUS exportBus = new();
        private List<string> list = new List<string> { "ID", "Thời gian", "Mã nhân viên", "Mã khách hàng", "Mã nhạc cụ","Đơn giá", "SL" };
        private bool imported = true;
        private NhacCuBUS nhacCuBus = new();
        public frmQLHoaDon()
        {
            InitializeComponent();
            Clock.Start();
            Init();
        }
        void Init()
        {
            DataTable dt = hoaDonBus.LayToanBoDS();
            exportTable = dt;
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
            hoaDonCountTxtBox.Text = hoaDonBus.SoLuong("id > -1").ToString();
            //Init cho combobox tiêu chí
            string[] items = { "ID", "Thời gian", "Mã nhân viên", "Mã khách hàng", "Tên nhân viên", "Tên khách hàng" };
            cbbTieuChi.Items.Clear();
            cbbTieuChi.Items.AddRange(items);
            cbbTieuChi.SelectedIndex = 0;
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
                frmChiTietHoaDon ct = new frmChiTietHoaDon(doubleClickRowID);
                ct.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chọn quá nhiều mục" + ex.Message);
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

        private void Clock_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("HH:mm:ss tt");
            ClockLabel.ForeColor = Color.FromArgb(153, 50, 204);
            CalendarLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
            CalendarLabel.ForeColor = Color.FromArgb(153, 50, 204);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (txtTieuChi.Text != string.Empty)
            {
                searchResult = hoaDonBus.TimKiem(cbbTieuChi.SelectedIndex, txtTieuChi.Text);
                Loads(searchResult);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập nội dung cần tìm kiếm ");
            }
        }
        void Loads(DataTable dt)
        {
            hoaDonGridView.DataSource = null;
            hoaDonGridView.Rows.Clear();
            hoaDonGridView.DataSource = dt;
            hoaDonGridView.ReadOnly = true;
            hoaDonGridView.AllowUserToResizeColumns = false;
            hoaDonGridView.AllowUserToResizeRows = false;
            hoaDonGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hoaDonGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewColumn col in hoaDonGridView.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void searchBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                searchBtn_Click(sender, e);
            }
        }

        private void txtTieuChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                searchBtn_Click(sender, e);
            }
        }

        private void resetBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                resetBtn_Click(sender, e);
            }
        }

        private void ImportBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ImportBtn_Click(sender, e);
            }
        }

        private void ExportBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ExportBtn_Click(sender, e);
            }
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            // Thiết lập các thuộc tính của OpenFileDialog
            ofd.Title = "Chọn file Excel";
            ofd.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"; // Chỉ cho phép chọn các file Excel
            ofd.CheckFileExists = true; // Kiểm tra file tồn tại
            ofd.CheckPathExists = true; // Kiểm tra đường dẫn hợp lệ
            // Mở cửa sổ OpenFileDialog và xử lý kết quả
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string selectedFilePath = ofd.FileName;
                    List<string> temp = fileHandler.GetListHeader(selectedFilePath);
                    List<HoaDonPDFExcel> listImport = new();
                    if(temp.SequenceEqual(list) == true)
                    {
                        DataTable raw = fileHandler.ImportFormExcelToDataTable(selectedFilePath);
                        DataTable rawClone = hoaDonBus.getClone(raw);
                        int rowCount = raw.Rows.Count;
                        while(rowCount > 0)
                        {
                            string minId = rawClone.AsEnumerable().Min(row => row.Field<string>("ID"));
                            int min = int.Parse(minId);
                            DataTable processed = hoaDonBus.splitFromExcelTableById(rawClone, min);
                            HoaDonPDFExcel hoadon = new();
                            hoadon = hoaDonBus.getHoaDon(processed);
                            int numberOfRowMin = fileHandler.returnIdCount(rawClone, min);
                            if (chitietBus.ValidateList(hoadon.List) == true)
                            {
                                listImport.Add(hoadon);

                                rowCount -= numberOfRowMin;
                                while (numberOfRowMin > 0)
                                {
                                    rawClone.Rows.RemoveAt(0);
                                    numberOfRowMin--;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Định dạng excel không hợp lệ !");
                                imported = false;
                                break;
                            }
                        }
                        if (hoaDonBus.ValidateList(listImport) == true && imported == true)
                        {
                            foreach (HoaDonPDFExcel hoadon in listImport)
                            {
                                try
                                {
                                    DataTable chitietTable = chitietBus.convertToDataTable(hoadon.List);
                                    DataTable updateNhaccu = chitietTable.Clone();
                                    updateNhaccu.Columns.Remove("ID");
                                    updateNhaccu.Columns.Remove("Đơn giá");
                                    foreach (DataRow row in chitietTable.Rows)
                                    {
                                        updateNhaccu.ImportRow(row);
                                    }
                                    /*chitietTable.Columns["Mã nhạc cụ"].SetOrdinal(0);
                                    chitietTable.Columns["ID"].SetOrdinal(1);
                                    chitietTable.Columns["Đơn giá"].SetOrdinal(2);
                                    chitietTable.Columns["SL"].SetOrdinal(3);*/

                                    chitietTable.Columns["ID"].ColumnName = "id_hdpn";
                                    chitietTable.Columns["Mã nhạc cụ"].ColumnName = "nhaccu_id";
                                    chitietTable.Columns["Đơn giá"].ColumnName = "donGia";
                                    chitietTable.Columns["SL"].ColumnName = "soLuong";
                                    if (fileHandler.ImportConstraint(chitietTable, "chitiet_hdpn", hoaDonBus.getSqlString(hoadon)) == true)
                                    {
                                        foreach (DataRow row in updateNhaccu.Rows)
                                        {
                                            nhacCuBus.giamSL(Convert.ToInt32(row["Mã nhạc cụ"]), Convert.ToInt16(row["SL"]));
                                        }
                                    }
                                    else
                                    {
                                        imported = false;
                                        break;
                                    }
                                }catch(Exception ex)
                                {
                                    MessageBox.Show("Sai định dạng " +ex.Message);
                                    imported = false;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Thông tin import vào không hợp lệ !");
                            imported = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Format của file nhập không hợp lệ");
                        imported = false;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Người dùng đã hủy việc chọn file.");
                imported = false;
            }
            if(imported)
            {
                MessageBox.Show("Import file thành công");
                //resetBtn_Click(sender, e);
            }

        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.xlsx;*.xls";
            sfd.Title = "Chọn nơi lưu file";
            sfd.FilterIndex = 1;
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = sfd.FileName;
                DataTable export = exportBus.formatToExport(exportBus.DatatableToList(exportTable));
                DataRow row = export.Rows[0];
                bool return_val = fileHandler.ExportToExcel(export, filename);
                if (return_val)
                {
                    MessageBox.Show("Export Excel thành công");
                    Process.Start(new ProcessStartInfo(filename) { UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show("Export thất bại !");
                }
            }
        }

        private void frmQLHoaDon_Load(object sender, EventArgs e)
        {

        }

    }
}
