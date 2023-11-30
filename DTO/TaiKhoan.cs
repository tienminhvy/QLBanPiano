using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.DTO
{
    public class TaiKhoan : DoiTuong
    {
        // gồm các trường id, tên đăng nhập, mật khẩu
        // nhân viên, vai trò
        private int id;
        private string tenDangNhap;
        private string matKhau;
        private NhanVien nhanVien;
        private VaiTro vaiTro;

        public int Id { get => id; set => id = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public NhanVien NhanVien { get => nhanVien; set => nhanVien = value; }
        public VaiTro VaiTro { get => vaiTro; set => vaiTro = value; }

        public TaiKhoan()
        {
            Id = -1;
            TenDangNhap = "";
            MatKhau = "";
            NhanVien = null;
            VaiTro = null;
        }

        public TaiKhoan(int id, string tenDangNhap, string matKhau, NhanVien nhanVien, VaiTro vaiTro)
        {
            Id = id;
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            NhanVien = nhanVien;
            VaiTro = vaiTro;
        }
    }
}