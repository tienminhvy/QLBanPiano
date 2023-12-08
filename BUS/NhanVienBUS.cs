using QLBanPiano.DAL;
using QLBanPiano.DTO;
using QLBanPiano.GUI;
using QLBanPiano.GUI.SubForm;
using System.Data;

namespace QLBanPiano.BUS
{
    public class NhanVienBUS : IBUS
    {
        DB db;
        private PianoBUS pianoBus = new();
        public NhanVienBUS()
        {
            db = new DB();
        }
        public object GiaTriTruong(string tenTruong, string dieuKien)
        {
            return db.GetColumn("nhanvien", tenTruong, dieuKien);
        }

        public List<DoiTuong> LayDS(string dieukien)
        {
            string sqlStr = "SELECT " +
                "id as N'Mã nhân viên', " +
                "hoLot as N'Họ lót', " +
                "ten as N'Tên', " +
                "ngayVaoLam as N'Ngày vào làm', " +
                "sdt as N'Số điện thoại', " +
                "diaChi as N'Địa chỉ' " +
                "FROM nhanvien " +
                "WHERE trangthai = 1 AND " + dieukien;

            DataTable dt = db.Execute(sqlStr);
            List<DoiTuong> ds = new List<DoiTuong>();

            foreach (DataRow row in dt.Rows) {

                NhanVien nhanvien = new NhanVien();
                nhanvien.Id = Convert.ToInt32(row["Mã nhân viên"]);
                nhanvien.HoLot = row["Họ lót"].ToString();
                nhanvien.Ten = row["Tên"].ToString();
                nhanvien.NgayVaoLam = Convert.ToDateTime(row["Ngày vào làm"].ToString());
                nhanvien.SoDienThoai = row["Số điện thoại"].ToString();
                nhanvien.DiaChi = row["Địa chỉ"].ToString();
                ds.Add(nhanvien);

            }
            return ds;

        }

        public DataTable LayToanBoDS()
        {
            string sqlStr = "SELECT " +
                "id as N'Mã nhân viên', " +
                "hoLot as N'Họ lót', " +
                "ten as N'Tên', " +
                "ngayVaoLam as N'Ngày vào làm', " +
                "sdt as N'Số điện thoại', " +
                "diaChi as N'Địa chỉ' " +
                "FROM nhanvien WHERE trangthai = 1";
            
            return db.Execute(sqlStr);
        }

        public int SoLuong(string dieuKien)
        {
            return db.GetCount("nhanvien", dieuKien);
        }
        public bool checkExist(int id)
        {
            return pianoBus.checkExist("nhanvien", id);
        }
        public bool Validate(frmQLNhanVien f, params string[] dsTruong)
        {
            string hoLot = dsTruong[0];
            string ten = dsTruong[1];
            DateTime ngayVaoLam = DateTime.Parse(dsTruong[2]);
            string sdt = dsTruong[3];
            string diaChi = dsTruong[4];
            string id = dsTruong[5];

            //kiem tra cac truong thong tin co rong hay khong
            if (hoLot.Equals("") || ten.Equals("") ||
                ngayVaoLam == DateTime.MinValue || sdt.Equals("") || diaChi.Equals(""))
            {
                new Msg("Vui lòng nhập đầy đủ thông tin!", "err");
                return false;
            }

            foreach (char kyTu in hoLot)
            {
                if (char.IsDigit(kyTu))
                {
                    new Msg("Họ lót chỉ được chứa kí tự chữ!", "err");
                    f.txtHoLot.Focus();
                    return false;
                }
            }
            foreach (char kyTu in ten)
            {
                if (char.IsDigit(kyTu))
                {
                    new Msg("Tên chỉ được chứa kí tự chữ!", "err");
                    f.txtTen.Focus();
                    return false;
                }
            }
            foreach (char kyTu in sdt)
            {
                if (!Char.IsDigit(kyTu))
                {
                    f.txtSDT.Focus();
                    new Msg("Số điện thoại chỉ được chứa kí tự số!", "err");
                    return false;

                }
            }

            //kiem tra sdt cua nhan vien co du 10 so hay khong
            if (sdt.Length != 10)
            {

                new Msg("Số điện thoại phải có 10 chữ số!", "err");
                return false;
            }

            //kiem tra co bi trung so dien thoai khong
            if (id == "-1" && db.GetCount("nhanvien", "sdt = N'" + sdt + "' AND trangthai = 1") > 0)
            {
                new Msg("Số điện thoại đã tồn tại", "err");
                return false;
            }

            return true;
        }

