using OxyPlot;
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
using OxyPlot.Series;
using OxyPlot.Axes;

namespace QLBanPiano.GUI.SubForm
{
    public partial class frmThongKeThuongHieu : Form
    {
        ThuongHieuBUS thuongHieuBUS = new ThuongHieuBUS();
        ThongKeBUS thongKeBUS = new ThongKeBUS();
        DateTime now = DateTime.Now;
        public frmThongKeThuongHieu()
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
            //------------Load Bieu Do-------------
            var plotModel = new PlotModel { Title = "Thống kê thương hiệu bán được trong năm " + nam, Background = OxyColors.White };
            var pieSeries = new PieSeries();
            bool flag = false;
            List<string> dsMaThuongHieu = thuongHieuBUS.LayDSMaThuongHieu();
            foreach (string maTH in dsMaThuongHieu)
            {
                int soLuong = thongKeBUS.SoLuongThuongHieuDaBanTrongNam(nam, maTH);
                if (soLuong > 0)
                {
                    pieSeries.Slices.Add(new PieSlice(maTH, soLuong));
                    flag = true;
                }
            }

            
            plotModel.Series.Add(pieSeries);
            pvThuongHieu.Model = plotModel;

            //----------Load bang so lieu-------------
            lvThuongHieu.Columns.Clear();
            lvThuongHieu.Items.Clear();
            lvThuongHieu.Columns.Add("Thương Hiệu", 120);
            lvThuongHieu.Columns.Add("Số Sản Phẩm", 110);

            foreach (string maTH in dsMaThuongHieu)
            {
                ListViewItem listViewItem = new ListViewItem(new String[]
                {
                    maTH,
                    thongKeBUS.SoLuongThuongHieuDaBanTrongNam(nam,maTH).ToString()
                });

                lvThuongHieu.Items.Add(listViewItem);
            }
            if (!flag)
            {
                MessageBox.Show("Năm này ế :((", "Chia Buồn");
            }
        }

        public void LoadThongKeTheoThang(string nam, string thang)
        {
            var plotModel = new PlotModel { Title = "Thống kê thương hiệu bán được trong tháng " + thang + "/" + nam, Background = OxyColors.White };
            var pieSeries = new PieSeries();
            List<string> dsMaThuongHieu = thuongHieuBUS.LayDSMaThuongHieu();
            bool flag = false;
            foreach (string maTH in dsMaThuongHieu)
            {
                int soLuong = thongKeBUS.SoLuongThuongHieuDaBanTrongThang(nam, thang, maTH);
                if (soLuong > 0)
                {
                    pieSeries.Slices.Add(new PieSlice(maTH, soLuong));
                    flag = true;
                }
            }
            
            plotModel.Series.Add(pieSeries);
            pvThuongHieu.Model = plotModel;

            //----------Load bang so lieu-------------
            lvThuongHieu.Columns.Clear();
            lvThuongHieu.Items.Clear();
            lvThuongHieu.Columns.Add("Thương Hiệu", 120);
            lvThuongHieu.Columns.Add("Số Sản Phẩm", 110);

            foreach (string maTH in dsMaThuongHieu)
            {
                ListViewItem listViewItem = new ListViewItem(new String[]
                {
                    maTH,
                    thongKeBUS.SoLuongThuongHieuDaBanTrongThang(nam,thang, maTH).ToString()
                });

                lvThuongHieu.Items.Add(listViewItem);
            }
            if (!flag)
            {
                MessageBox.Show("Tháng này ế :((", "Chia Buồn");
            }
        }

        private void frmThongKeThuongHieucs_Load(object sender, EventArgs e)
        {

        }

        private void cbbChonThang_SelectedIndexChanged(object sender, EventArgs e)
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

        private void plotView1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
