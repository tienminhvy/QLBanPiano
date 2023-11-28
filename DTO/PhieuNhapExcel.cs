using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.DTO
{
    public class PhieuNhapExcel
    {
        // gồm các trường id, thời gian, nhân viên, danh sách nhạc cụ
        // danh sách đơn giá lúc bán, danh sách số lượng

        private int id;
        private int id_nhanvien; // Sửa từ NhanVien thành int cho dễ quản lý với khởi tạo
        private DateTime thoiGian;
        private List<ChiTietPhieuNhap> phieuNhapList;
        //private List<NhacCu> dsNhacCu;
        //private List<long> donGiaLucBan;
        //private List<int> soLuong;

        public int Id { get => id; set => id = value; }
        public int Id_nhanvien { get => id_nhanvien; set => id_nhanvien = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }

        public List<ChiTietPhieuNhap> PhieuNhapList { get {return phieuNhapList; } set {phieuNhapList = value; } }//Nam thêm
        //public List<NhacCu> DsNhacCu { get => dsNhacCu; set => dsNhacCu = value; }
        //public List<long> DonGiaLucBan { get => donGiaLucBan; set => donGiaLucBan = value; }
        //public List<int> SoLuong { get => soLuong; set => soLuong = value; }

        public PhieuNhapExcel()
        {
            id = -1;
            // all null
            thoiGian = DateTime.Now;
            id_nhanvien = -1;
            phieuNhapList = null;
            //dsNhacCu = null;
            //donGiaLucBan = null;
            //soLuong = null;
        }

        public PhieuNhapExcel(int id, int id_nhanvien, DateTime thoiGian,List<ChiTietPhieuNhap> phieuNhapList/*, List<NhacCu> dsNhacCu, List<long> donGiaLucBan, List<int> soLuong*/)
        {
            Id = id;
            Id_nhanvien = id_nhanvien;
            ThoiGian = thoiGian;
            PhieuNhapList = phieuNhapList;
            //DsNhacCu = dsNhacCu;
            //DonGiaLucBan = donGiaLucBan;
            //SoLuong = soLuong;
        }
    }
}