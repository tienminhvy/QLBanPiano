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
    public partial class frmThemChiTietPhieuNhap : Form
    {
        public frmThemChiTietPhieuNhap()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            //Init totalTextBox
            int value = 0;
            totalTextBox.Text = string.Format("{0}     VNĐ", value.ToString());
            totalTextBox.TextAlign = HorizontalAlignment.Right;
            //Init id_pnTextBox 
            id_pnTextBox.Text = frmThemPhieuNhap.id.ToString();
            id_pnTextBox.TextAlign = HorizontalAlignment.Center;
        }
    }
}
