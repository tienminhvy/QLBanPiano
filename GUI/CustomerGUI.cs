using QLBanPiano.GUI.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanPiano.GUI
{
    public partial class CustomerGUI : Form
    {
        public CustomerGUI()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemKhachHang frm2 = new frmThemKhachHang();
            frm2.Show();
        }
    }
}
