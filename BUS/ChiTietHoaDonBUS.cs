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

        public bool Them(params string[] dsTruong)
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
    }
}
