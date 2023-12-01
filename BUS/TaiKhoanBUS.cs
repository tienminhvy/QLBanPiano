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
            string sqlStr = "SELECT " +
                "* " +
                "FROM taikhoan " +
                "WHERE " + dieuKien;

            DataTable dt = db.Execute(sqlStr);
            List<DoiTuong> ds = new List<DoiTuong>();

            VaiTroBUS vtBUS = new VaiTroBUS();

            foreach (DataRow row in dt.Rows)
            {
                TaiKhoan taiKhoan = new TaiKhoan();
                taiKhoan.TenDangNhap = row["tenDangNhap"].ToString();
                taiKhoan.MatKhau = row["matKhau"].ToString();
                taiKhoan.VaiTro = new VaiTro();
                taiKhoan.VaiTro.Id = int.Parse(row["vaitro_id"].ToString());
                taiKhoan.VaiTro.Ten = vtBUS.GiaTriTruong("ten", " id = " + row["vaitro_id"].ToString()).ToString();
                ds.Add(taiKhoan);
            }
            return ds;
        }
        public DataTable LayToanBoDS()
        {
            throw new NotImplementedException();
        }
        public int SoLuong(string dieuKien)
        {
            return db.GetCount("taikhoan", dieuKien);
        }
        public bool DoiMatKhau(string matKhau, string nhanvien_id)
        {
            new Msg(string.Format("UPDATE taikhoan " +
                "SET matKhau = N'{0}' " +
                "WHERE nhanvien_id = {1}",
                matKhau,
                nhanvien_id));
            db.ExecuteNonQuery(string.Format("UPDATE taikhoan " +
                "matKhau = N'{0}' " +
                "WHERE nhanvien_id = {1}",
                matKhau,
                nhanvien_id));
            return true;
        }
        public bool Sua(params string[] dsTruong)
        {
            string tenDangNhap = dsTruong[0];
            string matKhau = dsTruong[1];
            string nhanvien_id = dsTruong[2];
            string vaitro_id = dsTruong[3];

            db.ExecuteNonQuery(string.Format("UPDATE taikhoan " +
                "SET tenDangNhap = N'{0}', " +
                "matKhau = N'{1}', " +
                "vaitro_id = {3} " +
                "WHERE nhanvien_id = {2}",
                tenDangNhap,
                matKhau,
                nhanvien_id,
                vaitro_id));

            return true;
        }
        public bool Them(params string[] dsTruong)
        {
            string tenDangNhap = dsTruong[0];
            string matKhau = dsTruong[1];
            string nhanvien_id = dsTruong[2];
            string vaitro_id = dsTruong[3];

            db.ExecuteNonQuery(string.Format("INSERT INTO taikhoan (tenDangNhap, matKhau, " +
                "nhanvien_id, vaitro_id, trangthai) " +
                "VALUES (N'{0}', N'{1}', {2}, {3}, 1)",
                tenDangNhap,
                matKhau,
                nhanvien_id,
                vaitro_id));

            return true;
        }
        public bool Validate(params string[] dsTruong)
        {
            string tenDangNhap = dsTruong[0];
            string matKhau = dsTruong[1];
            string nhanvien_id = dsTruong[2];
            string vaitro_id = dsTruong[3];

            //kiem tra cac truong thong tin co rong hay khong
            if (tenDangNhap.Equals("") || matKhau.Equals(""))
            {
                new Msg("Vui lòng nhập đầy đủ thông tin!", "err");
                return false;
            }

            if (nhanvien_id == "-1")
            {
                if (db.GetCount("taikhoan", "tenDangNhap = N'" + tenDangNhap + "'") > 0)
                {
                    new Msg("Tên đăng nhập đã tồn tại!", "err");
                    return false;
                }
            } else
            {
                string tenDangNhapCu = db.GetColumn("taikhoan", "tenDangNhap", "nhanvien_id = " + nhanvien_id).ToString();
                if (tenDangNhapCu != tenDangNhap)
                { // Đổi tên đăng nhập
                    if (db.GetCount("taikhoan", "tenDangNhap = N'" + tenDangNhap + "'") > 0)
                    {
                        new Msg("Tên đăng nhập đã tồn tại!", "err");
                        return false;
                    }
                }
            }
            return true;
        }
        public bool Xoa(string tieuChi)
        {
            db.ExecuteNonQuery(string.Format("UPDATE taikhoan " +
                "SET trangthai = 0 " + "WHERE {0}", tieuChi));

            return true;
        }

        public bool Khoa(string nhanvien_id)
        {
            db.ExecuteNonQuery(string.Format("UPDATE taikhoan " +
                "SET trangthai = 0 " + "WHERE nhanvien_id = {0}", nhanvien_id));

            return true;
        }
        public bool MoKhoa(string nhanvien_id)
        {
            db.ExecuteNonQuery(string.Format("UPDATE taikhoan " +
                "SET trangthai = 1 " + "WHERE nhanvien_id = {0}", nhanvien_id));

            return true;
        }

        public List<string> dsQuyen(string username)
        {
            string vaitro_id = db.GetColumn("taikhoan", "vaitro_id", "tenDangNhap = N'" + username + "'").ToString();
            VaiTroBUS vtBUS = new VaiTroBUS();
            VaiTro vt = vtBUS.layVaiTro(vaitro_id);
            return vt.DsQuyen;
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
