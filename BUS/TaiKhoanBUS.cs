using QLBanPiano.DAL;
using QLBanPiano.DTO;
using QLBanPiano.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.BUS
{
    class TaiKhoanBUS : IBUS
    {
        DB db;

        public TaiKhoanBUS()
        {
            db = new DB();
        }
        public object GiaTriTruong(string tenTruong, string dieuKien)
        {
            return db.GetColumn("taikhoan", tenTruong, dieuKien);
        }
        public List<DoiTuong> LayDS(string dieuKien)
        {
            throw new NotImplementedException();
        }
        public DataTable LayToanBoDS()
        {
            throw new NotImplementedException();
        }
        public int SoLuong(string dieuKien)
        {
            throw new NotImplementedException();
        }
        public bool Sua(params string[] dsTruong)
        {
            string id = dsTruong[0];
            string tenDangNhap = dsTruong[1];
            string matKhau = dsTruong[2];
            string nhanvien_id = dsTruong[3];
            string vaitro_id = dsTruong[4];

            db.ExecuteNonQuery(string.Format("UPDATE taikhoan " +
                "SET tenDangNhap = '{0}', " +
                "matKhau = '{1}', " +
                "nhanvien_id = '{2}', " +
                "vaitro_id = '{3}', " +
                "WHERE id = '{4}'",
                tenDangNhap,
                matKhau,
                nhanvien_id,
                vaitro_id,
                id));

            return true;
        }
        public bool Them(params string[] dsTruong)
        {
            string id = dsTruong[0];
            string tenDangNhap = dsTruong[1];
            string matKhau = dsTruong[2];
            string nhanvien_id = dsTruong[3];
            string vaitro_id = dsTruong[4];

            db.ExecuteNonQuery(string.Format("INSERT INTO taikhoan (tenDangNhap, matKhau, " +
                "nhanvien_id, vaitro_id, trangthai) " +
                "VALUES ({1}, {2}, {3}, {4}, 1)",
                tenDangNhap,
                matKhau,
                nhanvien_id,
                vaitro_id));

            return true;
        }
        public bool Validate(params string[] dsTruong)
        {
            string id = dsTruong[0];
            string tenDangNhap = dsTruong[1];
            string matKhau = dsTruong[2];
            string nhanvien_id = dsTruong[3];
            string vaitro_id = dsTruong[4];
            
            //kiem tra cac truong thong tin co rong hay khong
            if (id.Equals("") || tenDangNhap.Equals("") || matKhau.Equals("") 
                || nhanvien_id.Equals("") || vaitro_id.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }

            return true;

        }
        public bool Xoa(string tieuChi)
        {
            db.ExecuteNonQuery(string.Format("UPDATE taikhoan" +
                "SET trangthai =0" + "WHERE {1}", tieuChi));

            return true;
        }

        public bool DangNhap(string tenDangNhap, string matKhau)
        {
            if (tenDangNhap == string.Empty)
            {
                new Msg("Tên đăng nhập không được để trống!", "err");
                return false;
            }
            int count = db.GetCount("taikhoan", "tenDangNhap = N'" + tenDangNhap + "'");
            if (count > 0)
            {
                bool trangThai = (bool) db.GetColumn("taikhoan", "trangthai", "tenDangNhap = N'" + tenDangNhap + "'");
                if (!trangThai)
                {
                    new Msg("Tài khoản đã bị khoá!", "err");
                    return false;
                } else if (matKhau == string.Empty)
                {
                    new Msg("Mật khẩu không được để trống!", "err");
                    return false;
                } else
                {
                    count = (int) db.GetCount("taikhoan", "tenDangNhap = N'" + tenDangNhap + "' AND matKhau = N'"+matKhau+"'");
                    if (count > 0)
                    {
                        new Msg("Đăng nhập thành công!");
                        return true;
                    } else
                    {
                        new Msg("Sai mật khẩu!", "err");
                        return false;
                    }
                }
            } else
            {
                new Msg("Không tồn tại tên đăng nhập!", "err");
            }
            return false;
        }
    }
}
