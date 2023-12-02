using QLBanPiano.DAL;
using QLBanPiano.DTO;
using QLBanPiano.GUI;
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

        public List<DoiTuong> LayDS(string dieukien = "")
        {
            if (dieukien == string.Empty)
                dieukien = "1 = 1";
            string sqlStr = "SELECT " +
                "* FROM thuonghieu WHERE trangthai = 1 AND " + dieukien;

            DataTable dt = db.Execute(sqlStr);
            List<DoiTuong> ds = new List<DoiTuong>();
            ThuongHieu thuonghieu;
            foreach (DataRow row in dt.Rows)
            {
                thuonghieu = new ThuongHieu();
                thuonghieu.Id = int.Parse(row["id"].ToString());
                thuonghieu.Ma = row["ma"].ToString();
                thuonghieu.Ten = row["ten"].ToString();
                thuonghieu.MoTa = row["moTa"].ToString();
                ds.Add(thuonghieu);
            }
            return ds;
        }

        public DataTable LayToanBoDS()
        {
            string sqlStr = "SELECT " +
                "id as N'Id', " +
                "ma as N'Mã', " +
                "ten as N'Tên', " +
                "moTa as N'Mô tả' " +
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

        public List<String> LayDSMaThuongHieu()
        {
            List<String> list = new List<String>();
            string sqlStr = "SELECT ma as N'Mã Thương Hiệu'\r\nFROM thuonghieu";

            DataTable dt = db.Execute(sqlStr);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr["Mã Thương Hiệu"].ToString());
            }
            return list;
        }
        public List<int> LayDSIdThuongHieu()
        {
            List<int> list = new List<int>();
            string sqlStr = "SELECT id as N'id Thương Hiệu'\r\nFROM thuonghieu";

            DataTable dt = db.Execute(sqlStr);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(int.Parse(dr["id Thương Hiệu"].ToString()));
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

            db.ExecuteNonQuery(string.Format("UPDATE thuonghieu " +
                "SET ma = N'{0}', " +
                "ten = N'{1}', " +
                "moTa = N'{2}' " +
                "WHERE id = {3}", ma, ten, moTa, id));
            return true;
        }

        public bool Them(params string[] dsTruong)
        {
            string ma = dsTruong[0];
            string ten = dsTruong[1];
            string moTa = dsTruong[2];

            db.ExecuteNonQuery(string.Format("INSERT INTO thuonghieu " +
                "(ma, ten, moTa, trangthai) " +
                "VALUES (N'{0}', N'{1}', N'{2}', 1);", ma, ten, moTa));
            return true;
        }

        public bool Xoa(string tieuChi)
        {
            db.ExecuteNonQuery(string.Format("UPDATE thuonghieu " +
                "SET trangthai = 0 " +
                "WHERE {0}", tieuChi));
            return true;
        }

        public bool Validate(params string[] dsTruong)
        {
            string ma = dsTruong[0];
            string ten = dsTruong[1];
            string moTa = dsTruong[2];
            string id = dsTruong[3];

            if (ma == string.Empty || ten == string.Empty || moTa == string.Empty)
            {
                new Msg("Vui lòng điền đầy đủ thông tin", "err");
                return false;
            }

            if (id == "-1" && db.GetCount("thuonghieu", "ma = N'" + ma + "' AND trangthai = 1") > 0)
            {
                new Msg("Mã thương hiệu này đã tồn tại!");
                return false;
            }

            return true;
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
                case "Mã":
                    {
                        dieuKien = "Upper(Ma) LIKE N'%" + giaTri.ToUpper() + "%'";
                        break;
                    }
                case "Tên":
                    {
                        dieuKien = "Upper(Ten) LIKE N'%" + giaTri.ToUpper() + "%'";
                        break;
                    }
            }
            if (dieuKien == string.Empty)
                dieuKien = "1=1";
            return LayDS(dieuKien);
        }
    }
}
