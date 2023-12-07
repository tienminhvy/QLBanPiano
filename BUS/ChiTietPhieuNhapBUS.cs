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
using QLBanPiano.GUI;

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
            string sqlCmd = "select chitiet_hdpn.id_hdpn as 'ID', chitiet_hdpn.nhaccu_id as N'Mã nhạc cụ',nhaccu.ten as N'Tên nhạc cụ',donGia as N'Đơn giá',chitiet_hdpn.soLuong as 'SL',hoadonphieunhap.nhanvien_id as N'Mã nhân viên',concat(nhanvien.hoLot,' ',nhanvien.ten) as N'Nhân viên',hoadonphieunhap.thoiGian as N'Thời gian'\r\nfrom chitiet_hdpn\r\ninner join nhaccu on nhaccu.id = chitiet_hdpn.nhaccu_id\r\ninner join hoadonphieunhap on hoadonphieunhap.id = chitiet_hdpn.id_hdpn\r\ninner join nhanvien on nhanvien.id = hoadonphieunhap.nhanvien_id\r\nwhere chitiet_hdpn.id_hdpn = " + id;
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
        public List<ChiTietPhieuNhap> getListChiTietExcel(DataTable dt)
        {
            NhacCuBUS nhaccuBUS = new();
            List<ChiTietPhieuNhap> list = new();
            foreach (DataRow row in dt.Rows)
            {
                ChiTietPhieuNhap chitiet = new();
                chitiet.phieunhap_Id = Convert.ToInt32(row["ID"]);
                string id_or_ma = Convert.ToString(row["Mã nhạc cụ"]);

                if (int.TryParse(id_or_ma, out int id))
                { // khi xuất
                    string ma = nhaccuBUS.GiaTriTruong("ma", "id = " + id + " AND trangthai = 1").ToString();
                    chitiet.Ma_NhacCu = ma;
                }
                else
                { // Khi nhập
                    chitiet.Ma_NhacCu = id_or_ma;
                }

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
        public DataTable formatToImport(DataTable dt)
        {
            DataTable table = new();
            table.Columns.Add("id_hdpn",typeof(int));
            table.Columns.Add("nhaccu_id",typeof(int));
            table.Columns.Add("donGia",typeof(long));
            table.Columns.Add("soLuong",typeof(int));
            foreach(DataRow row in dt.Rows) {
                DataRow tableRow = table.NewRow();
                tableRow["id_hdpn"] = row["ID"];
                tableRow["nhaccu_id"] = row["Mã nhạc cụ"];
                tableRow["donGia"] = row["Đơn giá"];
                tableRow["soLuong"] = row["SL"];
                table.Rows.Add(tableRow);
            }
            return table;
        }
        public bool Validates(ChiTietPhieuNhap chitiet)
        {
            NhacCuBUS nhaccuBUS = new();
            if (pianobus.checkExist("nhaccu", chitiet.Ma_NhacCu) == false)
            {
                new Msg("Không tìm thấy mã nhạc cụ " + chitiet.Ma_NhacCu, "err");
                return false;
            }
            else
            {
                int id = Convert.ToInt32(nhaccuBUS.GiaTriTruong("ID", "ma = '" + chitiet.Ma_NhacCu + "' AND trangthai = 1"));
                chitiet.nhaccu_Id = id;
            }
            if (chitiet.DonGia < 500000 || chitiet.DonGia > 25000000000)
            {
                new Msg("Mã nhạc cụ " + chitiet.Ma_NhacCu + " có giá nhập không hợp lệ, \n" +
                    "Giá nhập phải nằm trong khoảng từ trên 500,000đ đến dưới 25 tỷ đồng.", "err");
                return false;
            }
            if (chitiet.SoLuong <= 0 || chitiet.SoLuong >= 100)
            {
                new Msg("Mã nhạc cụ " + chitiet.Ma_NhacCu + " có số lượng nhập không hợp lệ, \n" +
                    "Số lượng nhập phải nằm trong khoảng từ lớn hơn 0 đến dưới 100 sản phẩm.", "err");
                return false;
            }
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
