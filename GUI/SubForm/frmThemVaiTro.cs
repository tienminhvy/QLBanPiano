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
    public partial class frmThemVaiTro : Form
    {
        frmPhanQuyen frmPhanQuyen;
        public frmThemVaiTro(frmPhanQuyen f)
        {
            frmPhanQuyen = f;
            InitializeComponent();
        }

        VaiTroBUS bus = new VaiTroBUS();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenVaiTro.Text == string.Empty)
            {
                new Msg("Vui lòng nhập tên vai trò cần thêm", "err");
                return;
            }

            if (txtTenVaiTro.Text.Any(char.IsDigit))
            {
                new Msg("Tên vai trò cần thêm không được chứa ký tự số", "err");
                return;
            }

            if (bus.Them(txtTenVaiTro.Text, ""))
            {
                new Msg("Thêm thành công", "");
                frmPhanQuyen.Init();
                Dispose();
            }
        }

        private void frmThemVaiTro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
