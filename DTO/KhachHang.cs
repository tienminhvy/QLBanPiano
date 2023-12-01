using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.DTO
{
    public class KhachHang : DoiTuong
    {
        // gồm các thuộc tính họ lót, tên, địa chỉ, số điện thoại
        private int id;
        private string hoLot;
        private string ten;
        private string diaChi;
        private string soDienThoai;

        public int Id { get { return id; } set { id = value; } }
        public string HoLot { get { return hoLot; } set { hoLot = value; } }
        public string Ten { get { return ten; } set { ten = value; } }
        public string DiaChi { get { return diaChi; } set { diaChi = value; } }
        public string SoDienThoai { get { return soDienThoai; } set { soDienThoai = value;  } }

        public KhachHang() 
        {
            id = -1;
            hoLot = " ";
            ten = " ";
            diaChi = " ";
            soDienThoai = " ";
        }

        public KhachHang(int id, string hoLot, string ten, string diaChi, string soDienThoai)
        {
            Id = id;
            HoLot = hoLot;
            Ten = ten;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
        }

        public bool Sua(dynamic[] args)
        {
            throw new NotImplementedException();
        }
    }
}