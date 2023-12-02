using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanPiano.DAL;
using QLBanPiano.DTO;

namespace QLBanPiano.BUS
{
    public class HoaDonPdfExcelBUS
    {
        ChiTietHoaDonBUS chitietbus = new();
        DB db = new();
        public HoaDonPDFExcel getHoaDonByID(int ID)
        {
            HoaDonPDFExcel hoaDon = new();
            try
            {
                string sqlCmd = "select id as 'ID',thoiGian as N'Thời gian',nhanvien_id as N'Mã nhân viên',khachhang_id as N'Mã khách hàng'\r\nfrom hoadonphieunhap\r\nwhere id = " + ID;
                DataTable dt = db.Execute(sqlCmd);
                DataRow row = dt.Rows[0];
                hoaDon.Id = Convert.ToInt32(row["ID"]);
                hoaDon.ThoiGian = Convert.ToDateTime(row["Thời gian"]);
                hoaDon.NhanVien_id = Convert.ToInt32(row["Mã nhân viên"]);
                hoaDon.KhachHang_id = Convert.ToInt32(row["Mã khách hàng"]);
                hoaDon.List = chitietbus.DatatableToList(chitietbus.LayChiTietHoaDon(ID));
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return hoaDon;
        }
        public DataTable formatToExport(List<HoaDonPDFExcel> list)
        {
            DataTable dt = new();
            try
            {
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Thời gian", typeof(DateTime));
                dt.Columns.Add("Mã nhân viên", typeof(int));
                dt.Columns.Add("Mã khách hàng", typeof(int));
                dt.Columns.Add("Mã nhạc cụ", typeof(int));
                dt.Columns.Add("Đơn giá", typeof(long));
                dt.Columns.Add("SL", typeof(short));
                //
                foreach (var hoaDon in list)
                {
                    foreach (var chitiet in hoaDon.List)
                    {
                        DataRow row = dt.NewRow();
                        row["ID"] = hoaDon.Id;
                        row["Thời gian"] = hoaDon.ThoiGian;
                        row["Mã nhân viên"] = hoaDon.NhanVien_id;
                        row["Mã khách hàng"] = hoaDon.KhachHang_id;
                        row["Mã nhạc cụ"] = chitiet.nhaccu_Id;
                        row["Đơn giá"] = chitiet.DonGia;
                        row["SL"] = chitiet.SoLuong;
                        dt.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public List<HoaDonPDFExcel> DatatableToList(DataTable table)
        {
            string[] dinhdang = {
            "MM/dd/yyyy hh:mm:ss tt",
            "M/d/yyyy h:mm:ss tt",
            "M/d/yyyy hh:mm:ss tt",
            "MM/d/yyyy hh:mm:ss tt",
            "M/dd/yyyy hh:mm:ss tt",
            // Thêm các định dạng khả thi khác ở đây...
             };

            List<HoaDonPDFExcel> list = new List<HoaDonPDFExcel>();

            foreach (DataRow row in table.Rows)
            {
                HoaDonPDFExcel hoaDon = new HoaDonPDFExcel();
                hoaDon.Id = Convert.ToInt32(row["ID"]);
                hoaDon.NhanVien_id = Convert.ToInt32(row["Mã nhân viên"]);
                hoaDon.KhachHang_id = Convert.ToInt32(row["Mã khách hàng"]);
                hoaDon.List = chitietbus.DatatableToList(chitietbus.LayChiTietHoaDon(Convert.ToInt32(row["ID"])));

                foreach (string format in dinhdang)
                {
                    DateTime thoiGian;
                    if (DateTime.TryParseExact(row["Thời gian"].ToString(), format, CultureInfo.InvariantCulture, DateTimeStyles.None, out thoiGian))
                    {
                        hoaDon.ThoiGian = thoiGian;
                        break; // Nếu chuyển đổi thành công, thoát khỏi vòng lặp
                    }
                }

                list.Add(hoaDon);
            }

            return list;
        }


    }
}
