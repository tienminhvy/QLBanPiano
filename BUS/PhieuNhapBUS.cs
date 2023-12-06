using QLBanPiano.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanPiano.DAL;
using System.Security.Policy;
using System.Globalization;
using DocumentFormat.OpenXml.Office2013.Excel;

namespace QLBanPiano.BUS
{
    public class PhieuNhapBUS : IBUS
    {
        private ChiTietPhieuNhapBUS chitietBus = new();
        private NhanVienBUS nhanvienBus = new();
        private DB db;
        public PhieuNhapBUS()
        {
            db = new DB();
        }
        
        public DataTable LayToanBoDS()
        {
            string sqlCmd = "select hoadonphieunhap.id as 'ID',thoiGian as N'Thời gian',nhanvien_id as N'Mã nhân viên',concat(nhanvien.hoLot,' ',nhanvien.ten) as N'Tên nhân viên'\r\nfrom hoadonphieunhap\r\ninner join nhanvien on hoadonphieunhap.nhanvien_id = nhanvien.id WHERE hoadonphieunhap.khachhang_id IS NULL";
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
                    string dieukien0 = "cast(hoadonphieunhap.id as varchar) like '%"+giatri+"%'";
                    dt = LayDsDaTruyVan(dieukien0);
                    break;
                case 1:
                    string dieukien1 = "CONVERT(VARCHAR, thoiGian, 105) + ' ' + CONVERT(VARCHAR, thoiGian, 108) + ' ' + RIGHT(CONVERT(VARCHAR, thoiGian, 100), 2) LIKE '%" + giatri + "%'";
                    dt = LayDsDaTruyVan(dieukien1);
                    break;
                case 2:
                    string dieukien2 = "cast(hoadonphieunhap.nhanvien_id as varchar) like '%"+giatri+"%'";
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
            string sqlCmd = "select hoadonphieunhap.id as 'ID',thoiGian as N'Thời gian',nhanvien_id as N'Mã nhân viên',concat(nhanvien.hoLot,' ',nhanvien.ten) as N'Tên nhân viên'\r\nfrom hoadonphieunhap\r\ninner join nhanvien on hoadonphieunhap.nhanvien_id = nhanvien.id\r\nWHERE hoadonphieunhap.khachhang_id IS NULL and " + dieukien;
            DataTable dt = db.Execute(sqlCmd);
            return dt;
        }
        public string[] getImportedPhieuNhap(DataRow row)
        {
            string[] hoadonphieunhap = null;
            string id = row["ID"].ToString();
            string thoiGian = Convert.ToString(row["Thời gian"]);
            string nhanvien_id = row["Mã nhân viên"].ToString();
            List<string> list = new List<string>();
            list.Add(id);
            list.Add(thoiGian);
            list.Add(nhanvien_id);
            hoadonphieunhap = list.ToArray();
            return hoadonphieunhap;
        }
        public bool Them(params string[] dsTruong)
        {
            try
            {
                string thoigian = dsTruong[0];
                int id_nhanvien = Convert.ToInt32(dsTruong[1]);

                string sqlCmd = string.Format("insert into hoadonphieunhap(thoiGian,nhanvien_id)\r\nvalues ('{0}',{1})", thoigian, id_nhanvien);
                db.ExecuteNonQuery(sqlCmd);
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
        public PhieuNhapExcel getPhieuNhap(DataTable dt)
        {
            PhieuNhapExcel hoadonphieunhap = new();
            DataRow row = dt.Rows[0];
            hoadonphieunhap.Id = Convert.ToInt32(row["ID"]);
            hoadonphieunhap.Id_nhanvien = Convert.ToInt32(row["Mã nhân viên"]);
            hoadonphieunhap.ThoiGian = Convert.ToDateTime(row["Thời gian"]);
            hoadonphieunhap.PhieuNhapList = chitietBus.getListChiTiet(dt);
            return hoadonphieunhap;
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
        public string getSqlString(PhieuNhapExcel hoadonphieunhap ) {
            string result = string.Format("insert into hoadonphieunhap(thoiGian,nhanvien_id) values ('{0}',{1}); select SCOPE_IDENTITY();", hoadonphieunhap.ThoiGian, hoadonphieunhap.Id_nhanvien);
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
        public bool Validates(PhieuNhapExcel hoadonphieunhap)
        {
            string thisyear = "2014-01-01 00:00:00 AM";
            DateTime dateTime = DateTime.ParseExact(thisyear,"yyyy-MM-dd hh:mm:ss tt",CultureInfo.InvariantCulture,DateTimeStyles.None);
            if (hoadonphieunhap.Id <= 0) return false;
            if (hoadonphieunhap.ThoiGian > DateTime.Today || hoadonphieunhap.ThoiGian < dateTime) return false;
            if (nhanvienBus.checkExist(hoadonphieunhap.Id_nhanvien) == false) return false;
            if (hoadonphieunhap.PhieuNhapList == null) return false;
            return true;
        }
        public bool ValidateList (List<PhieuNhapExcel> list)
        {
            foreach(PhieuNhapExcel p in list)
            {
                if(Validates(p) == false) return false;
            }
            return true;
        }
        public List<PhieuNhapExcel> convertDataTableToList(DataTable dt)//Thực tế cần lấy List<ChiTietPhieuNhapn> là chính
        {
            string[] dinhdang = {
            "MM/dd/yyyy hh:mm:ss tt",
            "M/d/yyyy h:mm:ss tt",
            "M/d/yyyy hh:mm:ss tt",
            "MM/d/yyyy hh:mm:ss tt",
            "M/dd/yyyy hh:mm:ss tt",
            // Thêm các định dạng khả thi khác ở đây...
             };
            List<PhieuNhapExcel> list = new();
            try
            {
                foreach(DataRow row in dt.Rows)
                {
                    PhieuNhapExcel hoadonphieunhap = new();
                    hoadonphieunhap.Id = Convert.ToInt32(row["ID"]);
                    hoadonphieunhap.Id_nhanvien = Convert.ToInt32(row["Mã nhân viên"]);
                    foreach(var format in dinhdang)
                    {
                        DateTime thoiGian;
                        if (DateTime.TryParseExact(row["Thời gian"].ToString(), format, CultureInfo.InvariantCulture, DateTimeStyles.None, out thoiGian))
                        {
                            hoadonphieunhap.ThoiGian = thoiGian;
                            break; // Nếu chuyển đổi thành công, thoát khỏi vòng lặp
                        }
                    }
                    hoadonphieunhap.PhieuNhapList = chitietBus.getListChiTiet(chitietBus.LayChiTietPhieuNhap(Convert.ToInt32(row["ID"])));

                    list.Add(hoadonphieunhap);
                }
            }catch (Exception ex)
            {
                MessageBox.Show("LỖI HÀM CONVERT DATATABLE TO LIST" + ex.Message);
            }

            return list;
        }
        public DataTable formatToExport(List<PhieuNhapExcel> list)
        {
            DataTable dt = new();
            try
            {
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Thời gian", typeof(DateTime));
                dt.Columns.Add("Mã nhân viên", typeof(int));
                dt.Columns.Add("Mã nhạc cụ", typeof(int));
                dt.Columns.Add("Đơn giá", typeof(long));
                dt.Columns.Add("SL", typeof(short));
                //
                foreach(var hoadonphieunhap in list)
                {
                    foreach (var chitiet in hoadonphieunhap.PhieuNhapList)
                    {
                        DataRow row = dt.NewRow();
                        row["ID"] = hoadonphieunhap.Id;
                        row["Thời gian"] = hoadonphieunhap.ThoiGian;
                        row["Mã nhân viên"] = hoadonphieunhap.Id_nhanvien;
                        row["Mã nhạc cụ"] = chitiet.nhaccu_Id;
                        row["Đơn giá"] = chitiet.DonGia;
                        row["SL"] = chitiet.SoLuong;
                        dt.Rows.Add(row);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public bool AddPhieuNhap(PhieuNhapExcel phieunhap)
        {
            DataTable chitiet = chitietBus.formatToImport(chitietBus.convertToDataTable(phieunhap.PhieuNhapList));
            foreach(DataColumn col in chitiet.Columns)
            {
                MessageBox.Show(col.ColumnName);
            }
            try
            {
                if (db.InsertConstraintedData(chitiet, "chitiet_hdpn", getSqlString(phieunhap)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
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
