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
    public class ThuongHieuBUS : IBUS
    {
        DB db;
        public ThuongHieuBUS()
        {
            db = new DB();
        }
        public object GiaTriTruong(string tenTruong, string dieuKien)
        {
            return db.GetColumn("thuonghieu", tenTruong, dieuKien);
        }

        public List<DoiTuong> LayDS(string dieukien)
        {
            throw new NotImplementedException();
        }

        public DataTable LayToanBoDS()
        {
            string sqlStr = "SELECT " +
                "ma as N'Mã thương hiệu', " +
                "ten as N'Tên thương hiệu', " +
                "moTa as N'Mô tả thương hiệu' " +
                "FROM thuonghieu WHERE trangthai = 1";

            return db.Execute(sqlStr);
        }

        public List<String> LayDSTenThuongHieu()
        {
            List<String> list = new List<String>();
            string sqlStr = "SELECT ten as N'Tên Thương Hiệu'\r\nFROM thuonghieu";

            DataTable dt = db.Execute(sqlStr);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr["Tên Thương Hiệu"].ToString());
            }
            return list;
        }
        public int SoLuong(string dieuKien)
        {
            return db.GetCount("thuonghieu", dieuKien);
        }

        public bool Sua(params string[] dsTruong)
        {
            string id = dsTruong[0];
            string ma = dsTruong[1];
            string ten = dsTruong[2];
            string moTa = dsTruong[3];

            string idThuongHieu = db.GetColumn("thuonghieu", "id", "id = " + id).ToString(); // kiểm tra id của thương hiệu có tồn tại không
            if (idThuongHieu == "-1")
            {
                MessageBox.Show("Không tìm thấy mã thương hiệu");
                return false; //id Nhạc Cụ Không Tồn Tại
            }

            string trangThaiCuaMa = db.GetColumn("nhaccu", "trangthai", "ma = " + ma + "and id !=" + id).ToString(); //Lấy trạng thái của mã thương hiệu điền vào, nếu chưa tồn tại thì kq = null, nếu có tồn tại thì là True/false
            if (trangThaiCuaMa == "1") // cần kiểm tra xem có mã thuonghieu nào trùng với nhạc cụ đang sửa và có id khác nhaccu đang sửa
            {
                MessageBox.Show("Mã thương hiệu đã tồn tại");
                return false; // mã đã tồn tại và thương hiệu đó chưa bị xóa
            }

            db.ExecuteNonQuery(string.Format("UPDATE thuonghieu " +
                "SET ma = N'{0}', ten = N'{1}', moTa = N'{2}' " +
                "WHERE id = {3}", ma, ten, moTa, id));
            return true;
        }

        public bool Them(params string[] dsTruong)
        {
            string ma = dsTruong[0];
            string ten = dsTruong[1];
            string moTa = dsTruong[2];

            if (db.GetCount("thuonghieu", "ma = '" + ma + "' AND trangthai = 1") > 0)
            {
                MessageBox.Show("Mã thương hiệu đã tồn tại");
                return false;
            }

            string thuonghieu_id = db.Insert(string.Format("INSERT INTO thuonghieu " +
                "(ma, ten, moTa, trangthai) " +
                "VALUES (N'{0}', N'{1}', N'{2}', 1);", ma, ten, moTa)).ToString();
            return true;
        }

        public bool Xoa(string tieuChi)
        {
            db.ExecuteNonQuery(string.Format("UPDATE thuonghieu " +
                "SET trangthai = 0 " +
                "WHERE {1}", tieuChi));
            return true;
        }

        public bool Validate(params string[] dsTruong)
        {
            throw new NotImplementedException();
        }
    }
}
