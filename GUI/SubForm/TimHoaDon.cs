using QLBanPiano.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanPiano.GUI.SubForm
{
    public partial class TimHoaDon : Form
    {
        HoaDonBUS hoaDonBus = new();
        public static DataTable temp = new();
        public static bool searched = false;
        public TimHoaDon()
        {
            InitializeComponent();
            Init();

        }

        private void TimHoaDon_Load(object sender, EventArgs e)
        {

        }
        void Init()
        {
            string[] items = { "ID", "Thời gian", "Mã nhân viên", "Mã khách hàng","Tên nhân viên","Tên khách hàng" };
            cbbTieuChi.Items.AddRange(items);
            cbbTieuChi.SelectedIndex = 0;
        }

        private void cbbTieuChi_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbbTieuChi.SelectedIndex)
            {
                case 0:
                    txtTieuChi.Text = "Nhập ID (VD: 0 )";
                    txtTieuChi.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
                case 1:
                    txtTieuChi.Text = "Nhập thời gian (VD: 19-05-2023)";
                    txtTieuChi.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
                case 2:
                    txtTieuChi.Text = "Nhập mã nhân viên (VD: 2 )";
                    txtTieuChi.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
                case 3:
                    txtTieuChi.Text = "Nhập mã khách hàng (VD: 5 )";
                    txtTieuChi.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
                case 4:
                    txtTieuChi.Text = "Nhập tên nhân viên (VD: Minh Vy )";
                    txtTieuChi.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
                case 5:
                    txtTieuChi.Text = "Nhập tên khách hàng (VD: Văn A )";
                    txtTieuChi.ForeColor = Color.FromArgb(160, 160, 160);
                    break;
                default:
                    break;
            }
        }

        private void txtTieuChi_MouseLeave(object sender, EventArgs e)
        {
            //Khong can do an nham ay ma ehe
        }

        private void txtTieuChi_Leave(object sender, EventArgs e)
        {
            if (txtTieuChi.Text == string.Empty)
            {
                cbbTieuChi_SelectedIndexChanged(sender, e);
            }
        }

        private void txtTieuChi_MouseClick(object sender, MouseEventArgs e)
        {
            switch (txtTieuChi.Text)
            {
                case "Nhập ID (VD: 0 )":
                    txtTieuChi.Text = string.Empty;
                    break;
                case "Nhập thời gian (VD: 19-05-2023)":
                    txtTieuChi.Text = string.Empty;
                    break;
                case "Nhập mã nhân viên (VD: 2 )":
                    txtTieuChi.Text = string.Empty;
                    break;
                case "Nhập mã khách hàng (VD: 5 )":
                    txtTieuChi.Text = string.Empty;
                    break;
                case "Nhập tên nhân viên (VD: Minh Vy )":
                    txtTieuChi.Text = string.Empty;
                    break;
                case "Nhập tên khách hàng (VD: Văn A )":
                    txtTieuChi.Text = string.Empty;
                    break;
                case "":
                    break;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            txtTieuChi_MouseClick(sender, (MouseEventArgs)e);
            if (txtTieuChi.Text != string.Empty)
            {
                temp = hoaDonBus.TimKiem(cbbTieuChi.SelectedIndex, txtTieuChi.Text);
                searched = true;
                this.Close();
            }
            cbbTieuChi_SelectedIndexChanged(sender, e);
        }

        private void TimHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
