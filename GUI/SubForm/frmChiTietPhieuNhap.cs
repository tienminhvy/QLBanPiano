using QLBanPiano.BUS;
using System;
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
    public partial class frmChiTietPhieuNhap : Form
    {
        ChiTietPhieuNhapBUS ctpnBus = new();
        public frmChiTietPhieuNhap()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            if (frmQLPhieuNhap.doubleClickRowID != -1)
            {
                DataTable dt = ctpnBus.LayChiTietPhieuNhap(frmQLPhieuNhap.doubleClickRowID);
                DataTable datasource = dt.Clone();
                foreach (DataRow row in dt.Rows)
                {
                    datasource.ImportRow(row);
                }
                datasource.Columns.Remove("ID");
                datasource.Columns.Remove("Mã nhân viên");
                datasource.Columns.Remove("Nhân viên");
                datasource.Columns.Remove("Thời gian");

                datasource.Columns.Add("Tổng tiền", typeof(int));
                long total = 0;
                foreach (DataRow row in datasource.Rows)
                {
                    row["Tổng tiền"] = Convert.ToInt64(row["SL"]) * Convert.ToInt64(row["Đơn giá"]);
                    total += Convert.ToInt64(row["Tổng tiền"]);
                }
                //Load lên grid view 
                ctpnGridView.DataSource = null;
                ctpnGridView.Rows.Clear();
                ctpnGridView.DataSource = datasource;
                ctpnGridView.ReadOnly = true;
                ctpnGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //Load lên text box 
                idPhieuNhap.Text = dt.Rows[0]["ID"].ToString();
                idPhieuNhap.TextAlign = HorizontalAlignment.Center;
                totalTextBox.Text = total.ToString() + " VNĐ";
                totalTextBox.TextAlign = HorizontalAlignment.Center;
                nv_idTextBox.Text = dt.Rows[0]["Mã nhân viên"].ToString();
                nv_idTextBox.TextAlign = HorizontalAlignment.Right;
                nv_nameTextBox.Text = dt.Rows[0]["Nhân viên"].ToString();
                nv_nameTextBox.TextAlign = HorizontalAlignment.Right;
                //Load lên date time picker với định dạng mới 
                DateTime result = (DateTime)dt.Rows[0]["Thời gian"];
                dateTimePicker1.Value = result;
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy hh:mm:ss tt";

            }
        }

        private void frmChiTietPhieuNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
