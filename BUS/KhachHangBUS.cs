﻿using QLBanPiano.DAL;
using QLBanPiano.DTO;
using QLBanPiano.GUI;
using QLBanPiano.GUI.SubForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanPiano.BUS
{
    internal class KhachHangBUS : IBUS
    {
        private PianoBUS pianoBus = new();
        DB db;
        public KhachHangBUS()
        {
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
            return db.GetColumn("khachhang", tenTruong, dieuKien);
        }
        /**
         * <summary>Lấy toàn bộ danh sách khách hàng</summary>
         * <param name="dieukien">Điều kiện truyền vào (ví dụ 1 = 1 để thực hiện câu lệnh này mặc định)</param>
         * <returns>List<DoiTuong></returns>
         */
        public List<DoiTuong> LayDS(string dieukien)
        {
            string sqlStr = "SELECT " +
                "khachhang.id as N'Mã khách hàng', " +
                "khachhang.hoLot as N'Họ lót', " +
                "khachhang.ten as N'Tên', " +
                "khachhang.diaChi as N'Địa chỉ', " +
                "khachhang.sdt as N'Số điện thoại' " +
                "FROM khachhang WHERE trangthai = 1 AND " + dieukien;
            DataTable dt = db.Execute(sqlStr);
            List<DoiTuong> ds = new List<DoiTuong>();

            foreach (DataRow row in dt.Rows)
            {
                KhachHang khachHang = new KhachHang();
                khachHang.Id = int.Parse(row["Mã khách hàng"].ToString());
                khachHang.HoLot = row["Họ lót"].ToString();
                khachHang.Ten = row["Tên"].ToString();
                khachHang.DiaChi = row["Địa chỉ"].ToString();
                khachHang.SoDienThoai = row["Số điện thoại"].ToString();
                ds.Add((DoiTuong)khachHang);
            }

            return ds;
        }

        public bool checkExist(int id)
        {
            return pianoBus.checkExist("khachhang", id);
        }


        /**
         * <summary>Lấy toàn bộ danh sách khách hàng</summary>
         * <returns>DataTable</returns>
         */
        public DataTable LayToanBoDS()
        {
            string sqlStr = "SELECT " +
                "khachhang.id as N'Mã khách hàng', " +
                "khachhang.hoLot as N'Họ lót', " +
                "khachhang.ten as N'Tên', " +
                "khachhang.diaChi as N'Địa chỉ', " +
                "khachhang.sdt as N'Số điện thoại' " +
                "FROM khachhang " +
                "WHERE trangthai = 1";

            return db.Execute(sqlStr);
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
            }
            if (dieuKien == string.Empty)
                dieuKien = "1=1";
            return LayDS(dieuKien);
        }
        /**
         * <summary>Lấy số lượng</summary>
         * <param name="dieuKien">điều kiện truyền vào (ví dụ 1 = 1 để mặc định)</param>
         * <returns>true/false</returns>
         */
        public int SoLuong(string dieuKien)
        {
            return db.GetCount("khachhang", dieuKien);
        }
        /**
         * <summary>Sửa khách hàng</summary>
         * <param name="dsTruong">gồm hoLot, ten, diaChi, soDienThoai, id của khách hàng cần sửa theo thứ tự</param>
         * <returns>true/false</returns>
         */
        public bool Sua(params string[] dsTruong)
        {
            string hoLot = dsTruong[0];
            string ten = dsTruong[1];
            string diaChi = dsTruong[2];
            string sdt = dsTruong[3];
            string id = dsTruong[4];

            db.ExecuteNonQuery(string.Format("UPDATE khachhang " +
                            "SET hoLot = N'{0}', " +
                            "ten = N'{1}', " +
                            "diaChi = N'{2}', " +
                            "sdt = '{3}' " +
                            "WHERE id = {4}",
                            hoLot,
                            ten,
                            diaChi,
                            sdt,
                            id));
            return true;
        }

        /**
         * <summary>Validate giá trị truyền vào</summary>
         * <param name="dsTruong">gồm hoLot, ten, diaChi, soDienThoai theo thứ tự</param>
         * <returns>true/false</returns>
         */

        public void FocusTextField(int Case, Form f)
        {
            switch (Case)
            {
                case 0: // holot
                    if (f is frmQLKhachHang)
                        ((frmQLKhachHang)f).f_txtHoLot.Focus();
                    if (f is frmThemKhachHang)
                        ((frmThemKhachHang)f).f_txtHoLot.Focus();
                    break;
                case 1: // ten
                    if (f is frmQLKhachHang)
                        ((frmQLKhachHang)f).f_txtTen.Focus();
                    if (f is frmThemKhachHang)
                        ((frmThemKhachHang)f).f_txtTen.Focus();
                    break;
                case 2: // diachi
                    if (f is frmQLKhachHang)
                        ((frmQLKhachHang)f).f_txtDiaChi.Focus();
                    if (f is frmThemKhachHang)
                        ((frmThemKhachHang)f).f_txtDiaChi.Focus();
                    break;
                case 3: // sdt
                    if (f is frmQLKhachHang)
                        ((frmQLKhachHang)f).f_txtSDT.Focus();
                    if (f is frmThemKhachHang)
                        ((frmThemKhachHang)f).f_txtSDT.Focus();
                    break;
            }
        }

        public bool Validate(Form f, params string[] dsTruong)
        {
            string hoLot = dsTruong[0];
            string ten = dsTruong[1];
            string diaChi = dsTruong[2];
            string sdt = dsTruong[3];
            string id = dsTruong[4];

            //kiểm tra các trường thông tin có rỗng hay không
            if (hoLot.Equals("") || ten.Equals("") || diaChi.Equals("") || sdt.Equals(""))
            {
                new Msg("Vui lòng nhập đầy đủ thông tin!", "err");
                return false;
            }
            foreach (char kyTu in hoLot)
            {
                if (char.IsDigit(kyTu))
                {
                    FocusTextField(0, f);
                    new Msg("Họ lót chỉ được chứa kí tự chữ!", "err");
                    return false;
                }
            }
            foreach (char kyTu in ten)
            {
                if (char.IsDigit(kyTu))
                {
                    FocusTextField(1, f);
                    new Msg("Tên chỉ được chứa kí tự chữ!", "err");
                    return false;
                }
            }
            foreach (char kyTu in sdt)
            {
                if (!Char.IsDigit(kyTu))
                {
                    FocusTextField(3, f);
                    new Msg("Số điện thoại chỉ được chứa kí tự số!", "err");
                    return false;
                }
            }
            //kiểm tra số điện thoại của khách hàng có đủ 10 chữ số hay không và
            if (sdt.Length != 10)
            {
                FocusTextField(3, f);
                new Msg("Số điện thoại phải có 10 chữ số!", "err");
                return false;
            }

            //kiểm tra số điện thoại đã tồn tại hay chưa khi tạo
            if (id == "-1" && db.GetCount("khachhang", "sdt = N'" + sdt + "' AND trangthai = 1") > 0)
            {
                FocusTextField(3, f);
                new Msg("Số điện thoại đã tồn tại", "err");
                return false;
            }
            return true;
        }

        /**
         * <summary>Thêm vào 1 khách hàng</summary>
         * <param name="dsTruong">gồm hoLot, ten, diaChi, soDienThoai theo thứ tự</param>
         * <returns>true/false</returns>
         */
        public bool Them(params string[] dsTruong)
        {
            string hoLot = dsTruong[0];
            string ten = dsTruong[1];
            string diaChi = dsTruong[2];
            string sdt = dsTruong[3];

            // Thực hiện câu truy vấn để thêm mới khách hàng
            db.Insert(string.Format("INSERT INTO khachhang (hoLot, ten, diaChi, sdt, trangthai) " +
                            "OUTPUT INSERTED.ID " +
                            "VALUES (N'{0}', N'{1}', N'{2}', '{3}', 1)",
                            hoLot,
                            ten,
                            diaChi,
                            sdt));

            return true;
        }
        /**
         * <summary>Xoá khách hàng (soft delete)</summary>
         * <param name="tieuChi">Điều kiện xoá (ví dụ tên cột = điều kiện | hoLot = N'Nguyễn')</param>
         * <returns>true/false</returns>
         */
        public bool Xoa(string tieuChi)
        {
            db.ExecuteNonQuery(string.Format("UPDATE khachhang " +
                "SET trangthai = 0 " +
                "WHERE {0}", tieuChi));
            return true;
        }

        public bool Validate(params string[] dsTruong)
        {
            throw new NotImplementedException();
        }
    }
}
