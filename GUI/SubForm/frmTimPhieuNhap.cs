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
    public partial class frmTimPhieuNhap : Form
    {
        frmQLPhieuNhap parent;
        public frmTimPhieuNhap(frmQLPhieuNhap parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void btnTimTheoNgay_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dateTuNgay.Value;
            DateTime denNgay = dateDenNgay.Value;

            if (tuNgay.Date > denNgay.Date)
            {
                new Msg("Trường từ ngày phải trước giá trị trường đến ngày!", "err");
                return;
            }
            if (tuNgay.Date == denNgay.Date)
            {
                denNgay = tuNgay.AddDays(1);
            }

            string strTuNgay = tuNgay.ToShortDateString();
            string strDenNgay = denNgay.ToShortDateString();

            string tieuChi = string.Format("{0},{1}", strTuNgay, strDenNgay);
            PhieuNhapBUS hdBUS = new PhieuNhapBUS();
            parent.LoadDt(hdBUS.TimKiem(1, tieuChi));
            this.Dispose();
        }

        private void frmTimPhieuNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
