using QLBanPiano.DAL;
using QLBanPiano.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
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
            string sqlStr = "SELECT  piano.id as 'id',  \r\nnhaccu.ma as N'Mã nhạc cụ',  \r\nnhaccu.ten as N'Tên',  \r\ndacDiemNoiBat as N'Đặc điểm nổi bật'," +
                "  \r\nmoTaChiTiet as N'Mô tả chi tiết',  \r\ngia as N'Giá', \r\nhinhAnh as N'Hình Ảnh',  \r\nsoLuong as N'Số lượng',  \r\nphanLoai as N'Phân loại', " +
                " \r\nthuonghieu.ma as N'Mã Thương Hiệu',  \r\nthuonghieu.ten as N'Tên Thương Hiệu',  \r\nnhaccu.thuonghieu_id  \r\nFROM piano, nhaccu, thuonghieu" +
                " \r\nWHERE piano.nhaccu_id = nhaccu.id AND  \r\nnhaccu.thuonghieu_id = thuonghieu.id AND " + dieukien;
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
                piano.HinhAnh = row["Hình Ảnh"].ToString();
                piano.SoLuong = int.Parse(row["Số lượng"].ToString());
                piano.Phanloai = row["Phân loại"].ToString();
                piano.ThuongHieu = new ThuongHieu();
                piano.ThuongHieu.Ma = row["Mã Thương Hiệu"].ToString();
                piano.ThuongHieu.Ten = row["Tên Thương Hiệu"].ToString();
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
                            "hinhAnh = '{5}', " +
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

            if (db.GetCount("nhaccu", "ma = '" + ma + "' AND trangthai = 1") > 0)
            {
                MessageBox.Show("Mã nhạc cụ đã tồn tại");
                return false;
            }

            string nhaccu_id = db.Insert(string.Format("INSERT INTO nhaccu " +
                "(ma, ten, dacDiemNoiBat, moTaChiTiet, gia," +
                " hinhAnh, soLuong, thuonghieu_id, trangthai) OUTPUT inserted.id " +
                "VALUES ('{0}', N'{1}', N'{2}', N'{3}', {4}, '{5}', 0, {6}, {7})",
                ma, ten, dacDiemNoiBat, moTaChiTiet, gia, hinhAnh, idThuongHieu, 1)).ToString();
            if(nhaccu_id == "-1") { return false; } // thêm nhạc cụ thất bại

            db.Insert(string.Format("INSERT INTO piano (phanLoai, nhaccu_id) OUTPUT inserted.id " +
                "VALUES (N'{0}', {1})", phanLoai, nhaccu_id));
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
                "WHERE {0}", tieuChi));
            return true;
        }

        public DataTable Loc(string maSanPham, string tenSanPham, string mucGiaDuocChon, string thuongHieuDuocChon) 
        {
            string dieukien = "";

                if (!maSanPham.Equals(""))
                {
                    dieukien += "AND Upper(nhaccu.ma) LIKE N'%"+maSanPham.ToUpper()+"%'";
                }
                if (!tenSanPham.Equals(""))
                {
                     dieukien += "AND Upper(nhaccu.ten) LIKE N'%" + tenSanPham.ToUpper() + "%'";
                }
                if (!thuongHieuDuocChon.Equals(""))
                {
                     dieukien += "AND thuonghieu.ten = '"+thuongHieuDuocChon+"'";
                }
                if (!mucGiaDuocChon.Equals(""))
                {
                    switch (mucGiaDuocChon)
                    {
                        case "< 5 triệu": // < 5 trieu
                        {
                            dieukien += "AND nhaccu.gia < 5000000";
                            break;
                        }
                        case "5 đến 10 triệu": // 5 <= gia <=10 trieu 
                        {
                            dieukien += "AND 5000000 <= nhaccu.gia AND nhaccu.gia <= 10000000";
                            break;
                        }

                        case "10 đến 20 triệu": // 10 <= gia <= 20 trieu
                        {
                            dieukien += "AND 10000000 <= nhaccu.gia AND nhaccu.gia <= 20000000";
                            break;
                        }

                        case "> 20 triệu": // > 20 trieu
                        {
                            dieukien += "AND nhaccu.gia > 20000000";
                            break;
                        }
                    }
                }

            string sqlStr = "SELECT \r\nnhaccu.ma as N'Mã nhạc cụ', \r\nnhaccu.ten as N'Tên', \r\ndacDiemNoiBat as N'Đặc điểm nổi bật', " +
                "\r\nmoTaChiTiet as N'Mô tả chi tiết', \r\ngia as N'Giá', \r\nsoLuong as N'Số lượng' \r\nFROM piano, nhaccu, thuonghieu" +
                "\r\nWHERE piano.nhaccu_id = nhaccu.id AND \r\nnhaccu.thuonghieu_id = thuonghieu.id and nhaccu.trangthai = 1" + dieukien;
            return db.Execute(sqlStr);
        }

        public List<DoiTuong> TimKiem(string tieuChi, string giaTri)
        {
            string dieuKien = "";
            switch (tieuChi)
            {
                case "ID":
                    {
                        dieuKien = "CAST(nhaccu.id AS VARCHAR) LIKE '%" + giaTri + "%'";
                        break;
                    }
                case "Mã":
                    {
                        dieuKien = "Upper(nhaccu.ma) LIKE N'%" + giaTri.ToUpper() + "%'";
                        break;
                    }
                case "Tên":
                    {
                        dieuKien = "Upper(nhaccu.ten) LIKE N'%" + giaTri.ToUpper() + "%'";
                        break;
                    }
                case "Thương Hiệu":
                    {
                        dieuKien = "Upper(thuonghieu.ten) LIKE N'%" + giaTri.ToUpper() + "%'";
                        break;
                    }
                case "Loại":
                    {
                        dieuKien = "Upper(piano.phanLoai) LIKE N'%" + giaTri.ToUpper() + "%'";
                        break;
                    }
            }
            MessageBox.Show(dieuKien);
            return LayDS(dieuKien + " AND nhaccu.trangthai = 1");
        }
        public bool ThongTinSanPhamThayDoi(int id, string ma, string ten, long gia,string hinhAnh, string loai, string thuongHieu,
            string dacDiem, string moTa)
        {
            Piano pianoCu = (Piano) LayDS("piano.id=" + id)[0];
            if(pianoCu == null)
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thực hiện đúng các bước", "Báo lỗi");
                return false;
            }
            if(!pianoCu.Ma.Equals(ma) || !pianoCu.Ten.Equals(ten) || pianoCu.Gia != gia || !pianoCu.HinhAnh.Equals(hinhAnh)
                || !pianoCu.Phanloai.Equals(loai) || !pianoCu.ThuongHieu.Ten.Equals(thuongHieu) || !pianoCu.DacDiemNoiBat.Equals(dacDiem)
                || !pianoCu.MoTaChiTiet.Equals(moTa))
            {
                return true;
            }
            
            return false;
        }

        public bool ThongTinSanPhamChinhXac(int id, string ma, string ten, long gia, string hinhAnh, string loai, string thuongHieu,
            string dacDiem, string moTa)
        {
            List<DoiTuong> list = new List<DoiTuong>();
            list = LayDS("nhaccu.ma = '" + ma + "' AND nhaccu.trangThai = 1 AND piano.id != "+id); // lấy ra nhaccu có mã trùng, trạng thái =1 và có id khác spham
            if(list.Count > 0)
            {
                MessageBox.Show("Mã nhạc cụ đã tồn tại, vui lòng nhập mã khác", "Thông báo");
                return false;
            }
            if(ma.Length > 15 || ma.Length < 3)
            {
                MessageBox.Show("Mã nhạc cụ phải từ 3 đến dưới 15 kí tự chữ và số, vui lòng nhập mã khác", "Thông báo");
                return false;
            }
            if (ten.Length > 20 || ten.Length < 3)
            {
                MessageBox.Show("Tên nhạc cụ phải từ 3 đến dưới 20 kí tự chữ và số, vui lòng nhập tên khác", "Thông báo");
                return false;
            }
            if(gia<500000 || gia > 25000000000)
            {
                MessageBox.Show("giá nhạc cụ phải từ 500.000đ đến dưới 25 tỷ đồng, vui lòng nhập giá khác", "Thông báo");
                return false;
            }
            if (dacDiem.Length < 5 || dacDiem.Length > 100) 
            {
                MessageBox.Show("Đặc điểm nhạc cụ phải từ 5 đến dưới 100 kí tự chữ và số, vui lòng nhập lại", "Thông báo");
                return false;
            }
            if(moTa.Length < 5 || moTa.Length > 100)
            {
                MessageBox.Show("Mô tả nhạc cụ phải từ 5 đến dưới 100 kí tự chữ và số, vui lòng nhập lại", "Thông báo");
                return false;
            }
            return true;
        }
    }
}
