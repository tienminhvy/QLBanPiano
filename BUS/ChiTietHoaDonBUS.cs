using QLBanPiano.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanPiano.DAL;
using QLBanPiano.GUI;

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
            string sqlCmd = "select chitiet_hdpn.id_hdpn as 'ID',chitiet_hdpn.nhaccu_id as N'Mã nhạc cụ',nhaccu.ten as N'Tên nhạc cụ',chitiet_hdpn.soLuong as 'SL' ,chitiet_hdpn.donGia as N'Đơn giá',hoadonphieunhap.thoiGian as N'Thời gian',hoadonphieunhap.nhanvien_id as N'Mã nhân viên',concat(nhanvien.hoLot,' ',nhanvien.ten) as N'Tên nhân viên',hoadonphieunhap.khachhang_id as N'Mã khách hàng',concat(khachhang.hoLot,' ',khachhang.ten) as N'Tên khách hàng'\r\nfrom chitiet_hdpn\r\ninner join hoadonphieunhap on hoadonphieunhap.id = chitiet_hdpn.id_hdpn\r\ninner join nhaccu on chitiet_hdpn.nhaccu_id = nhaccu.id\r\ninner join khachhang on hoadonphieunhap.khachhang_id = khachhang.id\r\ninner join nhanvien on hoadonphieunhap.nhanvien_id = nhanvien.id\r\nwhere chitiet_hdpn.id_hdpn = " + id;
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

                string sqlCmd = string.Format("insert into chitiet_hdpn (nhaccu_id,id_hdpn,donGia,soLuong)\r\nvalues ({0},{1},{2},{3})", nhaccu_id,hoadon_id,dongia,soLuong);
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
                SoLuong = Convert.ToInt32(row["SL"])
            }).ToList();
            return list;    

        }
        public List<ChiTietHoaDon> DatatableToListExcel(DataTable table)
        {
            NhacCuBUS nhacCuBUS = new();
            List<ChiTietHoaDon> list = table.AsEnumerable().Select(row => new ChiTietHoaDon
            {
                hoadon_Id = Convert.ToInt32(row["ID"]),
                Ma_NhacCu = Convert.ToString(row["Mã nhạc cụ"]),
                nhaccu_Id = Convert.ToInt32(
                    nhacCuBUS.SoLuong("Ma = '" + row["Mã nhạc cụ"] + "'") > 0 ? // Nếu tìm thấy mã nhạc cụ
                    nhacCuBUS.GiaTriTruong("id", "Ma = '"+ row["Mã nhạc cụ"] +"'") : 
                    -1 // nếu không tìm thấy mã nhạc cụ
                    ),
                DonGia = Convert.ToInt64(row["Đơn giá"]),
                SoLuong = Convert.ToInt32(row["SL"])
            }).ToList();
            return list;

        }
        public List<ChiTietHoaDon> DatatableToListExcelExport(DataTable table)
        {
            NhacCuBUS nhacCuBUS = new();
            List<ChiTietHoaDon> list = table.AsEnumerable().Select(row => new ChiTietHoaDon
            {
                hoadon_Id = Convert.ToInt32(row["ID"]),
                nhaccu_Id = Convert.ToInt32(row["Mã nhạc cụ"]),
                Ma_NhacCu = Convert.ToString(
                    nhacCuBUS.SoLuong("Id = '" + row["Mã nhạc cụ"] + "' AND trangthai = 1") > 0 ? // Nếu tìm thấy id nhạc cụ
                    nhacCuBUS.GiaTriTruong("Ma", "id = '" + row["Mã nhạc cụ"] + "'") :
                    -1 // nếu không tìm thấy id nhạc cụ
                    ),
                DonGia = Convert.ToInt64(row["Đơn giá"]),
                SoLuong = Convert.ToInt32(row["SL"])
            }).ToList();
            return list;

        }
        public bool Validates(ChiTietHoaDon chitiet)
        {
            if (pianobus.checkExist("nhaccu",chitiet.Ma_NhacCu) == false)
            {
                new Msg("Không tìm thấy mã nhạc cụ " + chitiet.Ma_NhacCu, "err");
                return false;
            }
            if (chitiet.DonGia < 500000 || chitiet.DonGia > 25000000000)
            {
                new Msg("Mã nhạc cụ " + chitiet.Ma_NhacCu + " có giá bán không hợp lệ, \n" +
                    "Giá bán phải nằm trong khoảng từ trên 500,000đ đến dưới 25 tỷ đồng.", "err");
                return false;
            }
            if (chitiet.SoLuong <= 0 || chitiet.SoLuong >= 100) {
                new Msg("Mã nhạc cụ " + chitiet.Ma_NhacCu + " có số lượng bán không hợp lệ, \n" +
                   "Số lượng bán phải nằm trong khoảng từ lớn hơn 0 đến dưới 100 sản phẩm.", "err");
                return false; 
            }
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
        private DataTable getName(int id)
        {
            string sqlCmd = "select ten as N'Tên'\r\nfrom nhaccu\r\nwhere id = "+id;
            DataTable dt = db.Execute(sqlCmd);
            return dt;
        }
        public DataTable formatToExport (DataTable table)
        {
            DataTable result = new();
            List<string> listTen = new();
            DataTable temp = new();
            foreach (DataRow row in table.Rows)
            {
                temp = getName(Convert.ToInt32(row["Mã nhạc cụ"]));
                string tempo = temp.Rows[0]["Tên"].ToString();
                listTen.Add(tempo);
            }
            result.Columns.Add("Tên sản phẩm", typeof(string));
            result.Columns.Add("SL", typeof(int));
            result.Columns.Add("Đơn giá", typeof(long));
            result.Columns.Add("Tổng tiền", typeof(long));

            int i = 1;
            foreach (DataRow row in table.Rows)
            {
                DataRow newRow = result.NewRow();
                newRow["Tên sản phẩm"] = i.ToString() + "  " + listTen[i-1];
                newRow["SL"] = Convert.ToInt32(row["SL"]);
                //newRow["Đơn giá"] = Convert.ToInt64(row["Đơn giá"]);
                newRow["Tổng tiền"] = Convert.ToInt64(Convert.ToInt32(row["SL"]) * Convert.ToInt64(row["Đơn giá"]));
                i++;
                result.Rows.Add(newRow);
            }
            return result;
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
