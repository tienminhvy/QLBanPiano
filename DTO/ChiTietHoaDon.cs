using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.DTO
{
    public class ChiTietHoaDon
    {
        private int nhaccu_id;
        private int hoadon_id;
        private long donGia;
        private short soLuong;
        public ChiTietHoaDon() { }

        public ChiTietHoaDon(int nhaccu_id, int hoadon_id, long donGia, short soLuong)
        {
            this.nhaccu_id = nhaccu_id;
            this.hoadon_id = hoadon_id;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        public int nhaccu_Id {  get { return nhaccu_id; } set { nhaccu_id = value;} }
        public int hoadon_Id { get { return hoadon_id; } set {  hoadon_id = value; } }
        public short SoLuong { get { return soLuong; } set { soLuong = value; } }
        public long DonGia { get {return donGia; } set { donGia = value; } }
    }
}
