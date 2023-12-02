using QLBanPiano.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanPiano.DAL;
using System.Reflection.Metadata.Ecma335;
using DocumentFormat.OpenXml.Presentation;

namespace QLBanPiano.BUS
{
    internal class ChiTietPhieuNhapBUS : IBUS
    {
        PianoBUS pianobus = new();
        DB db;
        public ChiTietPhieuNhapBUS()
        {
            db = new();
        }
        public DataTable LayChiTietPhieuNhap(int id)
        {
            string sqlCmd = "select chitiet_hdpn.phieunhap_id as 'ID', chitiet_hdpn.nhaccu_id as N'Mã nhạc cụ',nhaccu.ten as N'Tên nhạc cụ',donGia as N'Đơn giá',chitiet_hdpn.soLuong as 'SL',phieunhap.nhanvien_id as N'Mã nhân viên',concat(nhanvien.hoLot,' ',nhanvien.ten) as N'Nhân viên',phieunhap.thoiGian as N'Thời gian'\r\nfrom chitiet_hdpn\r\ninner join nhaccu on nhaccu.id = chitiet_hdpn.nhaccu_id\r\ninner join phieunhap on phieunhap.id = chitiet_hdpn.phieunhap_id\r\ninner join nhanvien on nhanvien.id = phieunhap.nhanvien_id\r\nwhere chitiet_hdpn.phieunhap_id = " + id;
            DataTable dt = db.Execute(sqlCmd);
            return dt;
        }
        public DataTable splitFromRawExcelTable(DataTable excel)
        {
            DataTable dt = excel.Clone();
            foreach (DataRow dr in excel.Rows) {
                dt.ImportRow(dr);
            }
            dt.Columns.Remove("ID");
            dt.Columns.Remove("Thời gian");
            dt.Columns.Remove("Mã nhân viên");
            return dt;
        }
        public List<ChiTietPhieuNhap> getListChiTiet(DataTable dt)
        {
            List<ChiTietPhieuNhap> list = new();
            foreach(DataRow row in dt.Rows)
            {
                ChiTietPhieuNhap chitiet = new();
                chitiet.phieunhap_Id = Convert.ToInt32(row["ID"]);
                chitiet.nhaccu_Id = Convert.ToInt32(row["Mã nhạc cụ"]);
                chitiet.DonGia = Convert.ToInt64(row["Đơn giá"]);
                chitiet.SoLuong = Convert.ToInt16(row["SL"]);
                list.Add(chitiet);
            }
            return list;
        }
        public DataTable convertToDataTable(List<ChiTietPhieuNhap> list)
        {
            DataTable dt = new();
            ChiTietPhieuNhap chitiet = new();
            dt.Columns.Add("ID",typeof(int));
            dt.Columns.Add("Mã nhạc cụ",typeof(int));
            dt.Columns.Add("Đơn giá",typeof(long));
            dt.Columns.Add("SL",typeof(short));
            foreach(var obj in list)
            {
                DataRow row = dt.NewRow();
                row["ID"] = obj.phieunhap_Id;
                row["Mã nhạc cụ"] = obj.nhaccu_Id;
                row["Đơn giá"] = obj.DonGia;
                row["SL"] = obj.SoLuong;
                dt.Rows.Add(row);
            }
            return dt;
        }
        public bool Validates(ChiTietPhieuNhap chitiet)
        {
            if (pianobus.checkExist("nhaccu", chitiet.nhaccu_Id) == false) return false;
            if (chitiet.DonGia < 500000 || chitiet.DonGia > 25000000000) return false;
            if (chitiet.SoLuong <= 0 || chitiet.SoLuong >= 100) return false;
            return true;
        }
        public bool ValidateList(List<ChiTietPhieuNhap> list)
        {
            foreach(var chitiet in list)
            {
                if(Validates(chitiet) == false) {
                    return false;
                }
            }
            return true;
        }
        //////////////////////////////////////////
        public object GiaTriTruong(string tenTruong, string dieuKien)
        {
            throw new NotImplementedException();
        }

        public List<DoiTuong> LayDS(string dieukien)
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
