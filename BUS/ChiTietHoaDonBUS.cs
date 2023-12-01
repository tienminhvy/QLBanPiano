using QLBanPiano.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanPiano.DAL;

namespace QLBanPiano.BUS
{
    public class ChiTietHoaDonBUS : IBUS
    {
        PianoBUS pianobus = new();
        DB db;

        public ChiTietHoaDonBUS()
        {
            db = new DB();
        }
        public DataTable LayChiTietHoaDon(int id) 
        {
            string sqlCmd = "select chitiethoadon.hoadon_id as 'ID',chitiethoadon.nhaccu_id as N'Mã nhạc cụ',nhaccu.ten as N'Tên nhạc cụ',chitiethoadon.soLuong as 'SL' ,chitiethoadon.donGiaLucBan as N'Đơn giá',hoadon.thoiGian as N'Thời gian',hoadon.nhanvien_id as N'Mã nhân viên',concat(nhanvien.hoLot,' ',nhanvien.ten) as N'Tên nhân viên',hoadon.khachhang_id as N'Mã khách hàng',concat(khachhang.hoLot,' ',khachhang.ten) as N'Tên khách hàng'\r\nfrom chitiethoadon\r\ninner join hoadon on hoadon.id = chitiethoadon.hoadon_id\r\ninner join nhaccu on chitiethoadon.nhaccu_id = nhaccu.id\r\ninner join khachhang on hoadon.khachhang_id = khachhang.id\r\ninner join nhanvien on hoadon.nhanvien_id = nhanvien.id\r\nwhere chitiethoadon.hoadon_id = " + id;
            DataTable dt = db.Execute(sqlCmd);
            return dt;
        }
        public bool Them(params string[] dsTruong)
        {
            try
            {
                int nhaccu_id = Convert.ToInt32(dsTruong[0]);
                int hoadon_id = Convert.ToInt32(dsTruong[1]);
                long dongia = Convert.ToInt64(dsTruong[2]);
                short soLuong = Convert.ToInt16(dsTruong[3]);

                string sqlCmd = string.Format("insert into chitiethoadon (nhaccu_id,hoadon_id,donGiaLucBan,soLuong)\r\nvalues ({0},{1},{2},{3})",nhaccu_id,hoadon_id,dongia,soLuong);
                db.ExecuteNonQuery(sqlCmd);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public DataTable splitFromExcelTable(DataTable excel)
        {
            DataTable dt = new();

            return dt;
        }
        public DataTable ListToDataTable(List<ChiTietHoaDon> list)
        {
            DataTable result = new();
            if(list != null )
            {
                var properties = list[0].GetType().GetProperties();
                foreach(var prop in properties)
                {
                    result.Columns.Add(prop.Name,prop.PropertyType);
                }
                foreach(var chitiet in  list)
                {
                    DataRow row = result.NewRow();
                    foreach(var prop in properties)
                    {
                        row[prop.Name] = prop.GetValue(chitiet);
                    }
                    result.Rows.Add(row);   
                }
            }
            return result;
        }
        public List<ChiTietHoaDon> DatatableToList(DataTable table)
        {
            List<ChiTietHoaDon> list = table.AsEnumerable().Select(row => new ChiTietHoaDon
            {
                hoadon_Id = Convert.ToInt32(row["ID"]),
                nhaccu_Id = Convert.ToInt32(row["Mã nhạc cụ"]),
                DonGia = Convert.ToInt64(row["Đơn giá"]),
                SoLuong = Convert.ToInt16(row["SL"])
            }).ToList();
            return list;    

        }
        public bool Validates(ChiTietHoaDon chitiet)
        {
            if (pianobus.checkExist("nhaccu",chitiet.nhaccu_Id) == false) return false;
            if (chitiet.DonGia < 500000 || chitiet.DonGia > 25000000000) return false;
            if (chitiet.SoLuong <= 0 || chitiet.SoLuong >= 100) return false;
            return true;
        }
        public bool ValidateList(List<ChiTietHoaDon> list)
        {
            foreach (var chitiet in list)
            {
                if (Validates(chitiet) == false)
                {
                    return false;
                }
            }
            return true;
        }
        public DataTable convertToDataTable(List<ChiTietHoaDon> list)
        {
            DataTable dt = new();
            ChiTietHoaDon chitiet = new();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Mã nhạc cụ", typeof(int));
            dt.Columns.Add("Đơn giá", typeof(long));
            dt.Columns.Add("SL", typeof(short));
            foreach (var obj in list)
            {
                DataRow row = dt.NewRow();
                row["ID"] = obj.hoadon_Id;
                row["Mã nhạc cụ"] = obj.nhaccu_Id;
                row["Đơn giá"] = obj.DonGia;
                row["SL"] = obj.SoLuong;
                dt.Rows.Add(row);
            }
            return dt;
        }
        //////////////////////////////////////////////////////
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

        public DataTable LayToanBoDS()
        {
            throw new NotImplementedException();
        }

        public bool Validate(params string[] dsTruong)
        {
            throw new NotImplementedException();
        }
    }
}
