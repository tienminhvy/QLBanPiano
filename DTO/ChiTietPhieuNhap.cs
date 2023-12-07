using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.DTO
{
    public class ChiTietPhieuNhap
    {
        private int phieunhap_id;
        private int nhaccu_id;
        private long donGia;
        private int soLuong;
        
        public ChiTietPhieuNhap()
        {
            phieunhap_Id = -1;
            nhaccu_Id = -1;
            donGia = 0;
            soLuong = 0;
        }
        public ChiTietPhieuNhap(int phieunhap_id, int nhaccu_id, long donGia, int soLuong)
        {
            this.phieunhap_id = phieunhap_id;
            this.nhaccu_id = nhaccu_id;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        public int phieunhap_Id {  get { return phieunhap_id;} set { phieunhap_id = value; } }
        public int nhaccu_Id { get { return nhaccu_id;} set {  nhaccu_id = value; } }
        public long DonGia { set { donGia = value; } get {return donGia; } } 

        public int SoLuong { get {return soLuong; } set { soLuong = value; } }

        private string ma_nhaccu;
        public string Ma_NhacCu { get { return ma_nhaccu; } set { ma_nhaccu = value; } }
    }
}
