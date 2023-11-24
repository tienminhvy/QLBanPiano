using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.DTO
{
    public class NhanVien : DoiTuong
    {
        // Gồm thuộc tính id, họ lót, tên, ngày vào làm, số điện thoại, địa chỉ
        private int id;
        private string hoLot;
        private string ten;
        private DateTime ngayVaoLam;
        private string soDienThoai;
        private string diaChi;

        public int Id { get => id; set => id = value; }
        public string HoLot { get => hoLot; set => hoLot = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime NgayVaoLam { get => ngayVaoLam; set => ngayVaoLam = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public NhanVien()
        {
            Id = -1;
            HoLot = "";
            Ten = "";
            NgayVaoLam = DateTime.Now;
            SoDienThoai = "";
            DiaChi = "";
        }

        public NhanVien(int id, string hoLot, string ten, DateTime ngayVaoLam, string soDienThoai, string diaChi)
        {
            Id = id;
            HoLot = hoLot;
            Ten = ten;
            NgayVaoLam = ngayVaoLam;
            SoDienThoai = soDienThoai;
            DiaChi = diaChi;
        }
    }
}