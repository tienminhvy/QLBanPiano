using QLBanPiano.DAL;
using QLBanPiano.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanPiano.BUS
{
    internal class ThongKeBUS : IBUS
    {
        DB db;
        public ThongKeBUS()
        {
            db = new DB();
        }
        public object GiaTriTruong(string tenTruong, string dieuKien)
        {
            throw new NotImplementedException();
        }

        public List<DoiTuong> LayDS(string dieuKien)
        {
            throw new NotImplementedException();
        }

        public DataTable LayToanBoDS()
        {
            throw new NotImplementedException();
        }

        public int SoLuong(string dieuKien)
        {
            throw new NotImplementedException();
        }

        public bool Sua(params string[] dsTruong)
        {
            throw new NotImplementedException();
        }

        public bool Them(params string[] dsTruong)
        {
            throw new NotImplementedException();
        }

        public bool Validate(params string[] dsTruong)
        {
            throw new NotImplementedException();
        }

        public bool Xoa(string tieuChi)
        {
            throw new NotImplementedException();
        }

        public List<long> TongChiTheoThang(string nam)
        {
            string sqlStr = "SELECT MONTH(pn.thoiGian) as N'Tháng', SUM(ctpn.soLuong * ctpn.donGia) as N'Tổng giá tiền'" +
                "\r\nFROM hoadonphieunhap pn JOIN chitiet_hdpn ctpn ON pn.id = ctpn.id_hdpn" +
                "\r\nWHERE pn.khachhang_id IS NULL AND YEAR(pn.thoiGian) = " + nam +
                "\r\nGROUP BY MONTH(pn.thoiGian);";
            DataTable dt = db.Execute(sqlStr);
            List<long> list = Enumerable.Repeat(0L, 12).ToList(); // tạo 1 list 12 phần tử với tất cả = 0

            foreach (DataRow row in dt.Rows)
            {
                int thang = int.Parse(row["Tháng"].ToString());
                list[thang-1] = long.Parse(row["Tổng giá tiền"].ToString());
            }
            return list;
        }
        public List<long> TongThuTheoThang(string nam)
        {
            string sqlStr = "SELECT MONTH(hd.thoiGian) as N'Tháng', SUM(cthd.soLuong * cthd.donGia) as N'Tổng giá tiền' " +
                "FROM hoadonphieunhap hd JOIN chitiet_hdpn cthd ON hd.id = cthd.id_hdpn " +
                "WHERE hd.khachhang_id IS NOT NULL AND YEAR(hd.thoiGian) = " +nam+
                "GROUP BY MONTH(hd.thoiGian); ";
            DataTable dt = db.Execute(sqlStr);
            List<long> list = Enumerable.Repeat(0L, 12).ToList(); // tạo 1 list 12 phần tử với tất cả = 0

            foreach (DataRow row in dt.Rows)
            {
                int thang = int.Parse(row[0].ToString());
                list[thang-1] = long.Parse(row[1].ToString());
            }
            return list;
        }

        public List<long> TongChiTheoNgay(string nam, string thang)
        {
            int soNgayTrongThang = DateTime.DaysInMonth(int.Parse(nam), int.Parse(thang));
            string sqlStr = "SELECT DAY(pn.thoiGian) as N'Ngày', SUM(ctpn.soLuong * ctpn.donGia) as N'Tổng giá tiền' " +
                "FROM hoadonphieunhap pn JOIN chitiet_hdpn ctpn ON pn.id = ctpn.id_hdpn " +
                "WHERE pn.khachhang_id IS NULL AND YEAR(pn.thoiGian) = " + nam+" AND MONTH(pn.thoiGian) = "+thang +
                " GROUP BY Day(pn.thoiGian); ";
            DataTable dt = db.Execute(sqlStr);
            List<long> list = Enumerable.Repeat(0L, soNgayTrongThang).ToList(); // tạo 1 list 30/31/28 phần tử với tất cả = 0

            foreach (DataRow row in dt.Rows)
            {
                int ngay = int.Parse(row["Ngày"].ToString());
                list[ngay-1] = long.Parse(row["Tổng giá tiền"].ToString());
            }
            return list;
        }

        public List<long> TongThuTheoNgay(string nam, string thang)
        {
            int soNgayTrongThang = DateTime.DaysInMonth(int.Parse(nam), int.Parse(thang));
            string sqlStr = "SELECT DAY(hd.thoiGian) as N'Ngày', SUM(cthd.soLuong * cthd.donGia) as N'Tổng giá tiền' " +
                "FROM hoadonphieunhap hd JOIN chitiet_hdpn cthd ON hd.id = cthd.id_hdpn " +
                "WHERE hd.khachhang_id IS NOT NULL AND YEAR(hd.thoiGian) = " + nam+" AND MONTH(hd.thoiGian) = " +thang +
                " GROUP BY DAY(hd.thoiGian); ";
            DataTable dt = db.Execute(sqlStr);
            List<long> list = Enumerable.Repeat(0L, soNgayTrongThang).ToList(); // tạo 1 list 30/31/28 phần tử với tất cả = 0

            foreach (DataRow row in dt.Rows)
            {
                int ngay = int.Parse(row["Ngày"].ToString());
                list[ngay - 1] = long.Parse(row["Tổng giá tiền"].ToString());
            }
            return list;
        }

        public int SoLuongThuongHieuDaBanTrongNam(string nam, string maThuongHieu)
        {
            string sqlStr = "SELECT ISNULL(sum(cthd.soLuong), 0) as N'Số Lượng' " +
                "FROM hoadonphieunhap hd join chitiet_hdpn cthd on hd.id = cthd.id_hdpn " +
                "join nhaccu nc on cthd.nhaccu_id = nc.id " +
                "join thuonghieu th on nc.thuonghieu_id = th.id " +
                "WHERE hd.khachhang_id IS NOT NULL AND YEAR(hd.thoiGian) = " + nam+" and th.ma = '"+maThuongHieu+"' " +
                "GROUP BY th.ma";
            DataTable dt = db.Execute(sqlStr);
            int result = 0;
            foreach (DataRow row in dt.Rows)
            {
                result = int.Parse(row["Số Lượng"].ToString());
            }
            return result;
        }

        public int SoLuongThuongHieuDaBanTrongThang(string nam, string thang, string maThuongHieu)
        {
            string sqlStr = "SELECT ISNULL(sum(cthd.soLuong), 0) as N'Số Lượng' " +
                "FROM hoadonphieunhap hd join chitiet_hdpn cthd on hd.id = cthd.id_hdpn " +
                "join nhaccu nc on cthd.nhaccu_id = nc.id " +
                "join thuonghieu th on nc.thuonghieu_id = th.id " +
                "WHERE hd.khachhang_id IS NOT NULL AND YEAR(hd.thoiGian) = " + nam + "and MONTH(hd.thoiGian) = "+thang+ " and th.ma = '" + maThuongHieu + "' " +
                "GROUP BY th.ma";
            DataTable dt = db.Execute(sqlStr);
            int result = 0;
            foreach (DataRow row in dt.Rows)
            {
                result = int.Parse(row["Số Lượng"].ToString());
            }
            return result;
        }

    }

}
