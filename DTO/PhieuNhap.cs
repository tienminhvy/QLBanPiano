using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.DTO
{
    public class PhieuNhap
    {
        // gồm các trường id, thời gian, nhân viên, danh sách nhạc cụ
        // danh sách đơn giá lúc bán, danh sách số lượng

        private int id;
        private NhanVien nhanVien;
        private DateTime thoiGian;
        private List<NhacCu> dsNhacCu;
        private List<long> donGiaLucBan;
        private List<int> soLuong;

        public int Id { get => id; set => id = value; }
        public NhanVien NhanVien { get => nhanVien; set => nhanVien = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public List<NhacCu> DsNhacCu { get => dsNhacCu; set => dsNhacCu = value; }
        public List<long> DonGiaLucBan { get => donGiaLucBan; set => donGiaLucBan = value; }
        public List<int> SoLuong { get => soLuong; set => soLuong = value; }

        public PhieuNhap()
        {
            id = -1;
            // all null
            thoiGian = DateTime.Now;
            nhanVien = null;
            dsNhacCu = null;
            donGiaLucBan = null;
            soLuong = null;
        }

        public PhieuNhap(int id, NhanVien nhanVien, DateTime thoiGian, List<NhacCu> dsNhacCu, List<long> donGiaLucBan, List<int> soLuong)
        {
            Id = id;
            NhanVien = nhanVien;
            ThoiGian = thoiGian;
            DsNhacCu = dsNhacCu;
            DonGiaLucBan = donGiaLucBan;
            SoLuong = soLuong;
        }
    }
}