using QLBanPiano.DAL;
using QLBanPiano.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.BUS
{
    public class PianoBUS : IBUS
    {
        DB db;
        public PianoBUS() {
            db = new DB();
        }
        /**
         * <summary>Lấy giá trị của một cột với điều kiện</summary>
         * <param name="tenTruong">Tên cột cần lấy giá trị</param>
         * <param name="dieuKien">Điều kiện để lấy giá trị</param>
         * <returns>object (đối tượng đầu tiên tìm thấy)</returns>
         */
        public object GiaTriTruong(string tenTruong, string dieuKien)
        {
            return db.GetColumn("piano", tenTruong, dieuKien);
        }
        /**
         * <summary>Lấy toàn bộ danh sách piano</summary>
         * <param name="dieukien">Điều kiện truyền vào (ví dụ 1 = 1 để thực hiện câu lệnh này mặc định)</param>
         * <returns>List<DoiTuong></returns>
         */
        public List<DoiTuong> LayDS(string dieukien)
        {
            string sqlStr = "SELECT " +
                "piano.id as 'id', " +
                "nhaccu.ma as N'Mã nhạc cụ', " +
                "nhaccu.ten as N'Tên', " +
                "dacDiemNoiBat as N'Đặc điểm nổi bật', " +
                "moTaChiTiet as N'Mô tả chi tiết', " +
                "gia as N'Giá', " +
                "soLuong as N'Số lượng', " +
                "phanLoai as N'Phân loại', " +
                "thuonghieu.ma, " +
                "thuonghieu.ten, " +
                "nhaccu.thuonghieu_id " +
                "FROM piano, nhaccu, thuonghieu" +
                "WHERE piano.nhaccu_id = nhaccu.id AND " +
                "nhaccu.thuonghieu_id = thuonghieu.id AND " + dieukien;

            DataTable dt = db.Execute(sqlStr);
            List<DoiTuong> ds = new List<DoiTuong>();

            foreach (DataRow row in dt.Rows)
            {
                DTO.Piano piano = new DTO.Piano();
                piano.Id = int.Parse(row["id"].ToString());
                piano.Ma = row["Mã nhạc cụ"].ToString();
                piano.Ten = row["Tên"].ToString();
                piano.DacDiemNoiBat = row["Đặc điểm nổi bật"].ToString();
                piano.MoTaChiTiet = row["Mô tả chi tiết"].ToString();
                piano.Gia = long.Parse(row["Giá"].ToString());
                piano.SoLuong = int.Parse(row["Số lượng"].ToString());
                piano.Phanloai = row["Phân loại"].ToString();
                piano.ThuongHieu = new ThuongHieu();
                piano.ThuongHieu.Ma = row["thuonghieu.ma"].ToString();
                piano.ThuongHieu.Ten = row["thuonghieu.ten"].ToString();
                ds.Add(piano);
            }
            return ds;
        }
        /**
         * <summary>Lấy toàn bộ danh sách piano</summary>
         * <returns>DataTable</returns>
         */
        public DataTable LayToanBoDS()
        {
            string sqlStr = "SELECT " +
                "nhaccu.ma as N'Mã nhạc cụ', " +
                "nhaccu.ten as N'Tên', " +
                "dacDiemNoiBat as N'Đặc điểm nổi bật', " +
                "moTaChiTiet as N'Mô tả chi tiết', " +
                "gia as N'Giá', " +
                "soLuong as N'Số lượng', " +
                "FROM piano, nhaccu, thuonghieu" +
                "WHERE piano.nhaccu_id = nhaccu.id AND " +
                "nhaccu.thuonghieu_id = thuonghieu.id AND trangthai = 1";

            return db.Execute(sqlStr);
        }

        public int SoLuong(string dieuKien)
        {
            return db.GetCount("piano", dieuKien);
        }
        /**
         * <summary>Sửa thông tin</summary>
         * <param name="dsTruong">gồm ma, ten, dacDiemNoiBat, moTaChiTiet, gia, hinhAnh, phanLoai, idThuongHieu, idNhacCu cần sửa theo thứ tự</param>
         * <returns>true/false</returns>
         */
        public bool Sua(params string[] dsTruong)
        {
            string ma = dsTruong[0];
            string ten = dsTruong[1];
            string dacDiemNoiBat = dsTruong[2];
            string moTaChiTiet = dsTruong[3];
            string gia = dsTruong[4];
            string hinhAnh = dsTruong[5];
            string phanLoai = dsTruong[6];
            string idThuongHieu = dsTruong[7];
            string idNhacCu = dsTruong[8];

            db.ExecuteNonQuery(string.Format("UPDATE piano " +
                "SET phanLoai = N'{0}' " +
                "WHERE nhaccu_id = {1}", phanLoai, idNhacCu));

            db.ExecuteNonQuery(string.Format("UPDATE nhaccu " +
                            "SET ma = '{0}', " +
                            "ten = N'{1}', " +
                            "dacDiemNoiBat = N'{2}', " +
                            "moTaChiTiet = N'{3}', " +
                            "gia = {4}, " +
                            "hinhAnh = {5}, " +
                            "thuonghieu_id = {6}" +
                            "WHERE id = {7}",
                            ma,
                            ten,
                            dacDiemNoiBat,
                            moTaChiTiet,
                            gia,
                            hinhAnh,
                            idThuongHieu,
                            idNhacCu));
            return true;
        }
        /**
         * <summary>Thêm thông tin</summary>
         * <param name="dsTruong">gồm ma, ten, dacDiemNoiBat, moTaChiTiet, gia, hinhAnh, phanLoai, idThuongHieu cần sửa theo thứ tự</param>
         * <returns>true/false</returns>
         */
        public bool Them(params string[] dsTruong)
        {
            string ma = dsTruong[0];
            string ten = dsTruong[1];
            string dacDiemNoiBat = dsTruong[2];
            string moTaChiTiet = dsTruong[3];
            string gia = dsTruong[4];
            string hinhAnh = dsTruong[5];
            string phanLoai = dsTruong[6];
            string idThuongHieu = dsTruong[7];

            if (db.GetCount("nhaccu", "ma = '" + ma + "' AND trangthai = 1") == 0)
            {
                MessageBox.Show("Mã nhạc cụ đã tồn tại");
                return false;
            }

            string nhaccu_id = db.Insert(string.Format("INSERT INTO nhaccu " +
                "(ma, ten, dacDiemNoiBat, moTaChiTiet, gia," +
                " hinhAnh, soLuong, thuonghieu_id, trangthai) " +
                "VALUES ('{0}', N'{1}', N'{2}', N'{3}', {4}, {5}, 0, {6}, {7})",
                ma, ten, dacDiemNoiBat, moTaChiTiet, gia, hinhAnh, idThuongHieu, 1)).ToString();

            if(nhaccu_id == "-1") { return false; } // thêm nhạc cụ thất bại

            db.Insert(string.Format("INSERT INTO piano (phanLoai, nhaccu_id) " +
                "VALUES ({0}, {1})", phanLoai, nhaccu_id));
            return true;
        }
        /**
         * <summary>Xác minh thông tin</summary>
         * <param name="dsTruong">gồm ma, ten, dacDiemNoiBat, moTaChiTiet, gia, hinhAnh, phanLoai, idThuongHieu</param>
         * <returns>true/false</returns>
         */
        public bool Validate(params string[] dsTruong)
        {
            throw new NotImplementedException();
        }
        /**
         * <summary>Xoá (soft delete)</summary>
         * <param name="tieuChi">Điều kiện xoá (ví dụ id = 0)</param>
         * <returns>true/false</returns>
         */
        public bool Xoa(string tieuChi)
        {
            db.ExecuteNonQuery(string.Format("UPDATE nhaccu " +
                "SET trangthai = 0 " +
                "WHERE {1}", tieuChi));
            return true;
        }
    }
}
