using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.DTO
{
    public class HoaDon
    {
        private string id;
        private DateTime ngayMuaHang;
        private string nhanVien_Id;
        private string khachHang_Id;

        public string Id {  get { return id; } set {  id = value; } }
        public DateTime NgayMuaHang { get {  return ngayMuaHang; } set {  ngayMuaHang = value; } }
        public string NhanVien_Id { get {  return nhanVien_Id; } set { nhanVien_Id = value; } }
        public string KhachHang_Id { get { return khachHang_Id; } set { khachHang_Id = value; } }
    }
}
