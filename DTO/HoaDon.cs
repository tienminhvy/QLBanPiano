using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.DTO
{
    public class HoaDon
    {
        private int id;
        private DateTime thoiGian;
        private NhanVien nhanVien;
        private KhachHang khachHang;
        private List<NhacCu> dsNhacCu;
        private List<long> donGiaLucBan;
        private List<int> soLuong;

        public int Id { get => id; set => id = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public NhanVien NhanVien { get => nhanVien; set => nhanVien = value; }
        public KhachHang KhachHang { get => khachHang; set => khachHang = value; }
        public List<NhacCu> DsNhacCu { get => dsNhacCu; set => dsNhacCu = value; }
        public List<long> DonGiaLucBan { get => donGiaLucBan; set => donGiaLucBan = value; }
        public List<int> SoLuong { get => soLuong; set => soLuong = value; }

        public HoaDon()
        {
            id = -1;
            // all null
            thoiGian = DateTime.Now;
            nhanVien = null;
            khachHang = null;
            dsNhacCu = null;
            donGiaLucBan = null;
            soLuong = null;
        }

        public HoaDon(int id, DateTime thoiGian, NhanVien nhanVien, KhachHang khachHang, List<NhacCu> dsNhacCu, List<long> donGiaLucBan, List<int> soLuong)
        {
            Id = id;
            ThoiGian = thoiGian;
            NhanVien = nhanVien;
            KhachHang = khachHang;
            DsNhacCu = dsNhacCu;
            DonGiaLucBan = donGiaLucBan;
            SoLuong = soLuong;
        }
        private DateTime ngayMuaHang;
        private int nhanVien_Id;
        private int khachHang_Id;

        public int Id {  get { return id; } set {  id = value; } }
        public DateTime NgayMuaHang { get {  return ngayMuaHang; } set {  ngayMuaHang = value; } }
        public int NhanVien_Id { get {  return nhanVien_Id; } set { nhanVien_Id = value; } }
        public int KhachHang_Id { get { return khachHang_Id; } set { khachHang_Id = value; } }
    }
}