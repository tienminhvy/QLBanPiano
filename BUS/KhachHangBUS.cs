using QLBanPiano.DAL;
using QLBanPiano.DTO;
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
        DB db;
        public KhachHangBUS()
        {
            db = new DB();
        }

        public object GiaTriTruong(string tenTruong, string dieuKien)
        {
            return db.GetColumn("khachhang", tenTruong, dieuKien);
        }
        public List<DoiTuong> LayDS(string dieukien) // nếu lấy toàn bộ thì dieukien = "1=1"
        {
            string sqlStr = "SELECT id, holot as N'Họ lót', ten as N'Tên', diaChi as N'Địa chỉ', sdt as N'Số điện thoại' FROM khachhang WHERE " + dieukien;
            DataTable dt = db.Execute(sqlStr);
            List<DoiTuong> ds = new List<DoiTuong>();

            foreach (DataRow row in dt.Rows)
            {
                KhachHang khachHang = new KhachHang();
                khachHang.Id = int.Parse(row["id"].ToString());
                khachHang.HoLot = row["Họ lót"].ToString();
                khachHang.Ten = row["Tên"].ToString();
                khachHang.DiaChi = row["Địa chỉ"].ToString();
                khachHang.SoDienThoai = row["Số điện thoại"].ToString();
                ds.Add(khachHang);
            }

            return ds;
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
            }
            return LayDS(dieuKien + " AND trangthai = 1");
        }

        public DataTable LayToanBoDS()
        {
            return null; //---------ham nay k su dung nha----------
        }

        public int SoLuong(string dieuKien)
        {
            return db.GetCount("khachhang", dieuKien);
        }

        public bool Sua(params string[] dsTruong)
        {
            return true; //------------ham nay k su dung nha---------------
        }
        public bool Them(params string[] dsTruong)
        {
            return true; //-------------ham nay k su dung luon nha------------
        }

        public bool Xoa(string tieuChi)
        {
            db.ExecuteNonQuery(string.Format("UPDATE khachhang " +
                "SET trangthai = 0 " +
                "WHERE {1}", tieuChi));
            return true;
        }
    }
}
