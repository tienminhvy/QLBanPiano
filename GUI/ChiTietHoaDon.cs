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

namespace QLBanPiano.GUI.QuanLyHoaDon_PhieuNhap
{
    public partial class ChiTietHoaDon : Form
    {
        ChiTietHoaDonBUS chiTietHoaDonBUS = new();
        public ChiTietHoaDon()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            if (QLHD.doubleClickRowID != -1)
            {
                DataTable dt = chiTietHoaDonBUS.LayChiTietHoaDon(QLHD.doubleClickRowID);
                DataTable datasource = dt.Clone();
                foreach (DataRow row in dt.Rows)
                {
                    datasource.ImportRow(row);
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
    }
}
