using Org.BouncyCastle.Asn1.Mozilla;
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
    public class NhacCuBUS : IBUS
    {
        DB db;
        PianoBUS pianoBUS = new();
        public NhacCuBUS()
        {
            db = new DB();
        }
        public List<int> getListId()
        {
            List<int> list = new();
            string sqlCmd = "select id \r\nfrom nhaccu\r\nwhere trangthai = 1";
            DataTable dt = db.Execute(sqlCmd);
            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                list.Add(id);
            }
            return list;
        }
        public object GiaTriTruong(string tenTruong, string dieuKien)
        {
            return db.GetColumn("nhaccu", tenTruong, dieuKien);
        }
        public List<DoiTuong> LayDS(string dieukien) // nếu lấy toàn bộ thì dieukien = "1=1"
        {
            string sqlStr = "SELECT " +
                "nhaccu.id as 'id', " +
                "nhaccu.ma as N'Mã nhạc cụ', " +
                "nhaccu.ten as N'Tên', " +
                "dacDiemNoiBat as N'Đặc điểm nổi bật', " +
                "moTaChiTiet as N'Mô tả chi tiết', " +
                "gia as N'Giá', " +
                "hinhAnh as N'Hình Ảnh', " +
                "soLuong as N'Số lượng', " +
                "thuonghieu.ma as 'thuonghieu.ma', " +
                "thuonghieu.ten as 'thuonghieu.ten', " +
                "nhaccu.thuonghieu_id, " +
                "nhaccu.trangthai " +
                "FROM nhaccu, thuonghieu " +
                "WHERE nhaccu.thuonghieu_id = thuonghieu.id AND nhaccu.trangthai = 1 AND " + dieukien;
            DataTable dt = db.Execute(sqlStr);
            List<DoiTuong> ds = new List<DoiTuong>();

            foreach (DataRow row in dt.Rows)
            {
                NhacCu nhaccu = new NhacCu();
                nhaccu.Id = int.Parse(row["id"].ToString());
                nhaccu.Ma = row["Mã nhạc cụ"].ToString();
                nhaccu.Ten = row["Tên"].ToString();
                nhaccu.DacDiemNoiBat = row["Đặc điểm nổi bật"].ToString();
                nhaccu.MoTaChiTiet = row["Mô tả chi tiết"].ToString();
                nhaccu.Gia = int.Parse(row["Giá"].ToString());
                nhaccu.HinhAnh = row["Hình Ảnh"].ToString();
                nhaccu.SoLuong = int.Parse(row["Số Lượng"].ToString());
                nhaccu.ThuongHieu = new ThuongHieu();
                nhaccu.ThuongHieu.Ma = row["thuonghieu.ma"].ToString();
                nhaccu.ThuongHieu.Ten = row["thuonghieu.ten"].ToString();
                ds.Add(nhaccu);
                
            }

            return ds;
        }

        public DataTable LayToanBoDS()
        {
            string sqlStr = "SELECT " +
                "nhaccu.ma as N'Mã nhạc cụ', " +
                "nhaccu.ten as N'Tên', " +
                "dacDiemNoiBat as N'Đặc điểm nổi bật', " +
                "moTaChiTiet as N'Mô tả chi tiết', " +
                "hinhAnh as N'Hình Ảnh', " +
                "gia as N'Giá', " +
                "soLuong as N'Số lượng', " +
                "nhaccu.thuonghieu_id, " +
                "thuonghieu.ma, " +
                "thuonghieu.ten " +
                "FROM nhaccu, thuonghieu" +
                "WHERE nhaccu.thuonghieu_id = thuonghieu.id";

            return db.Execute(sqlStr);
        }

        public int SoLuong(string dieuKien)
        {
            return db.GetCount("nhaccu", dieuKien);
        }
        public long getPrice(int nhaccu_id)
        {
            string sqlCmd = "select gia as 'Price'\r\nfrom nhaccu\r\nwhere nhaccu.id = "+nhaccu_id;
            DataTable dt = db.Execute(sqlCmd);
            long value = Convert.ToInt64(dt.Rows[0]["Price"]);
            return value;
        }
        public bool Sua(params string[] dsTruong)
        {
            string id = dsTruong[0];
            string ma = dsTruong[1];
            string ten = dsTruong[2];
            string dacDiemNoiBat = dsTruong[3];
            string moTaChiTiet = dsTruong[4];
            string gia = dsTruong[5];
            string hinhAnh = dsTruong[6];
            string soLuong = dsTruong[7];
            string idThuongHieu = dsTruong[8];

            string idNhacCu = db.GetColumn("nhaccu", "id", "id = " + id).ToString(); // kiểm tra id của nhạc cụ có tồn tại không
            if (idNhacCu == "-1")
            {
                MessageBox.Show("Không tìm thấy mã nhạc cụ");
                return false; //id Nhạc Cụ Không Tồn Tại
            }

            
            string idThuongHieuCheck = db.GetColumn("thuonghieu", "id", "id = " + idThuongHieu + "AND trangthai = 1 ").ToString(); // lấy id thương hiệu để kiểm tra thương hiệu có tồn tại k
            if (idThuongHieuCheck == "-1")
            {
                MessageBox.Show("Không tìm thấy thương hiệu tương ứng");
                return false;// id thương hiệu không tồn tại
            }

            string trangThaiCuaMa  = db.GetColumn("nhaccu", "trangthai", "ma = " + ma + "and id !=" + id).ToString(); //Lấy trạng thái của mã nhạc cụ điền vào, nếu chưa tồn tại thì kq = null, nếu có tồn tại thì là True/false
            if (trangThaiCuaMa == "1") // cần kiểm tra xem có mã nhaccu nào trùng với nhạc cụ đang sửa và có id khác nhaccu đang sửa
            {
                MessageBox.Show("Mã nhạc cụ đã tồn tại");
                return false; // mã đã tồn tại và nhạc cụ đó chưa bị xóa
            }

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
                            id));
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
            string idThuongHieu = dsTruong[6];

            if (db.GetCount("nhaccu", "ma = '" + ma + "' AND trangthai = 1") == 0)
            {
                MessageBox.Show("Mã nhạc cụ đã tồn tại");
                return false;
            }
            if (db.GetCount("thuonghieu", "ma = '" + idThuongHieu+ "' AND trangthai = 1") == 0)
            {
                MessageBox.Show("Không tìm thấy thương hiệu tương ứng");
                return false;
            }
            string nhaccu_id = db.Insert(string.Format("INSERT INTO nhaccu " +
                "(ma, ten, dacDiemNoiBat, moTaChiTiet, gia," +
                " hinhAnh, soLuong, thuonghieu_id, trangthai) " +
                "VALUES ('{0}', N'{1}', N'{2}', N'{3}', {4}, {5}, 0, {6}, {7})",
                ma, ten, dacDiemNoiBat, moTaChiTiet, gia, hinhAnh, idThuongHieu, 1)).ToString();
            return true;
        }
        public bool checkExist(int id)
        {
            if (pianoBUS.checkExist("nhaccu", id) == false) return false;
            return true;
        }
        public bool Validate(params string[] dsTruong)
        {
            throw new NotImplementedException();
        }

        public bool Xoa(string tieuChi)
        {
            db.ExecuteNonQuery(string.Format("UPDATE nhaccu " +
                "SET trangthai = 0 " +
                "WHERE {1}", tieuChi));
            return true;
        }
        public void tangSL(int id,short SL)
        {
            string sqlCmd = "UPDATE nhaccu\r\nSet soLuong = soLuong + "+SL+" \r\nwhere id = "+id;
            db.ExecuteNonQuery(sqlCmd);
        }
        public void giamSL(int id,short SL)
        {
            NhacCuBUS nhacCuBUS = new NhacCuBUS();
            int soLuongHienTai = int.Parse(nhacCuBUS.GiaTriTruong("soLuong", "id = " + id).ToString());
            if (soLuongHienTai == 0)
            {
                return; // so luong da bang 0
            }
            string sqlCmd = "UPDATE nhaccu\r\nSet soLuong = soLuong - " + SL + " \r\nwhere id = " + id;
            db.ExecuteNonQuery(sqlCmd);
        }
    }
}
