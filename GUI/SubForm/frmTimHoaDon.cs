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

namespace QLBanPiano.GUI.SubForm
{
    public partial class frmTimHoaDon : Form
    {
        HoaDonBUS hoaDonBus = new();
        public static DataTable temp = new();
        public static bool searched = false;
        frmQLHoaDon parent;
        public frmTimHoaDon(frmQLHoaDon parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void TimHoaDon_Load(object sender, EventArgs e)
        {

        }
        void Init()
        {
        }

        private void cbbTieuChi_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtTieuChi_MouseLeave(object sender, EventArgs e)
        {
            //Khong can do an nham ay ma ehe
        }

        private void txtTieuChi_Leave(object sender, EventArgs e)
        {
        }

        private void txtTieuChi_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
        }

        private void TimHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnTimTheoNgay_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dateTuNgay.Value;
            DateTime denNgay = dateDenNgay.Value;

            if (tuNgay.Date > denNgay.Date) {
                new Msg("Trường từ ngày phải trước giá trị trường đến ngày!", "err");
                return;
            }

            string strTuNgay = tuNgay.ToShortDateString();
            string strDenNgay = denNgay.ToShortDateString();

            string tieuChi = string.Format("{0},{1}", strTuNgay, strDenNgay);
            HoaDonBUS hdBUS = new HoaDonBUS();
            parent.LoadDt(hdBUS.TimKiem(1, tieuChi));
            this.Dispose();
        }
    }
}
