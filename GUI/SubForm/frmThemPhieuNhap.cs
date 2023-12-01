using QLBanPiano.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanPiano.GUI
{
    public partial class frmThemPhieuNhap : Form
    {
        ThemPhieuNhapBUS bus = new();
        public static int id;
        public frmThemPhieuNhap()
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
            txtIdNv.Text = frmChinh.nhanvien_id;

        }

        private void ThemPhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void ct_addBtn_Click(object sender, EventArgs e)
        {
            frmThemChiTietPhieuNhap themCtpn = new();
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

        private void confirmAddBtn_Click(object sender, EventArgs e)
        {
            if (chiTietPhieuNhapGridView.Rows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("Không có dữ liệu");
                this.Close();
            }
        }

        private void ct_addBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ct_addBtn_Click(sender, e);
            }
        }

        private void CancelAddBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CancelAddBtn_Click(sender, e);
            }
        }

        private void confirmAddBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                confirmAddBtn_Click(sender, e);
            }
        }


    }
}
