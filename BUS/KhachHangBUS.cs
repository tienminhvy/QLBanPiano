using QLBanPiano.DAL;
using QLBanPiano.DTO;
using QLBanPiano.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;

namespace QLBanPiano.BUS
{
    public class KhachHangBUS : IBUS
    {
        DB db;
        public KhachHangBUS()
        {
            db = new DB();
        }

        public object GiaTriTruong(string tenTruong, string dieuKien)
        {
            return db.GetColumn("khachhang", tenTruong, dieuKien);
        }

        public List<DoiTuong> LayDS(string dieukien)
        {
            string sqlStr = "SELECT " +
                "khachhang.id as N'Mã khách hàng ', " +
                "khachhang.hoLot as N'Họ lót', " +
                "khachhang.ten as N'Tên', " +
                "khachhang.diaChi as N'Địa chỉ', " +
                "khachhang.sdt as N'Số điện thoại', " +
                "FROM khachhang" + dieukien;
            DataTable dt = db.Execute(sqlStr);
            List<DoiTuong> ds = new List<DoiTuong>();

            foreach (DataRow row in dt.Rows)
            {
                DTO.KhachHang khachhang = new DTO.KhachHang();
                khachhang.Id = int.Parse(row["Mã khách hàng"].ToString());
                khachhang.HoLot = row["Họ lót"].ToString();
                khachhang.Ten = row["Tên"].ToString();
                khachhang.DiaChi = row["Địa chỉ"].ToString();
                khachhang.SoDienThoai = row["Số điện thoại"].ToString();
                //
                ds.Add((DoiTuong)khachhang);
            }
            return ds;
        }
        public DataTable LayToanBoDS()
        {
            string sqlStr = "SELECT " +
                "khachhang.id as N'Mã khách hàng ', " +
                "khachhang.hoLot as N'Họ lót', " +
                "khachhang.ten as N'Tên', " +
                "khachhang.diaChi as N'Địa chỉ', " +
                "khachhang.sdt as N'Số điện thoại', " +
                "FROM khachhang";

            return db.Execute(sqlStr);
        }
        public int SoLuong(string dieuKien)
        {
            return db.GetCount("khachhang", dieuKien);
        }
        public bool Sua(params string[] dsTruong)
        {
            string id = dsTruong[0];
            string hoLot = dsTruong[1];
            string ten = dsTruong[2];
            string diaChi = dsTruong[3];
            string soDienThoai = dsTruong[4];


            string idKhachHang = db.GetColumn("khachhang", "id", "Mã khách hàng  = " + id).ToString();
            string hoLotKhachHang = db.GetColumn("khachhang", "hoLot", "Họ lót = " + hoLot).ToString();
            string tenKhachHang = db.GetColumn("khachhang", "ten", "Tên = " + ten).ToString();
            string diaChiKhachHang = db.GetColumn("khachhang", "diaChi", "Địa chủ = " + diaChi).ToString();
            string soDienThoaiKhachHang = db.GetColumn("khachhang", "soDienThoai", "Số điện thoại = " + soDienThoai).ToString();

            //không được để trống các trường thông tin
            if (idKhachHang.Equals("") || hoLotKhachHang.Equals("") || tenKhachHang.Equals("") || diaChiKhachHang.Equals("") || soDienThoaiKhachHang.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }

            //kiểm tra id của khách hàng đã tồn tại hay chưa
            if (db.GetCount("khachhang", "Mã khách hàng = N'" + id + "' AND trang thai = 1") == 0)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại");
            }

            //Kiểm tra số điện thoại phải là 10 chữ sỗ
            if (soDienThoaiKhachHang.Length != 0)
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số!");
                return false;
            }

            //Kiểm tra số điện thoại đã tồn tại hay chưa
            if (db.GetCount("khachhang", "soDienThoai = N'" + soDienThoai + "' AND trang thai = 1") > 0)
            {
                MessageBox.Show("Số điện thoại đã tồn tại");
                return false;
            }

            db.ExecuteNonQuery(string.Format("UPDATE khachhang " +
                            "SET hoLot = '{0}', " +
                            "ten = N'{1}', " +
                            "diaChi = N'{2}', " +
                            "soDienThoai = N'{3}', " +
                            "WHERE id = {4}",
                            hoLot,
                            ten,
                            diaChi,
                            soDienThoai,
                            id));
            return true;
        }

        public  bool Them(params string[] dsTruong)
        {
            string id = dsTruong[0];
            string hoLot = dsTruong[1];
            string ten = dsTruong[2];
            string diaChi = dsTruong[3];
            string soDienThoai = dsTruong[4];

            string idKhachHang = db.GetColumn("khachhang", "id", "Mã khách hàng  = " + id).ToString();
            string hoLotKhachHang = db.GetColumn("khachhang", "hoLot", "Họ lót = " + hoLot).ToString();
            string tenKhachHang = db.GetColumn("khachhang", "ten", "Tên = " + ten).ToString();
            string diaChiKhachHang = db.GetColumn("khachhang", "diaChi", "Địa chủ = " + diaChi).ToString();
            string soDienThoaiKhachHang = db.GetColumn("khachhang", "soDienThoai", "Số điện thoại = " + soDienThoai).ToString();

            //không để trống các trường thông tin     
            if (idKhachHang.Equals("") || hoLotKhachHang.Equals("") || tenKhachHang.Equals("") || diaChiKhachHang.Equals("") || soDienThoaiKhachHang.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }
            //kiểm tra id của khách hàng đã tồn tại hay chưa
            if (db.GetCount("khachhang", "Mã khách hàng = N'" + id + "' AND trang thai = 1") > 0)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại");
                return false;
            }
            //Kiểm tra số điện thoại phải là 10 chữ sỗ
            if (soDienThoai.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số");
                return false;
            }
            //Kiểm tra số điện thoại đã tồn tại hay chưa
            if (db.GetCount("khachhang", "soDienThoai = N'" + soDienThoai + "' AND trang thai = 1") > 0)
            {
                MessageBox.Show("Số điện thoại đã tồn tại");
                return false;
            }

            // Thực hiện câu truy vấn để thêm mới khách hàng
            db.ExecuteNonQuery(string.Format("INSERT INTO khachhang (id, hoLot, ten, diaChi, soDienThoai, trang thai) " +
                            "VALUES ('{0}', '{1}', N'{2}', N'{3}', N'{4}', 1)",
                            id,
                            hoLot,
                            ten,
                            diaChi,
                            soDienThoai));

            return true;
        }

        public bool Xoa(string tieuChi)
        {
            db.ExecuteNonQuery(string.Format("UPDATE khachhang" +
                "SET trangthai = 0 " +
                "WHERE {1}", tieuChi));
            return true;
        }
    }
}