using QLBanPiano.DAL;
using QLBanPiano.DTO;
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
            string sqlStr = "SELECT" +
                "id as N'Mã nhân viên', " +
                "hoLot as N'Họ lót', " +
                "ten as N'Tên', " +
                "ngayVaoLam as N'Ngày vào làm', " +
                "sdt as N'Số điện thoại', " +
                "diaChi as N'Địa chỉ', " +
                "FROM nhanvien " +
                "WHERE " + dieukien;

            DataTable dt = db.Execute(sqlStr);
            List<DoiTuong> ds = new List<DoiTuong>();

            foreach (DataRow row in dt.Rows)
            {

                if (int.Parse(row["trangthai"].ToString()) == 0)
                    continue;

                NhanVien nhanvien = new NhanVien();
                nhanvien.Id = int.Parse(row["id"].ToString());
                nhanvien.HoLot = row["hoLot"].ToString();
                nhanvien.Ten = row["ten"].ToString();
                nhanvien.NgayVaoLam = DateTime.Parse(row["ngayVaoLam"].ToString());
                nhanvien.SoDienThoai = row["sdt"].ToString();
                nhanvien.DiaChi = row["diaChi"].ToString();
                ds.Add(nhanvien);

            }
            return ds;

        }

        public DataTable LayToanBoDS()
        {
            string sqlStr = "SELECT" +
                "id as N'Mã nhân viên', " +
                "hoLot as N'Họ lót', " +
                "ten as N'Tên', " +
                "ngayVaoLam as N'Ngày vào làm', " +
                "sdt as N'Số điện thoại', " +
                "diaChi as N'Địa chỉ', " +
                "FROM nhanvien";

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
        public bool Validate(params string[] dsTruong)
        {
            string id = dsTruong[0];
            string hoLot = dsTruong[1];
            string ten = dsTruong[2];
            DateTime ngayVaoLam = DateTime.Parse(dsTruong[3]);
            string sdt = dsTruong[4];
            string diaChi = dsTruong[5];

            //kiem tra cac truong thong tin co rong hay khong
            if (hoLot.Equals("") || ten.Equals("") ||
                ngayVaoLam == DateTime.MinValue || sdt.Equals("") || diaChi.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            //kiem tra id nhan vien da ton tai hay chua
            if (db.GetCount("nhanvien", "id = '" + id + "' AND trangthai=1") == 0)
                MessageBox.Show("Mã nhân viên đã tồn tại");

            //kiem tra sdt cua nhan vien co du 10 so hay khong
            if (sdt.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số!");
                return false;
            }

            //kiem tra co bi trung so dien thoai khong
            if (db.GetCount("nhanvien", "sdt = N'" + sdt + "' AND trangthai = 1") > 0)
            {
                MessageBox.Show("Số điện thoại đã tồn tại");
                return false;
            }

            return true;
        }
        public bool Sua(params string[] dsTruong)
        {
            string id = dsTruong[0];
            string hoLot = dsTruong[1];
            string ten = dsTruong[2];
            DateTime ngayVaoLam = DateTime.Parse(dsTruong[3]);
            string sdt = dsTruong[4];
            string diaChi = dsTruong[5];

            db.ExecuteNonQuery(string.Format("UPDATE nhanvien " +
                                " SET hoLot = N'{0}', " +
                                "ten = N'{1}', " +
                                "ngayVaoLam = '{2}', " +
                                "sdt = '{3}', " +
                                "diaChi = N'{4}', " +
                                "WHERE id = '{5}'",
                                hoLot,
                                ten,
                                ngayVaoLam,
                                sdt,
                                diaChi, id));
            return true;

        }

        public bool Them(params string[] dsTruong)
        {
            string hoLot = dsTruong[0];
            string ten = dsTruong[1];
            string ngayVaoLam = dsTruong[3];
            string sdt = dsTruong[4];
            string diaChi = dsTruong[5];

            db.ExecuteNonQuery(string.Format("INSERT INTO nhanvien (hoLot, ten, ngayVaoLam, " +
                "sdt, diaChi, trangthai) " +
                "VALUES (N'{1}', N'{2}', '{3}','{4}', N'{5}',1)",
                    hoLot,
                    ten,
                    ngayVaoLam,
                    sdt,
                    diaChi));

            return true;

        }

        public bool Xoa(string tieuChi)
        {
            db.ExecuteNonQuery(string.Format("UPDATE nhanvien" +
                "SET trangthai = 0" + "WHERE {1}", tieuChi));
            return true;
        }
    }
}