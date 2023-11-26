using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using QLBanPiano.BUS;
using QLBanPiano.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLBanPiano.GUI
{
    public partial class frmThongKe : Form
    {
        ThongKeBUS thongKeBUS = new ThongKeBUS();
        DateTime now = DateTime.Now;
        public frmThongKe()
        {

            InitializeComponent();
            LoadComponent();
            LoadThongKeTheoNam(now.Year.ToString());
            

        }

        public void LoadComponent()
        {
            int yearNow = now.Year;
            for (int i = 0; i < 10; i++)
            {
                cbbChonNam.Items.Add(yearNow--);
            }
            cbbChonNam.SelectedIndex = 0;
            cbbChonThang.SelectedIndex = 0;
        }
        public void LoadThongKeTheoNam(string nam)
        {

            List<long> tongChi = thongKeBUS.TongChiTheoThang(nam);
            List<long> tongThu = thongKeBUS.TongThuTheoThang(nam);


            //Load Bieu Do Thong Ke
            pvDoanhThu.Model = new PlotModel { Title = "Thống Kê Doanh Thu Năm " + nam};

            var linearAxisX = new LinearAxis { Position = AxisPosition.Bottom, Title = "Tháng", Minimum = 1, Maximum = 12 };
            linearAxisX.StringFormat = "0";
            pvDoanhThu.Model.Axes.Add(linearAxisX);
            var linearAxisY = new LinearAxis { Position = AxisPosition.Left, Title = "Doanh thu (triệu VNĐ)" };
            linearAxisY.StringFormat = "0,,";
            pvDoanhThu.Model.Axes.Add(linearAxisY);
            var lineSeries = new LineSeries();
            lineSeries.Points.Add(new DataPoint(1, tongThu[0] - tongChi[0]));
            lineSeries.Points.Add(new DataPoint(2, tongThu[1] - tongChi[1]));
            lineSeries.Points.Add(new DataPoint(3, tongThu[2] - tongChi[2]));
            lineSeries.Points.Add(new DataPoint(4, tongThu[3] - tongChi[3]));
            lineSeries.Points.Add(new DataPoint(5, tongThu[4] - tongChi[4]));
            lineSeries.Points.Add(new DataPoint(6, tongThu[5] - tongChi[5]));
            lineSeries.Points.Add(new DataPoint(7, tongThu[6] - tongChi[6]));
            lineSeries.Points.Add(new DataPoint(8, tongThu[7] - tongChi[7]));
            lineSeries.Points.Add(new DataPoint(9, tongThu[8] - tongChi[8]));
            lineSeries.Points.Add(new DataPoint(10, tongThu[9] - tongChi[9]));
            lineSeries.Points.Add(new DataPoint(11, tongThu[10] - tongChi[10]));
            lineSeries.Points.Add(new DataPoint(12, tongThu[11] - tongChi[11]));
            lineSeries.StrokeThickness = 2;
            pvDoanhThu.Model.Series.Clear();
            pvDoanhThu.Model.Series.Add(lineSeries);


            //Load table Thong Ke

            lvDoanhThu.Items.Clear();
            lvDoanhThu.Columns.Clear();
            lvDoanhThu.Columns.Add("Tháng", 60);
            lvDoanhThu.Columns.Add("Tổng thu (VND)", 350);
            lvDoanhThu.Columns.Add("Tổng chi (VND)", 350);
            lvDoanhThu.Columns.Add("Lợi nhuận (VND)", 270);
            lvDoanhThu.Columns[0].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            lvDoanhThu.Columns[1].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            lvDoanhThu.Columns[2].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            lvDoanhThu.Columns[3].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;


            for (int i = 0; i < 12; i++)
            {
                int thang = i + 1;
                long loiNhuan = tongThu[i] - tongChi[i];
                ListViewItem listViewItem = new ListViewItem(new String[]
                {
                    thang.ToString(),
                    tongThu[i].ToString(),
                    tongChi[i].ToString(),
                    loiNhuan.ToString()
                });
                lvDoanhThu.Items.Add(listViewItem);
            }

        }

        private void cbbChonNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChonThang.SelectedItem == null || cbbChonNam.SelectedItem == null)
            {
                return;
            }

            if (cbbChonThang.SelectedItem.ToString().Equals("Cả Năm"))
            {
                LoadThongKeTheoNam(cbbChonNam.SelectedItem.ToString());
            }
            else
            {
                LoadThongKeTheoThang(cbbChonNam.SelectedItem.ToString(), cbbChonThang.SelectedItem.ToString());
            }
        }

        public void LoadThongKeTheoThang(string nam, string thang)
        {
            List<long> tongChi = thongKeBUS.TongChiTheoNgay(nam, thang);
            List<long> tongThu = thongKeBUS.TongThuTheoNgay(nam, thang);

            //Load Bieu Do Thong Ke
            pvDoanhThu.Model = new PlotModel { Title = "Thống Kê Doanh Thu Tháng " + thang + " Năm " + nam};

            int soNgayTrongThang = DateTime.DaysInMonth(int.Parse(nam), int.Parse(thang));
            var linearAxisX = new LinearAxis { Position = AxisPosition.Bottom, Title = "Ngày", Minimum = 1, Maximum = soNgayTrongThang };
            linearAxisX.StringFormat = "0";
            pvDoanhThu.Model.Axes.Add(linearAxisX);
            var linearAxisY = new LinearAxis { Position = AxisPosition.Left, Title = "Doanh thu (triệu VNĐ)" };
            linearAxisY.StringFormat = "0,,";
            pvDoanhThu.Model.Axes.Add(linearAxisY);
            var lineSeries = new LineSeries();
            for (int i = 0; i < soNgayTrongThang; i++)
            {
                lineSeries.Points.Add(new DataPoint(i + 1, tongThu[i] - tongChi[i]));
            }
            lineSeries.StrokeThickness = 2;
            pvDoanhThu.Model.Series.Clear();
            pvDoanhThu.Model.Series.Add(lineSeries);


            //Load table thong ke
            lvDoanhThu.Items.Clear();
            lvDoanhThu.Columns.Clear();
            lvDoanhThu.Columns.Add("Ngày", 60);
            lvDoanhThu.Columns.Add("Tổng thu (VND)", 350);
            lvDoanhThu.Columns.Add("Tổng chi (VND)", 350);
            lvDoanhThu.Columns.Add("Lợi nhuận (VND)", 270);
            lvDoanhThu.Columns[0].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            lvDoanhThu.Columns[1].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            lvDoanhThu.Columns[2].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            lvDoanhThu.Columns[3].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            for (int i = 0; i < soNgayTrongThang; i++)
            {
                int ngay = i + 1;
                long loiNhuan = tongThu[i] - tongChi[i];
                ListViewItem listViewItem = new ListViewItem(new String[]
                {
                    ngay.ToString(),
                    tongThu[i].ToString(),
                    tongChi[i].ToString(),
                    loiNhuan.ToString()
                });
                lvDoanhThu.Items.Add(listViewItem);
            }
        }

        private void cbbChonThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChonThang.SelectedItem == null || cbbChonNam.SelectedItem ==null)
            {
                return;
            }
            if (cbbChonThang.SelectedItem.ToString().Equals("Cả Năm"))
            {
                LoadThongKeTheoNam(cbbChonNam.SelectedItem.ToString());
            }
            else
            {
                LoadThongKeTheoThang(cbbChonNam.SelectedItem.ToString(), cbbChonThang.SelectedItem.ToString());
            }
        }
    }
}
