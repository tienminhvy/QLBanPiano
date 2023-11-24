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
    public partial class frmQLPhieuNhap : Form
    {
        ThemPhieuNhapBUS bus = new();
        public static int id;
        public ThemPhieuNhap()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            //Init id cho id _pnTextBox
            id_pnTextBox.Text = bus.LayID().ToString();
            id = bus.LayID();
            id_pnTextBox.TextAlign = HorizontalAlignment.Center;
            //Init DateTimePicker giá trị current time 
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy hh:mm:ss tt";
            //Init totalTextBox
            int value = 0;
            totalTextBox.Text = string.Format("{0}     VNĐ", value.ToString());
            totalTextBox.TextAlign = HorizontalAlignment.Right;

        }

        private void ThemPhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void ct_addBtn_Click(object sender, EventArgs e)
        {
            ThemChiTietPhieuNhap themCtpn = new();
            themCtpn.ShowDialog();
        }

        private void CancelAddBtn_Click(object sender, EventArgs e)
        {
            if (chiTietPhieuNhapGridView.RowCount > 0 && chiTietPhieuNhapGridView.ColumnCount > 0)
            {

            }
            else
            {
                this.Close();
            }
        }
    }
}
