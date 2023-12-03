using QLBanPiano.DAL;
using QLBanPiano.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
        private ThuongHieuBUS thuongHieuBUS = new ThuongHieuBUS();
        private IOFileBUS iOFileBUS = new IOFileBUS();
        private List<string> HeaderExcel = new List<string> { "Mã nhạc cụ", "Tên", "Đặc điểm nổi bật",
            "Mô tả chi tiết", "Giá", "Hình Ảnh","Phân loại", "id Thương Hiệu" };
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
        public bool checkExist(string tablename,int id) //áp dụng cho những hàm có col trạng thái
        {
            string condition = " id = "+id+ " and trangthai = 1";
            int result = db.GetCount(tablename, condition);
            if (result == -1) return false;
            return true;
        }
        public List<DoiTuong> LayDS(string dieukien)
        {
            string sqlStr = "SELECT  piano.id as 'id'," +
                "nhaccu.ma as N'Mã nhạc cụ'," +
                "nhaccu.ten as N'Tên'," +
                "dacDiemNoiBat as N'Đặc điểm nổi bật'," +
                "moTaChiTiet as N'Mô tả chi tiết'," +
                "gia as N'Giá'," +
                "hinhAnh as N'Hình Ảnh'," +
                "soLuong as N'Số lượng'," +
                "phanLoai as N'Phân loại', " +
                "thuonghieu.ma as N'Mã Thương Hiệu'," +
                "thuonghieu.ten as N'Tên Thương Hiệu'," +
                "nhaccu.thuonghieu_id " +
                "FROM piano, nhaccu, thuonghieu " +
                "WHERE piano.nhaccu_id = nhaccu.id AND nhaccu.thuonghieu_id = thuonghieu.id AND nhaccu.trangthai = 1 AND " + dieukien;
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
                "soLuong as N'Số lượng' " +
                "FROM piano, nhaccu, thuonghieu " +
                "WHERE piano.nhaccu_id = nhaccu.id AND " +
                "nhaccu.thuonghieu_id = thuonghieu.id AND nhaccu.trangthai = 1";
                return db.Execute(sqlStr);
        }

        public DataTable LayToanBoDSXuatExcel()
        {
            string sqlStr = "SELECT  piano.id as 'id'," +
                "nhaccu.ma as N'Mã nhạc cụ'," +
                "nhaccu.ten as N'Tên'," +
                "dacDiemNoiBat as N'Đặc điểm nổi bật'," +
                "moTaChiTiet as N'Mô tả chi tiết'," +
                "gia as N'Giá'," +
                "hinhAnh as N'Hình Ảnh'," +
                "soLuong as N'Số lượng'," +
                "phanLoai as N'Phân loại', " +
                "thuonghieu.ma as N'Mã Thương Hiệu'," +
                "thuonghieu.ten as N'Tên Thương Hiệu'," +
                "nhaccu.thuonghieu_id as N'id Thương Hiệu' " +
                "FROM piano, nhaccu, thuonghieu " +
                "WHERE piano.nhaccu_id = nhaccu.id AND nhaccu.thuonghieu_id = thuonghieu.id AND nhaccu.trangthai = 1";
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

        public void XuatFileExcel()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.xlsx;*.xls";
            sfd.Title = "Chọn nơi lưu file";
            sfd.FilterIndex = 1;
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = sfd.FileName;
                DataTable export = LayToanBoDSXuatExcel();
                DataRow row = export.Rows[0];
                bool return_val = iOFileBUS.ExportToExcel(export, filename);
                if (return_val)
                {
                    MessageBox.Show("Export Excel thành công");
                    Process.Start(new ProcessStartInfo(filename) { UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show("Export thất bại !");
                }
            }
        }
        /**
         * <summary>Xác minh thông tin</summary>
         * <param name="dsTruong">gồm ma, ten, dacDiemNoiBat, moTaChiTiet, gia, hinhAnh, phanLoai, idThuongHieu</param>
         * <returns>true/false</returns>
         */
        public bool Validate(params string[] dsTruong)
        {
            string ma = dsTruong[0];
            string ten = dsTruong[1];
            string dacDiemNoiBat = dsTruong[2];
            string moTaChiTiet = dsTruong[3];
            long gia = long.Parse(dsTruong[4]);
            string hinhAnh = dsTruong[5];
            string phanLoai = dsTruong[6];
            int idThuongHieu = int.Parse(dsTruong[7]);

            List<int> dsIdThuongHieu = new ThuongHieuBUS().LayDSIdThuongHieu();
            if (!hinhAnh.Equals("example.png"))
            {
                return false; // hình ảnh mặc định từ file là example
            }
            if (!phanLoai.Equals("điện") && !phanLoai.Equals("Upright") && !phanLoai.Equals("Grand"))
            {
                return false; // loại nhạc cụ nằm ngoài danh sách
            }
            if (!dsIdThuongHieu.Contains(idThuongHieu))
            {
                return false; //id thương hiệu nằm ngoài danh sách thương hiệu
            }
            if (ma.Length > 15 || ma.Length < 3)
            {
                return false; //Mã dài trên >15 hoặc <3
            }
            if (ten.Length > 20 || ten.Length < 3)
            {
                return false; //Tên dài >20 hoặc dưới <3
            }
            if (gia < 500000 || gia > 25000000000)
            {
                return false; //Giá dưới 500 000 hoặc trên 25 tỷ
            }
            if (dacDiemNoiBat.Length < 5 || dacDiemNoiBat.Length > 100)
            {
                return false; // đặc điểm dài <5 hoặc >100
            }
            if (moTaChiTiet.Length < 5 || moTaChiTiet.Length > 100)
            {
                return false;
            }
            return true;
        }


        public bool Validates(DTO.Piano piano)
        {
            List<int> dsIdThuongHieu = new ThuongHieuBUS().LayDSIdThuongHieu();
            if (!piano.HinhAnh.Equals("example.png"))
            {
                return false; // hình ảnh mặc định từ file là example
            }
            if (!piano.Phanloai.Equals("Điện") && !piano.Phanloai.Equals("Upright") && !piano.Phanloai.Equals("Grand"))
            {
                return false; // loại nhạc cụ nằm ngoài danh sách
            }
            if (!dsIdThuongHieu.Contains(piano.ThuongHieu.Id))
            {
                return false; //id thương hiệu nằm ngoài danh sách thương hiệu
            }
            if (piano.Ma.Length > 15 || piano.Ma.Length < 3)
            {
                return false; //Mã dài trên >15 hoặc <3
            }
            if (piano.Ten.Length > 20 || piano.Ten.Length < 3)
            {
                return false; //Tên dài >20 hoặc dưới <3
            }
            if (piano.Gia < 500000 || piano.Gia > 25000000000)
            {
                return false; //Giá dưới 500 000 hoặc trên 25 tỷ
            }
            if (piano.DacDiemNoiBat.Length < 5 || piano.DacDiemNoiBat.Length > 100)
            {
                return false; // đặc điểm dài <5 hoặc >100
            }
            if (piano.MoTaChiTiet.Length < 5 || piano.MoTaChiTiet.Length > 100)
            {
                return false;
            }
            return true;
        }

        public bool ValidatesList(List<DTO.Piano> list)
        {
            foreach (DTO.Piano piano in list)
            {
                if (!Validates(piano))
                {
                    return false;
                }
            }
            return true;
        }
        
        public bool NhapFileExcel()
        {
            bool imported = true;
            OpenFileDialog ofd = new OpenFileDialog();
            // Thiết lập các thuộc tính của OpenFileDialog
            ofd.Title = "Chọn file Excel";
            ofd.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"; // Chỉ cho phép chọn các file Excel
            ofd.CheckFileExists = true; // Kiểm tra file tồn tại
            ofd.CheckPathExists = true; // Kiểm tra đường dẫn hợp lệ
            // Mở cửa sổ OpenFileDialog và xử lý kết quả
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string selectedFilePath = ofd.FileName;
                    List<string> temp = iOFileBUS.GetListHeader(selectedFilePath);
                    
                    //List<HoaDonPDFExcel> listImport = new();
                    if (temp.SequenceEqual(HeaderExcel) == true) //"Mã nhạc cụ", "Tên", "Đặc điểm nổi bật", "Mô tả chi tiết", "Giá", "Hình Ảnh","Phân loại", "id Thương Hiệu"
                    {
                        
                        DataTable raw = iOFileBUS.ImportFormExcelToDataTableWithOutID(selectedFilePath);
                        DataTable rawClone = getClone(raw); // tạo bản copy của datatable
                        List<DoiTuong> ds = new List<DoiTuong>();

                        try
                        {
                            List<DTO.Piano> list = new List<DTO.Piano>();

                            foreach (DataRow row in rawClone.Rows)
                            {
                                string ma = row["Mã nhạc cụ"].ToString();
                                string ten = row["Tên"].ToString();
                                string dacDiemNoiBat = row["Đặc điểm nổi bật"].ToString();
                                string moTaChiTiet = row["Mô tả chi tiết"].ToString();
                                long gia = long.Parse(row["Giá"].ToString());
                                string hinhAnh = row["Hình Ảnh"].ToString();
                                string phanLoai = row["Phân loại"].ToString();
                                int idThuongHieu = int.Parse(row["id Thương Hiệu"].ToString());
                                string[] dsTruong = new string[] { ma, ten, dacDiemNoiBat, moTaChiTiet, gia.ToString(), hinhAnh, phanLoai, idThuongHieu.ToString() };
                                DTO.ThuongHieu thuongHieu = (DTO.ThuongHieu)thuongHieuBUS.LayDS("id = " + idThuongHieu)[0];
                                
                                DTO.NhacCu nhaccu = new DTO.NhacCu(0, ma, ten, dacDiemNoiBat, moTaChiTiet, gia, hinhAnh, 0, thuongHieu);
                                DTO.Piano piano = new DTO.Piano(0, phanLoai, nhaccu);
                                list.Add(piano);
                            }
                            if (!ValidatesList(list))
                            {
                                MessageBox.Show("Có trường dữ liệu không hợp lệ, vui lòng điền file đúng dữ liệu");
                                return false;
                            }
                            MessageBox.Show(ThemDanhSachTuExcel(list));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Dữ liệu của file nhập không hợp lệ" + ex.Message);
                            imported = false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Format của file nhập không hợp lệ");
                        imported = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mở file thất bại: " + ex.Message);
                    imported = false;
                }
            }
            else
            {
                MessageBox.Show("Người dùng đã hủy việc chọn file.");
                imported = false;
            }
            if (imported)
            {
                MessageBox.Show("Import file thành công");
            }
            return imported;
        }
        public string ThemDanhSachTuExcel(List<DTO.Piano> list)
        {
            string[] dsTruong;
            string dsMaKhongThemDuoc = "";
            int soLuongSanPhamThem = 0;
            int soLuongSanPhamSua = 0;
            foreach (DTO.Piano piano in list)
            {
                List<DTO.DoiTuong> DoiTuongTrongDS = LayDS("nhaccu.ma = '" + piano.Ma +"'");
                if (DoiTuongTrongDS.Count == 0) // Nếu mã của piano trong file k trùng thì thêm vào
                {
                    dsTruong = new string[] {piano.Ma, piano.Ten,
                            piano.DacDiemNoiBat, piano.MoTaChiTiet, piano.Gia.ToString(),
                            piano.HinhAnh, piano.Phanloai, piano.ThuongHieu.Id.ToString()};
                    if (!Them(dsTruong)) // cái này để sơ cua khi không thêm được
                    {
                        dsMaKhongThemDuoc += piano.Ma + ", ";
                    }
                    else
                    {
                        soLuongSanPhamThem++;
                    }
                }
                else
                {
                    DTO.Piano pianoTrongDS = (DTO.Piano)DoiTuongTrongDS[0];
                    if(pianoTrongDS.Ten.Equals(piano.Ten)) { // nếu trùng mã trùng tên thì sửa thông tin sản phẩm
                        dsTruong = new string[] {piano.Ma, piano.Ten,
                            piano.DacDiemNoiBat, piano.MoTaChiTiet, piano.Gia.ToString(),
                            piano.HinhAnh, piano.Phanloai, piano.ThuongHieu.Id.ToString(), pianoTrongDS.Id.ToString()};
                        if (!Sua(dsTruong)) // cái này để sơ cua khi không sửa được
                        {
                            dsMaKhongThemDuoc += piano.Ma + ", ";
                        }
                        else
                        {
                            soLuongSanPhamSua++;
                        }
                    }
                    else // trùng mã nhưng khác tên thì không được thêm
                    {
                        dsMaKhongThemDuoc += piano.Ma + ", ";
                    }
                }
            }
            if (!dsMaKhongThemDuoc.Equals(""))
            {
                return "Hoàn thành việc nhập dữ liệu từ excel, thêm thành công: " + soLuongSanPhamThem + "\n sửa thành công: "+ soLuongSanPhamSua + "\n Mã sản phẩm gặp lỗi: "+ dsMaKhongThemDuoc.Remove(dsMaKhongThemDuoc.Length-2);
            }
            else
            {
                return "Hoàn thành việc nhập dữ liệu từ excel, thêm thành công: " + soLuongSanPhamThem + "\n sửa thành công: " + soLuongSanPhamSua;
            }
        }
        public DataTable getClone(DataTable dt)
        {
            DataTable clone = dt.Clone();
            foreach (DataRow row in dt.Rows)
            {
                clone.ImportRow(row);
            }
            return clone;
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
            return LayDS(dieuKien + " AND nhaccu.trangthai = 1");
        }
        public bool ThongTinSanPhamThayDoi(int id, string ma, string ten, long gia,string hinhAnh, string loai, string thuongHieu,
            string dacDiem, string moTa)
        {
            QLBanPiano.DTO.Piano pianoCu = (QLBanPiano.DTO.Piano) LayDS("piano.id=" + id)[0];
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
