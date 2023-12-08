using QLBanPiano.BUS;
using QLBanPiano.DTO;
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
    public partial class frmTimNhanVien : Form
    {
        frmQLNhanVien parent;
        public frmTimNhanVien(frmQLNhanVien parent)
        {
            InitializeComponent();
            this.parent = parent;
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

            NhanVienBUS nhanvien = new NhanVienBUS();
            List<DoiTuong> DSKetQuaTimKiem = nhanvien.TimKiem("Ngày vào làm", tieuChi);
            parent.HienThiDSNhanVien(DSKetQuaTimKiem);
            this.Dispose();
        }

        private void frmTimNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
