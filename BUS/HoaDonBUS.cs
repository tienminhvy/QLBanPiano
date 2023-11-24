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
    public class HoaDonBUS : IBUS
    {
        DB db;
        public HoaDonBUS()
        {
            db = new DB();
        }
        public object GiaTriTruong(string tenTruong, string dieuKien)
        {
            return db.GetColumn("hoadon", tenTruong, dieuKien);
        }

        public DataTable GetDS()
        {
            string sqlCmd = "SELECT hoadon.id as N'Mã hóa đơn' ,hoadon.thoiGian as N'Thời gian',nhanvien.id as N'Mã nhân viên',concat(nhanvien.hoLot,' ',nhanvien.ten) as N'Nhân viên',khachhang.id as N'Mã khách hàng',CONCAT(khachhang.hoLot,' ',khachhang.ten) as N'Khách hàng '\r\nFrom hoadon\r\nInner join khachhang on hoadon.khachhang_id = khachhang.id\r\nInner join nhanvien on hoadon.nhanvien_id = nhanvien.id";
            DataTable dt = db.Execute(sqlCmd);
            return dt;
        }

        public DataTable LayToanBoDS()
        {
            string sqlCmd = "select hoadon.id as 'ID',hoadon.thoiGian as N'Thời gian',hoadon.nhanvien_id as N'Mã nhân viên',concat(nhanvien.hoLot,' ',nhanvien.ten) as N'Tên nhân viên',hoadon.khachhang_id as N'Mã khách hàng',concat(khachhang.hoLot,' ',khachhang.ten) as N'Tên khách hàng'\r\nfrom hoadon\r\ninner join khachhang on hoadon.khachhang_id = khachhang.id\r\ninner join nhanvien on hoadon.nhanvien_id = nhanvien.id\r\n";
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
            return db.GetCount("hoadon", dieuKien);
        }
        DataTable listToDataTable(List<DoiTuong> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Thời gian", typeof(DateTime));
            dt.Columns.Add("Mã nhân viên", typeof(int));
            dt.Columns.Add("Mã khách hàng", typeof(int));
            if(list != null)
            {
                foreach (HoaDon hd in list)
                {
                    DataRow row = dt.NewRow();
                    row["ID"] = hd.Id;
                    row["Thời gian"] = hd.NgayMuaHang;
                    row["Mã nhân viên"] = hd.NhanVien_Id;
                    row["Mã khách hàng"] = hd.KhachHang_Id;
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }
        public DataTable TimKiem(int tieuchi,string giatri)
        {
            DataTable dt = new();
            switch (tieuchi)
            {
                case 0:
                    string dieukien0 = "cast(hoadon.id as varchar) like '%"+ giatri +"%'";
                    dt = layDsDaTruyVan(dieukien0);
                    break;
                case 1:
                    string dieukien1 = "convert(varchar,hoadon.thoiGian,120) like '%" + giatri +"%'";
                    dt = layDsDaTruyVan(dieukien1);
                    break;
                case 2:
                    string dieukien2 = "hoadon.nhanvien_id like '%" + giatri +"%'";
                    dt = layDsDaTruyVan(dieukien2);
                    break;
                case 3:
                    string dieukien3 = "hoadon.khachhang_id like '%"+giatri + "%'";
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
        public bool Them(params string[] dsTruong)
        {
            string thoiGian = dsTruong[0];
            string nhanvien_id = dsTruong[1];
            string khachhang_id = dsTruong[2];
            int hoadon_id = db.Insert(string.Format("insert into hoadon (thoiGian,nhanvien_id,khachhang_id) OUTPUT INSERTED.id values ({0},{1},{2}) ",Convert.ToDateTime(thoiGian),Convert.ToInt32(nhanvien_id),Convert.ToInt32(khachhang_id)));
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

        public bool Validate(params string[] dsTruong)
        {
            throw new NotImplementedException();
        }

        public bool Xoa(string tieuChi)
        {
            throw new NotImplementedException();
        }
        public DataTable layDsDaTruyVan(string dieukien)
        {
            string sqlCmd = "select hoadon.id as 'ID',hoadon.thoiGian as N'Thời gian',hoadon.nhanvien_id as N'Mã nhân viên',concat(nhanvien.hoLot,' ',nhanvien.ten) as N'Tên nhân viên',hoadon.khachhang_id as N'Mã khách hàng',concat(khachhang.hoLot,' ',khachhang.ten) as N'Tên khách hàng'\r\nfrom hoadon\r\ninner join khachhang on hoadon.khachhang_id = khachhang.id\r\ninner join nhanvien on hoadon.nhanvien_id = nhanvien.id\r\nwhere " + dieukien;
            DataTable dt = db.Execute(sqlCmd);
            return dt;
        }
        public List<DoiTuong> LayDS(string dieukien)
        {
            string sqlCmd = "select id as N'ID', thoiGian as N'Thời gian',nhanvien_id as N'Mã nhân viên',khachhang_id as N'Mã khách hàng'\r\nfrom hoadon\r\nwhere " + dieukien;
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

        List<DoiTuong> IBUS.LayDS(string dieuKien)
        {
            throw new NotImplementedException();
        }
    }
}
