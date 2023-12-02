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
        private IOFileBUS fileHandler = new();
        private NhacCuBUS nhacCuBUS = new();
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
                    string dieukien1 = "CONVERT(VARCHAR, thoiGian, 105) + ' ' + CONVERT(VARCHAR, thoiGian, 108) + ' ' + RIGHT(CONVERT(VARCHAR, thoiGian, 100), 2) LIKE '%" + giatri + "%'";
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
        public PhieuNhapExcel getPhieuNhap(DataTable dt)
        {
            PhieuNhapExcel phieunhap = new();
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
        public string getSqlString(PhieuNhapExcel phieunhap ) {
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
        public bool Validates(PhieuNhapExcel phieunhap)
        {
            string thisyear = "2014-01-01 00:00:00 AM";
            DateTime dateTime = DateTime.ParseExact(thisyear,"yyyy-MM-dd hh:mm:ss tt",CultureInfo.InvariantCulture,DateTimeStyles.None);
            if (phieunhap.Id <= 0) return false;
            if (phieunhap.ThoiGian > DateTime.Today || phieunhap.ThoiGian < dateTime) return false;
            if (nhanvienBus.checkExist(phieunhap.Id_nhanvien) == false) return false;
            if (phieunhap.PhieuNhapList == null) return false;
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
                    PhieuNhapExcel phieunhap = new();
                    phieunhap.Id = Convert.ToInt32(row["ID"]);
                    phieunhap.Id_nhanvien = Convert.ToInt32(row["Mã nhân viên"]);
                    foreach(var format in dinhdang)
                    {
                        DateTime thoiGian;
                        if (DateTime.TryParseExact(row["Thời gian"].ToString(), format, CultureInfo.InvariantCulture, DateTimeStyles.None, out thoiGian))
                        {
                            phieunhap.ThoiGian = thoiGian;
                            break; // Nếu chuyển đổi thành công, thoát khỏi vòng lặp
                        }
                    }
                    phieunhap.PhieuNhapList = chitietBus.getListChiTiet(chitietBus.LayChiTietPhieuNhap(Convert.ToInt32(row["ID"])));

                    list.Add(phieunhap);
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
                foreach(var phieunhap in list)
                {
                    foreach (var chitiet in phieunhap.PhieuNhapList)
                    {
                        DataRow row = dt.NewRow();
                        row["ID"] = phieunhap.Id;
                        row["Thời gian"] = phieunhap.ThoiGian;
                        row["Mã nhân viên"] = phieunhap.Id_nhanvien;
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
        public bool importResult(string filename)
        {
            List<string> list = new List<string> { "ID", "Thời gian", "Mã nhân viên", "Mã nhạc cụ", "Đơn giá", "SL" };
            List<string> temp = fileHandler.GetListHeader(filename);
            List<PhieuNhapExcel> listImport = new();
            if (temp.SequenceEqual(list) == true)
            {
                DataTable raw = fileHandler.ImportFormExcelToDataTable(filename);
                DataTable rawClone = getClone(raw);
                int rowCount = raw.Rows.Count;
                while (rowCount > 0)
                {
                    string minId = rawClone.AsEnumerable().Min(row => row.Field<string>("ID"));
                    int min = int.Parse(minId);
                    DataTable processed = splitFromExcelTableById(rawClone, min);
                    PhieuNhapExcel ph = new();
                    ph = getPhieuNhap(processed);
                    int numberOfRowMin = fileHandler.returnIdCount(rawClone, min);
                    if (chitietBus.ValidateList(ph.PhieuNhapList) == true)
                    {
                        listImport.Add(ph);

                        rowCount -= numberOfRowMin;
                        while (numberOfRowMin > 0)
                        {
                            rawClone.Rows.RemoveAt(0);
                            numberOfRowMin--;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Định dạng excel không hợp lệ !");
                        return false;
                    }
                }
                if (ValidateList(listImport))
                {
                    foreach (PhieuNhapExcel ph in listImport)
                    {
                        DataTable chitietTable = chitietBus.convertToDataTable(ph.PhieuNhapList);
                        DataTable updateNhaccu = chitietTable.Clone();
                        updateNhaccu.Columns.Remove("ID");
                        updateNhaccu.Columns.Remove("Đơn giá");
                        foreach (DataRow row in chitietTable.Rows)
                        {
                            updateNhaccu.ImportRow(row);
                        }
                        chitietTable.Columns["ID"].ColumnName = "phieunhap_id";
                        chitietTable.Columns["Mã nhạc cụ"].ColumnName = "nhaccu_id";
                        chitietTable.Columns["Đơn giá"].ColumnName = "chiPhiNhap";
                        chitietTable.Columns["SL"].ColumnName = "soLuong";
                        if (fileHandler.ImportConstraint(chitietTable, "chitietphieunhap", getSqlString(ph)) == true)
                        {
                            foreach (DataRow row in updateNhaccu.Rows)
                            {
                                nhacCuBUS.tangSL(Convert.ToInt32(row["Mã nhạc cụ"]), Convert.ToInt16(row["SL"]));
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin import vào không hợp lệ !");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Format của file nhập không hợp lệ");
                return false;
            }
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
