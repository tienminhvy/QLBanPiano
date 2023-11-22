using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.DTO
{
    public class HoaDon : DoiTuong
    {
        private int id;
        private DateTime ngayMuaHang;
        private int nhanVien_Id;
        private int khachHang_Id;


        public int Id {  get { return id; } set {  id = value; } }
        public DateTime NgayMuaHang { get {  return ngayMuaHang; } set {  ngayMuaHang = value; } }
        public int NhanVien_Id { get {  return nhanVien_Id; } set { nhanVien_Id = value; } }
        public int KhachHang_Id { get { return khachHang_Id; } set { khachHang_Id = value; } }

        public bool Sua(dynamic[] args)
        {
            throw new NotImplementedException();
        }
    }
}
