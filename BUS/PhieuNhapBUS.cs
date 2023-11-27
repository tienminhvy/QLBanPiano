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
        ChiTietPhieuNhapBUS chitietBus = new();
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
        public string[] getImportedPhieuNhap(DataRow row)
        {
            string[] phieunhap = null;
            string id = row["ID"].ToString();
            string thoiGian = Convert.ToString(row["Thời gian"]);
            string nhanvien_id = row["Mã nhân viên"].ToString();
            List<string> list = new List<string>();
            list.Add(id);
            list.Add(thoiGian);
            list.Add(nhanvien_id);
            phieunhap = list.ToArray();
            return phieunhap;
        }
        public bool Them(params string[] dsTruong)
        {
            try
            {
                string thoigian = dsTruong[0];
                int id_nhanvien = Convert.ToInt32(dsTruong[1]);

                string sqlCmd = string.Format("insert into phieunhap(thoiGian,nhanvien_id)\r\nvalues ('{0}',{1})", thoigian, id_nhanvien);
                db.ExecuteNonQuery(sqlCmd);
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
        public PhieuNhap getPhieuNhap(DataTable dt)
        {
            PhieuNhap phieunhap = new();
            DataRow row = dt.Rows[0];
            phieunhap.Id = Convert.ToInt32(row["ID"]);
            phieunhap.Id_nhanvien = Convert.ToInt32(row["Mã nhân viên"]);
            phieunhap.ThoiGian = Convert.ToDateTime(row["Thời gian"]);
            phieunhap.PhieuNhapList = chitietBus.getListChiTiet(dt);
            return phieunhap;
        }
        public DataTable splitFromExcelTableById(DataTable excel,int id)
        {
            DataTable dt = excel.Clone();
            DataRow[] rowSplited = excel.Select("ID = " + id);
            foreach (DataRow row in rowSplited)
            {
                dt.ImportRow(row);
            }
            return dt;
        }
        public string getSqlString(PhieuNhap phieunhap ) {
            string result = string.Format("insert into phieunhap(thoiGian,nhanvien_id) values ('{0}',{1}); select SCOPE_IDENTITY();", phieunhap.ThoiGian, phieunhap.Id_nhanvien);
            return result;
        }
        public DataTable getClone(DataTable dt)
        {
            DataTable clone = dt.Clone();
            foreach(DataRow row in dt.Rows)
            {
                clone.ImportRow(row);
            }
            return clone;
        }
        public bool Validates(PhieuNhap phieunhap)
        {
            string thisyear = "2023-01-01 00:00:00 AM";
            DateTime dateTime = DateTime.Parse(thisyear);
            if (phieunhap.Id <= 0) return false;
            if (phieunhap.ThoiGian > DateTime.Today || phieunhap.ThoiGian < dateTime) return false;
            if (phieunhap.Id <= 0) return false;
            return true;
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


        public bool Xoa(string tieuChi)
        {
            throw new NotImplementedException();
        }

        public bool Validate(params string[] dsTruong)
        {
            throw new NotImplementedException();
        }
    }
}
