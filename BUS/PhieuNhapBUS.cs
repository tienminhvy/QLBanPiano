using QLBanPiano.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanPiano.DAL;
using System.Security.Policy;

namespace QLBanPiano.BUS
{
    public class PhieuNhapBUS : IBUS
    {
        DB db;
        public PhieuNhapBUS()
        {
            db = new DB();
        }
        public DataTable LayToanBoDS()
        {
            string sqlCmd = "select phieunhap.id as 'ID',thoiGian as N'Thời gian',nhanvien_id as N'Mã nhân viên',concat(nhanvien.hoLot,' ',nhanvien.ten) as N'Tên nhân viên'\r\nfrom phieunhap\r\ninner join nhanvien on phieunhap.nhanvien_id = nhanvien.id";
            DataTable dt = db.Execute(sqlCmd);
            foreach (DataRow row in dt.Rows)
            {
                DateTime thoiGian = (DateTime)row["Thời gian"];
                string formatted = thoiGian.ToString("yyyy/MM/dd hh:mm:ss tt");
                row["Thời gian"] = formatted;
            }
            return dt;
        }
        public DataTable TimKiem(int index,string giatri)
        {
            DataTable dt = new();
            switch (index)
            {
                case 0:
                    string dieukien0 = "cast(phieunhap.id as varchar) like '%"+giatri+"%'";
                    dt = LayDsDaTruyVan(dieukien0);
                    break;
                case 1:
                    string dieukien1 = "convert(varchar, phieunhap.thoiGian, 120) like '%"+giatri+"%' or cast(phieunhap.thoiGian as varchar) like '%"+giatri+"%'";
                    dt = LayDsDaTruyVan(dieukien1);
                    break;
                case 2:
                    string dieukien2 = "cast(phieunhap.nhanvien_id as varchar) like '%"+giatri+"%'";
                    dt = LayDsDaTruyVan(dieukien2);
                    break;
                case 3:
                    string dieukien3 = "concat(nhanvien.hoLot,' ',nhanvien.ten) like '%"+giatri+"%'";
                    dt = LayDsDaTruyVan(dieukien3);
                    break;
            }
            return dt;
        }
        public DataTable LayDsDaTruyVan(string dieukien)
        {
            string sqlCmd = "select phieunhap.id as 'ID',thoiGian as N'Thời gian',nhanvien_id as N'Mã nhân viên',concat(nhanvien.hoLot,' ',nhanvien.ten) as N'Tên nhân viên'\r\nfrom phieunhap\r\ninner join nhanvien on phieunhap.nhanvien_id = nhanvien.id\r\nwhere " +dieukien;
            DataTable dt = db.Execute(sqlCmd);
            return dt;
        }
        ///////////////////////////
        public object GiaTriTruong(string tenTruong, string dieuKien)
        {
            throw new NotImplementedException();
        }

        public List<DoiTuong> LayDS(string dieukien)
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

        public bool Xoa(string tieuChi)
        {
            throw new NotImplementedException();
        }
    }
}
