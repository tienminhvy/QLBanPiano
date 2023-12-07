using QLBanPiano.BUS;
using QLBanPiano.DTO;
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
        private ThemPhieuNhapBUS bus = new();
        private PhieuNhapBUS phieunhapBus = new();
        public static int id;
        private List<ChiTietPhieuNhap> temp;
        private ChiTietPhieuNhapBUS chitietBus = new();
        public frmThemPhieuNhap()
        {
            InitializeComponent();
            temp = new();
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
            //
            txtIdNv.Text = frmChinh.nhanvien_id;
            txtIdNv.TextAlign = HorizontalAlignment.Center;
            //
            int value2 = 0;
            ct_soLuongTextBox.Text = string.Format("{0}     ", value2.ToString());
            totalTextBox.TextAlign = HorizontalAlignment.Right;

        }
        public void LoadGridView(DataTable table)
        {
            chiTietPhieuNhapGridView.DataSource = table;
            chiTietPhieuNhapGridView.ReadOnly = true;
            chiTietPhieuNhapGridView.AllowUserToResizeColumns = false;
            chiTietPhieuNhapGridView.AllowUserToResizeRows = false;
            chiTietPhieuNhapGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            chiTietPhieuNhapGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        public void Reset()
        {
            ChiTietPhieuNhapBUS chitietBus = new();
            if (temp != null)
            {
                DataTable table = chitietBus.convertToDataTable(temp);
                LoadGridView(table);
                //Init totalTextBox
                int value = 0;
                foreach (DataRow row in table.Rows)
                {
                    value += Convert.ToInt32(row["Đơn giá"]) * Convert.ToInt32(row["SL"]);
                }
                totalTextBox.Text = string.Format("{0}     VNĐ", value.ToString());
                totalTextBox.TextAlign = HorizontalAlignment.Right;
                //
                int value2 = table.Rows.Count;
                ct_soLuongTextBox.Text = string.Format("{0}     ", value2.ToString());
                totalTextBox.TextAlign = HorizontalAlignment.Right;
            }
            else
            {
                //Do not things
            }

        }
        private void ThemPhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void ct_addBtn_Click(object sender, EventArgs e)
        {
            frmThemChiTietPhieuNhap themCtpn = new();
            themCtpn.ShowDialog();
            ChiTietPhieuNhap chitiet = themCtpn.getChiTiet();
            if (chitiet != null)
            {
                if (chitiet.phieunhap_Id != -1)
                    temp.Add(chitiet);
                Reset();
            }
        }

        private void CancelAddBtn_Click(object sender, EventArgs e)
        {
            if (chiTietPhieuNhapGridView.RowCount > 0 && chiTietPhieuNhapGridView.ColumnCount > 0)
            {
                DialogResult result = new Msg("Bạn muốn hủy bỏ quá trình ", "warn").Res;

                if (result == DialogResult.OK)
                {
                    // Xử lý khi người dùng chọn "Yes"
                    this.Close();
                }

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
                try
                {
                    PhieuNhapExcel phieunhap = new();
                    phieunhap.Id = Convert.ToInt32(id_pnTextBox.Text);
                    phieunhap.Id_nhanvien = Convert.ToInt32(txtIdNv.Text);
                    phieunhap.ThoiGian = Convert.ToDateTime(dateTimePicker1.Text);
                    DataTable dt = new();
                    if (chiTietPhieuNhapGridView.DataSource is DataTable)
                    {
                        dt = (DataTable)chiTietPhieuNhapGridView.DataSource;
                    }
                    phieunhap.PhieuNhapList = chitietBus.getListChiTiet(dt);
                    if (phieunhapBus.AddPhieuNhap(phieunhap) == true)
                    {
                        new Msg("Thêm phiếu nhập thành công");
                        this.Dispose();
                    }
                    else
                    {
                        new Msg("Thêm thất bại !", "err");
                    }

                }
                catch (Exception ex)
                {
                    new Msg("Lỗi : " + ex.Message, "err");
                }
            }
            else
            {
                new Msg("Không có dữ liệu", "err");
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
