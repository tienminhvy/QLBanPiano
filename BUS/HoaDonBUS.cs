using QLBanPiano.DAL;
using QLBanPiano.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.BUS
{
    public class HoaDonBUS
    {
        private ChiTietHoaDonBUS chitietBus = new();
        private KhachHangBUS khachhangBus = new();
        private NhanVienBUS nhanvienBus = new();
        DB db;
        public HoaDonBUS()
        {
            db = new DB();
        }
        public object GiaTriTruong(string tenTruong, string dieuKien)
        {
            return db.GetColumn("hoadonphieunhap", tenTruong, dieuKien);
        }

        public DataTable GetDS()
        {
            string sqlCmd = "SELECT hoadonphieunhap.id as N'Mã hóa đơn' ,hoadonphieunhap.thoiGian as N'Thời gian',nhanvien.id as N'Mã nhân viên',concat(nhanvien.hoLot,' ',nhanvien.ten) as N'Nhân viên',khachhang.id as N'Mã khách hàng',CONCAT(khachhang.hoLot,' ',khachhang.ten) as N'Khách hàng '\r\nFrom hoadonphieunhap\r\nInner join khachhang on hoadonphieunhap.khachhang_id = khachhang.id\r\nInner join nhanvien on hoadonphieunhap.nhanvien_id = nhanvien.id WHERE hoadonphieunhap.khachhang_id IS NOT NULL";
            DataTable dt = db.Execute(sqlCmd);
            return dt;
        }

        public DataTable LayToanBoDS()
        {
            string sqlCmd = "select hoadonphieunhap.id as 'ID',hoadonphieunhap.thoiGian as N'Thời gian',hoadonphieunhap.nhanvien_id as N'Mã nhân viên',concat(nhanvien.hoLot,' ',nhanvien.ten) as N'Tên nhân viên',hoadonphieunhap.khachhang_id as N'Mã khách hàng',concat(khachhang.hoLot,' ',khachhang.ten) as N'Tên khách hàng'\r\nfrom hoadonphieunhap\r\ninner join khachhang on hoadonphieunhap.khachhang_id = khachhang.id\r\ninner join nhanvien on hoadonphieunhap.nhanvien_id = nhanvien.id\r\nWHERE hoadonphieunhap.khachhang_id IS NOT NULL";
            DataTable dt = db.Execute(sqlCmd);
            foreach(DataRow row in dt.Rows)
            {
                DateTime thoiGian = (DateTime)row["Thời gian"];
                string formatted = thoiGian.ToString("yyyy/MM/dd hh:mm:ss tt");
                row["Thời gian"] = formatted;
            }
            return dt;
        }

        public int SoLuong(string dieuKien)
        {
            return db.GetCount("hoadonphieunhap", dieuKien);
        }
        public DataTable getClone(DataTable dt)
        {
            DataTable clone = dt.Clone();
            foreach (DataRow row in dt.Rows)
            {
                clone.ImportRow(row);
            }
            return clone;
        }
        public DataTable splitFromExcelTableById(DataTable excel, int id)
        {
            DataTable dt = excel.Clone();
            DataRow[] rowSplited = excel.Select("ID = " + id);
            foreach (DataRow row in rowSplited)
            {
                dt.ImportRow(row);
            }
            return dt;
        }
        public HoaDonPDFExcel getHoaDon(DataTable dt)
        {
            HoaDonPDFExcel hoadonphieunhap = new();
            DataRow row = dt.Rows[0];
            try
            {
                hoadonphieunhap.Id = Convert.ToInt32(row["ID"]);
                hoadonphieunhap.NhanVien_id = Convert.ToInt32(row["Mã nhân viên"]);
                hoadonphieunhap.ThoiGian = Convert.ToDateTime(row["Thời gian"]);
                hoadonphieunhap.KhachHang_id = Convert.ToInt32(row["Mã khách hàng"]);
                hoadonphieunhap.List = chitietBus.DatatableToList(dt);
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi convert " + ex.Message);
            }
            return hoadonphieunhap;
        }
        public HoaDonPDFExcel getHoaDonExcel(DataTable dt)
        {
            HoaDonPDFExcel hoadonphieunhap = new();
            DataRow row = dt.Rows[0];
            try
            {
                hoadonphieunhap.Id = Convert.ToInt32(row["ID"]);
                hoadonphieunhap.NhanVien_id = Convert.ToInt32(row["Mã nhân viên"]);
                hoadonphieunhap.ThoiGian = Convert.ToDateTime(row["Thời gian"]);
                hoadonphieunhap.KhachHang_id = Convert.ToInt32(row["Mã khách hàng"]);
                hoadonphieunhap.List = chitietBus.DatatableToListExcel(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi convert " + ex.Message);
            }
            return hoadonphieunhap;
        }
        public bool Validates(HoaDonPDFExcel hoadonphieunhap)
        {
            string thisyear = "2014-01-01 00:00:00 AM";
            DateTime dateTime = DateTime.ParseExact(thisyear, "yyyy-MM-dd hh:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None);
            if (hoadonphieunhap.Id <= 0) return false;
            if (hoadonphieunhap.ThoiGian > DateTime.Today || hoadonphieunhap.ThoiGian < dateTime) return false;
            if (khachhangBus.checkExist(hoadonphieunhap.KhachHang_id) == false) return false;
            if (nhanvienBus.checkExist(hoadonphieunhap.NhanVien_id) == false) return false;
            if (hoadonphieunhap.List == null) return false;
            return true;
        }
        public bool ValidateList(List<HoaDonPDFExcel> list)
        {
            foreach (HoaDonPDFExcel hoaDon in list)
            {
                if (Validates(hoaDon) == false) return false;
            }
            return true;
        }
        public string getSqlString(HoaDonPDFExcel hoadonphieunhap)
        {
            string result = string.Format("insert into hoadonphieunhap(thoiGian,nhanvien_id,khachhang_id) values ('{0}',{1},{2}); select SCOPE_IDENTITY();", hoadonphieunhap.ThoiGian, hoadonphieunhap.NhanVien_id,hoadonphieunhap.KhachHang_id);
            return result;
        }
        public DataTable TimKiem(int tieuchi,string giatri)
        {
            DataTable dt = new();
            switch (tieuchi)
            {
                case 0:
                    string dieukien0 = "cast(hoadonphieunhap.id as varchar) like '%"+ giatri +"%'";
                    dt = layDsDaTruyVan(dieukien0);
                    break;
                case 1: // date
                    string[] ngay = giatri.Split(",");
                    string dieuKien = string.Format("thoigian BETWEEN '{0}' AND '{1}'", ngay[0], ngay[1]);
                    dt = layDsDaTruyVan(dieuKien);
                    break;
                case 2:
                    string dieukien2 = "hoadonphieunhap.nhanvien_id like '%" + giatri +"%'";
                    dt = layDsDaTruyVan(dieukien2);
                    break;
                case 3:
                    string dieukien3 = "hoadonphieunhap.khachhang_id like '%"+giatri + "%'";
                    dt = layDsDaTruyVan(dieukien3);
                    break;
                case 4:
                    string dieukien4 = "concat(nhanvien.hoLot,' ',nhanvien.ten) like '%"+giatri+"%'";
                    dt = layDsDaTruyVan(dieukien4);
                    break;
                case 5:
                    string dieukien5 = "concat(khachhang.hoLot,' ',khachhang.ten) like '%"+giatri+"%'";
                    dt = layDsDaTruyVan(dieukien5);
                    break;
                default:
                    dt = null;
                    break;
            }
            return dt;
        }
        public int TraVeID(params string[] dsTruong)
        {
            string thoiGian = dsTruong[0];
            string nhanvien_id = dsTruong[1];
            string khachhang_id = dsTruong[2];
            int hoadon_id = db.Insert(string.Format("insert into hoadonphieunhap (thoiGian,nhanvien_id,khachhang_id) OUTPUT INSERTED.id values ('{0}',{1},{2}) ", Convert.ToDateTime(thoiGian), Convert.ToInt32(nhanvien_id), Convert.ToInt32(khachhang_id)));
            return hoadon_id;
        }

        public bool Them(params string[] dsTruong)
        {
            string thoiGian = dsTruong[0];
            string nhanvien_id = dsTruong[1];
            string khachhang_id = dsTruong[2];
            int hoadon_id = db.Insert(string.Format("insert into hoadonphieunhap (thoiGian,nhanvien_id,khachhang_id) OUTPUT INSERTED.id values ('{0}',{1},{2}) ",thoiGian,Convert.ToInt32(nhanvien_id),Convert.ToInt32(khachhang_id)));
            if(hoadon_id == -1)
            {
                return false;
            }
            return true;
        }
        public bool Sua(params string[] dsTruong)
        {
            throw new NotImplementedException();
        }

        public bool Xoa(string tieuChi)
        {
            throw new NotImplementedException();
        }
        public DataTable layDsDaTruyVan(string dieukien)
        {
            string sqlCmd = "select hoadonphieunhap.id as 'ID',hoadonphieunhap.thoiGian as N'Thời gian',hoadonphieunhap.nhanvien_id as N'Mã nhân viên',concat(nhanvien.hoLot,' ',nhanvien.ten) as N'Tên nhân viên',hoadonphieunhap.khachhang_id as N'Mã khách hàng',concat(khachhang.hoLot,' ',khachhang.ten) as N'Tên khách hàng'\r\nfrom hoadonphieunhap\r\ninner join khachhang on hoadonphieunhap.khachhang_id = khachhang.id\r\ninner join nhanvien on hoadonphieunhap.nhanvien_id = nhanvien.id\r\nWHERE hoadonphieunhap.khachhang_id IS NOT NULL and " + dieukien;
            DataTable dt = db.Execute(sqlCmd);
            return dt;
        }
        public List<DoiTuong> LayDS(string dieukien)
        {
            string sqlCmd = "select id as N'ID', thoiGian as N'Thời gian',nhanvien_id as N'Mã nhân viên',khachhang_id as N'Mã khách hàng'\r\nfrom hoadonphieunhap\r\nwhere " + dieukien;
            DataTable dt = db.Execute(sqlCmd);
            List<DoiTuong> list = new();
            foreach (DataRow dr in dt.Rows)
            {
                HoaDon hd = new();
                hd.Id = Convert.ToInt32(dr["ID"].ToString());
                DateTime ngayMuaHang = (DateTime)dr["Thời gian"];
                string formatted = ngayMuaHang.ToString("MM/dd/yyyy hh:mm:ss tt");
                hd.NgayMuaHang = DateTime.ParseExact(formatted,"MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                hd.NhanVien_Id = Convert.ToInt32(dr["Mã nhân viên"].ToString());
                hd.KhachHang_Id = Convert.ToInt32(dr["Mã khách hàng"].ToString());
                list.Add(hd);
            }
            return list;
        }
    }
}