        public bool Sua(params string[] dsTruong)
        {
            
            string hoLot = dsTruong[0];
            string ten = dsTruong[1];
            DateTime ngayVaoLam = DateTime.Parse(dsTruong[2]);
            string sdt = dsTruong[3];
            string diaChi = dsTruong[4];
            string id = dsTruong[5];

            db.ExecuteNonQuery(string.Format("UPDATE nhanvien " +
                                " SET hoLot = N'{0}', " +
                                "ten = N'{1}', " +
                                "ngayVaoLam = '{2}', " +
                                "sdt = '{3}', " +
                                "diaChi = N'{4}' " +
                                "WHERE id = '{5}'",
                                hoLot,
                                ten,
                                Convert.ToDateTime(ngayVaoLam),
                                sdt,
                                diaChi, id));
            return true;

        }

        public bool Them(params string[] dsTruong)
        {
            string hoLot = dsTruong[0];
            string ten = dsTruong[1];
            DateTime ngayVaoLam = DateTime.Parse(dsTruong[2]);
            string sdt = dsTruong[3];
            string diaChi = dsTruong[4];
            
            db.Insert(string.Format("INSERT INTO nhanvien (hoLot, ten, ngayVaoLam, " +
                "sdt, diaChi, trangthai) " + 
                "OUTPUT INSERTED.ID " +
                "VALUES (N'{0}', N'{1}', '{2}','{3}', N'{4}',1)",
                    hoLot,
                    ten,
                    Convert.ToDateTime(ngayVaoLam),
                    sdt,
                    diaChi));

            return true;

        }

        public bool Xoa(string tieuChi)
        {
            db.ExecuteNonQuery(string.Format("UPDATE nhanvien" +
                " SET trangthai = 0 " + "WHERE {0}", tieuChi));
            (new TaiKhoanBUS()).Xoa(tieuChi);
            return true;
        }

        public List<DoiTuong> TimKiem(string tieuChi, string giaTri)
        {
            string dieuKien = "";
            switch (tieuChi)
            {
                case "ID":
                    {
                        dieuKien = "CAST(id AS VARCHAR) LIKE '%" + giaTri + "%'";
                        break;
                    }
                case "Họ lót":
                    {
                        dieuKien = "Upper(hoLot) LIKE N'%" + giaTri.ToUpper() + "%'";
                        break;
                    }
                case "Tên":
                    {
                        dieuKien = "Upper(ten) LIKE N'%" + giaTri.ToUpper() + "%'";
                        break;
                    }
                case "SDT":
                    {
                        dieuKien = "sdt LIKE N'%" + giaTri + "%'";
                        break;
                    }
                case "Địa chỉ":
                    {
                        dieuKien = "Upper(diaChi) LIKE N'%" + giaTri.ToUpper() + "%'";
                        break;
                    }
                case "Ngày vào làm":
                    {
                        string[] ngay = giaTri.Split(",");
                        dieuKien = string.Format("ngayvaolam BETWEEN '{0}' AND '{1}'", ngay[0], ngay[1]);
                        break;
                    }
            }
            if (dieuKien == string.Empty)
                dieuKien = "1=1";
            return LayDS(dieuKien);
        }

        public bool Validate(params string[] dsTruong)
        {
            throw new NotImplementedException();
        }
    }
}
