using QLBanPiano.BUS;
using QLBanPiano.DTO;
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
    public partial class frmChiTietHoaDon : Form
    {
        ChiTietHoaDonBUS chiTietHoaDonBUS = new();
        HoaDonPdfExcelBUS hoadonPdfBus = new();
        IOFileBUS fileHandler = new();
        DataTable export = new();
        DataTable temp = new();
        int hoadon_id = -1;
        public frmChiTietHoaDon()
        {
            InitializeComponent();
            Init();
        }
        public frmChiTietHoaDon(int id)
        {
            this.hoadon_id = id;
            InitializeComponent();
            Init();
        }
        void Init()
        {
            if (hoadon_id != -1)
            {
                DataTable dt = chiTietHoaDonBUS.LayChiTietHoaDon(hoadon_id);
                temp = dt.Clone();
                DataTable datasource = dt.Clone();
                foreach (DataRow row in dt.Rows)
                {
                    datasource.ImportRow(row);
                    temp.ImportRow(row);
                }
                datasource.Columns.Remove("ID");
                datasource.Columns.Remove("Thời gian");
                datasource.Columns.Remove("Mã nhân viên");
                datasource.Columns.Remove("Tên nhân viên");
                datasource.Columns.Remove("Mã khách hàng");
                datasource.Columns.Remove("Tên khách hàng");

                datasource.Columns.Add("Tổng tiền", typeof(int));
                long total = 0;
                foreach (DataRow row in datasource.Rows)
                {
                    row["Tổng tiền"] = Convert.ToInt64(row["SL"]) * Convert.ToInt64(row["Đơn giá"]);
                    total += Convert.ToInt64(row["Tổng tiền"]);
                }
                export = datasource.Clone();
                foreach(DataRow row in datasource.Rows)
                {
                    export.ImportRow(row);
                }
                totalTextBox.Text = total.ToString() + "  VNĐ";
                totalTextBox.TextAlign = HorizontalAlignment.Right;

                cthdGridView.DataSource = null;
                cthdGridView.Rows.Clear();
                cthdGridView.DataSource = datasource;
                cthdGridView.ReadOnly = true;
                cthdGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //Load lên text box 
                idHoaDon.Text = dt.Rows[0]["ID"].ToString();
                idHoaDon.TextAlign = HorizontalAlignment.Center;
                nv_idTextBox.Text = dt.Rows[0]["Mã nhân viên"].ToString();
                nv_nameTextBox.Text = dt.Rows[0]["Tên nhân viên"].ToString();
                kh_idTextBox.Text = dt.Rows[0]["Mã khách hàng"].ToString();
                kh_nameTextBox.Text = dt.Rows[0]["Tên khách hàng"].ToString();
                //Load lên date time picker với định dạng mới 
                DateTime result = (DateTime)dt.Rows[0]["Thời gian"];
                dateTimePicker1.Value = result;
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy hh:mm:ss tt";


            }
        }

        public void XuatHoaDonPDF(int hoadon_id)
        {
            HoaDonPDFExcel hoaDon = new();
            hoaDon = hoadonPdfBus.getHoaDonByID(hoadon_id);
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "PDF Files|*.pdf";
            sfd.Title = "Chọn nơi lưu file";

            // Hiển thị SaveFileDialog
            DialogResult result = sfd.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filename = sfd.FileName;
                export.Columns.Remove("Mã nhạc cụ");
                bool return_value = fileHandler.ExportHoaDonToPdf(hoaDon, filename);
                if (return_value)
                {
                    MessageBox.Show("Xuất hóa đơn thành công !");
                    Process.Start(new ProcessStartInfo(filename) { UseShellExecute = true });
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void exportFileBtn_Click(object sender, EventArgs e)//Export bill btn
        {
            XuatHoaDonPDF(hoadon_id);
        }
        private void exportFileBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                exportFileBtn_Click(sender, e);
            }
        }
        
    }
}
