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
    public partial class QLHD : Form
    {
        private HoaDonBUS hoaDonBus = new HoaDonBUS();
        public QLHD()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            DataTable dt = hoaDonBus.LayToanBoDS();
            hoaDonGridView.DataSource = null;
            hoaDonGridView.Rows.Clear();
            hoaDonGridView.DataSource = dt;
        }
    }
}
