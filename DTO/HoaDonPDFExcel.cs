using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.DTO
{
    public class HoaDonPDFExcel : DoiTuong
    {
        private int id;
        private DateTime thoiGian;
        private int nhanVien_id;
        private int khachHang_id;
        //private List<NhacCu> dsNhacCu;
        //private List<long> donGiaLucBan;
        //private List<int> soLuong;
        private List<ChiTietHoaDon> list;

        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public int NhanVien_id { get => nhanVien_id; set => nhanVien_id = value; }
        public int KhachHang_id { get => khachHang_id; set => khachHang_id = value; }
        //public List<NhacCu> DsNhacCu { get => dsNhacCu; set => dsNhacCu = value; }
        //public List<long> DonGiaLucBan { get => donGiaLucBan; set => donGiaLucBan = value; }
        //public List<int> SoLuong { get => soLuong; set => soLuong = value; }

        public HoaDonPDFExcel()
        {
            id = -1;
            // all null
            thoiGian = DateTime.Now;
            nhanVien_id = -1;
            khachHang_id = -1;
            list = null;
            //dsNhacCu = null;
            //donGiaLucBan = null;
            //soLuong = null;
        }

        public HoaDonPDFExcel(int id, DateTime thoiGian, int nhanVien_id, int khachHang_id,List<ChiTietHoaDon> list /*List<NhacCu> dsNhacCu, List<long> donGiaLucBan, List<int> soLuong*/)
        {
            Id = id;
            ThoiGian = thoiGian;
            NhanVien_id = nhanVien_id;
            KhachHang_id = khachHang_id;
            List = list;
            //DsNhacCu = dsNhacCu;
            //DonGiaLucBan = donGiaLucBan;
            //SoLuong = soLuong;
        }
        private DateTime ngayMuaHang;
        private int nhanVien_Id;
        private int khachHang_Id;


        public int Id { get { return id; } set { id = value; } }
        //public DateTime NgayMuaHang { get { return ngayMuaHang; } set { ngayMuaHang = value; } }
        //public int NhanVien_Id { get { return nhanVien_Id; } set { nhanVien_Id = value; } }
        //public int KhachHang_Id { get { return khachHang_Id; } set { khachHang_Id = value; } }

        public List<ChiTietHoaDon> List { get { return list; } set {list = value; } }

        public bool Sua(dynamic[] args)
        {
            throw new NotImplementedException();
        }
    }
}