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
        public PianoBUS()
        {
            db = new DB();
        }

        public object GiaTriTruong(string tenTruong, string dieuKien)
        {
            return db.GetColumn("piano", tenTruong, dieuKien);
        }

        public List<DoiTuong> LayDS(string dieukien)
        {
            string sqlStr = "SELECT  piano.id as 'id',  \r\nnhaccu.ma as N'Mã nhạc cụ',  \r\nnhaccu.ten as N'Tên',  \r\ndacDiemNoiBat as N'Đặc điểm nổi bật',  \r\nmoTaChiTiet as N'Mô tả chi tiết',  \r\ngia as N'Giá',  \r\nsoLuong as N'Số lượng',  \r\nphanLoai as N'Phân loại',  \r\nthuonghieu.ma as N'Mã Thương Hiệu',  \r\nthuonghieu.ten as N'Tên Thương Hiệu',  \r\nnhaccu.thuonghieu_id  \r\nFROM piano, nhaccu, thuonghieu \r\nWHERE piano.nhaccu_id = nhaccu.id AND  \r\nnhaccu.thuonghieu_id = thuonghieu.id AND " + dieukien;
            DataTable dt = db.Execute(sqlStr);
            List<DoiTuong> ds = new List<DoiTuong>();

            foreach (DataRow row in dt.Rows)
            {
                Piano piano = new Piano();
                piano.Id = int.Parse(row["id"].ToString());
                piano.Ma = row["Mã nhạc cụ"].ToString();
                piano.Ten = row["Tên"].ToString();
                piano.DacDiemNoiBat = row["Đặc điểm nổi bật"].ToString();
                piano.MoTaChiTiet = row["Mô tả chi tiết"].ToString();
                piano.Gia = long.Parse(row["Giá"].ToString());
                piano.SoLuong = int.Parse(row["Số lượng"].ToString());
                piano.Phanloai = row["Phân loại"].ToString();
                piano.ThuongHieu = new ThuongHieu();
                piano.ThuongHieu.Ma = row["Mã Thương Hiệu"].ToString();
                piano.ThuongHieu.Ten = row["Tên Thương Hiệu"].ToString();
                ds.Add(piano);
            }
            return ds;
        }

        public DataTable LayToanBoDS()
        {

            string sqlStr = "SELECT \r\nnhaccu.ma as N'Mã nhạc cụ', \r\nnhaccu.ten as N'Tên', \r\ndacDiemNoiBat as N'Đặc điểm nổi bật', \r\nmoTaChiTiet as N'Mô tả chi tiết', \r\ngia as N'Giá', \r\nsoLuong as N'Số lượng' \r\nFROM piano, nhaccu, thuonghieu\r\nWHERE piano.nhaccu_id = nhaccu.id AND \r\nnhaccu.thuonghieu_id = thuonghieu.id and nhaccu.trangthai = 1";
                return db.Execute(sqlStr);
        }

        public int SoLuong(string dieuKien)
        {
            return db.GetCount("piano", dieuKien);
        }

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
            string idPiano = dsTruong[8];

            string idNhacCu = db.GetColumn("piano", "nhaccu_id", "id = " + idPiano).ToString();
            if (idNhacCu == "-1") return false;
            db.ExecuteNonQuery(string.Format("UPDATE piano " +
                "SET phanLoai = N'{0}' " +
                "WHERE id = {1}", phanLoai, idPiano));

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

        public bool Xoa(string tieuChi)
        {
            db.ExecuteNonQuery(string.Format("UPDATE nhaccu " +
                "SET trangthai = 0 " +
                "WHERE {1}", tieuChi));
            return true;
        }
    }
}