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

namespace QLBanPiano.GUI
{
    public partial class frmThemChiTietPhieuNhap : Form
    {
        private NhacCuBUS nhacCuBUS = new();
        private ChiTietPhieuNhap chitiet = new();
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
            //Init combobox value list
            List<int> list = nhacCuBUS.getListId();
            nc_idComboBox.Items.Clear();
            nc_idComboBox.DataSource = list;
            nc_idComboBox.SelectedIndex = 0;
            //
            int id = Convert.ToInt32(nc_idComboBox.SelectedItem.ToString());
            ct_priceTextBox.Text = nhacCuBUS.getPrice(id).ToString();
        }
        private void ConfirmAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ct_slTextBox.Text != string.Empty)
                {
                    chitiet.phieunhap_Id = Convert.ToInt32(id_pnTextBox.Text);
                    chitiet.nhaccu_Id = Convert.ToInt32(nc_idComboBox.SelectedValue);
                    chitiet.DonGia = Convert.ToInt32(ct_priceTextBox.Text);
                    chitiet.SoLuong = Convert.ToInt16(ct_slTextBox.Text);

                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public ChiTietPhieuNhap getChiTiet()
        {
            return chitiet;
        }
        private void CancelAddBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ct_slTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                // Nếu là chữ cái, ngăn người dùng nhập bằng cách xử lý sự kiện
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void ct_slTextBox_TextChanged(object sender, EventArgs e)
        {
            int quantity = 0;
            if (ct_slTextBox.Text != string.Empty) quantity = Convert.ToInt32(ct_slTextBox.Text);
            if (quantity > 100)
            {
                MessageBox.Show("Số lượng nhập tối đa 100 với 1 mặt hàng !");
                ct_slTextBox.Text = string.Empty;
                ct_slTextBox.Focus();
            }
            else
            {
                long value = 0;
                long chiphi = Convert.ToInt64(ct_priceTextBox.Text);
                value = chiphi * quantity;
                //Init totalTextBox
                totalTextBox.Text = string.Format("{0}     VNĐ", value.ToString());
                totalTextBox.TextAlign = HorizontalAlignment.Right;
            }
        }

        private void nc_idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nc_idComboBox.SelectedItem.ToString());
            ct_priceTextBox.Text = nhacCuBUS.getPrice(id).ToString();
        }
    }
}
