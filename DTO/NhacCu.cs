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
        private int gia;
        private string hinhAnh;

        public int Id { get { return id; } set {  id = value; } }
        public string Ma { get { return ma; } set { ma = value; } }
        public string Ten { get { return ten; } set { ten = value; } }
        public string DacDiemNoiBat { get {  return dacDiemNoiBat; } set {  dacDiemNoiBat = value; } }
        public string MoTaChiTiet { get { return moTaChiTiet; } set { moTaChiTiet = value; } }
        public int Gia { get { return gia; } set {  gia = value; } }
        public string HinhAnh { get {  return hinhAnh; } set {  hinhAnh = value; } }

        public NhacCu()
        {
            this.id = -1;
            this.ma = "";
            this.ten = "";
            this.dacDiemNoiBat = "";
            this.moTaChiTiet = "";
            this.gia = 0;
            this.hinhAnh = "";
        }
        public NhacCu(int id, string ma, string ten, string dacDiemNoiBat,
            string moTaChiTiet, int gia, string hinhAnh)
        {
            this.id = id;
            this.ma = ma;
            this.ten = ten;
            this.dacDiemNoiBat = dacDiemNoiBat;
            this.moTaChiTiet = moTaChiTiet;
            this.gia = gia;
            this.hinhAnh = hinhAnh;
        }
    }
}
