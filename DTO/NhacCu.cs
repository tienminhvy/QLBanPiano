using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.DTO
{
    public class NhacCu : DoiTuong
    {
        private int id;
        private string ma;
        private string ten;
        private string dacDiemNoiBat;
        private string moTaChiTiet;
        private long gia;
        private string hinhAnh;
        private int soLuong;
        private ThuongHieu thuongHieu;

        public int Id { get { return id; } set { id = value; } }
        public string Ma { get { return ma; } set { ma = value; } }
        public string Ten { get { return ten; } set { ten = value; } }
        public string DacDiemNoiBat { get { return dacDiemNoiBat; } set { dacDiemNoiBat = value; } }
        public string MoTaChiTiet { get { return moTaChiTiet; } set { moTaChiTiet = value; } }
        public long Gia { get { return gia; } set { gia = value; } }
        public string HinhAnh { get { return hinhAnh; } set { hinhAnh = value; } }
        public int SoLuong { get { return soLuong; } set { soLuong = value; } }
        public ThuongHieu ThuongHieu { get { return thuongHieu; } set { thuongHieu = value; } }

        public NhacCu()
        {
            Id = -1;
            Ma = "";
            Ten = "";
            DacDiemNoiBat = "";
            MoTaChiTiet = "";
            Gia = 0;
            HinhAnh = "";
            SoLuong = 0;
            ThuongHieu = null;
        }
        public NhacCu(int id, string ma, string ten, string dacDiemNoiBat,
            string moTaChiTiet, long gia, string hinhAnh, int soLuong, ThuongHieu thuongHieu)
        {
            Id = id;
            Ma = ma;
            Ten = ten;
            DacDiemNoiBat = dacDiemNoiBat;
            MoTaChiTiet = moTaChiTiet;
            Gia = gia;
            HinhAnh = hinhAnh;
            SoLuong = soLuong;
            ThuongHieu = thuongHieu;
        }
    }
}