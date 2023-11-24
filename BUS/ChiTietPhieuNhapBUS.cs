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
    internal class ChiTietPhieuNhapBUS : IBUS
    {
        DB db;
        public ChiTietPhieuNhapBUS()
        {
            db = new();
        }
        public DataTable LayChiTietPhieuNhap(int id)
        {
            string sqlCmd = "select chitietphieunhap.phieunhap_id as 'ID', chitietphieunhap.nhaccu_id as N'Mã nhạc cụ',nhaccu.ten as N'Tên nhạc cụ',chiPhiNhap as N'Đơn giá',chitietphieunhap.soLuong as 'SL',phieunhap.nhanvien_id as N'Mã nhân viên',concat(nhanvien.hoLot,' ',nhanvien.ten) as N'Nhân viên',phieunhap.thoiGian as N'Thời gian'\r\nfrom chitietphieunhap\r\ninner join nhaccu on nhaccu.id = chitietphieunhap.nhaccu_id\r\ninner join phieunhap on phieunhap.id = chitietphieunhap.phieunhap_id\r\ninner join nhanvien on nhanvien.id = phieunhap.nhanvien_id\r\nwhere chitietphieunhap.phieunhap_id = " + id;
            DataTable dt = db.Execute(sqlCmd);
            return dt;
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
