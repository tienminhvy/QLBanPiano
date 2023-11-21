using QLBanPiano.DAL;
using QLBanPiano.DTO;
using QLBanPiano.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        public List<DoiTuong> LayDS(string dieuKien)
        {
            string sqlStr = "SELECT " +
                "khachhang.id as N'Mã khách hàng ', " +
                "khachhang.hoLot as N'Họ lót', " +
                "khachhang.ten as N'Tên', " +
                "khachhang.diaChi as N'Địa chỉ', " +
                "khachhang.soDienThoai as N'Số điện thoại', " +              
                "FROM khachhang" + dieuKien;
            DataTable dt = db.Execute(sqlStr);
            List<DoiTuong> ds = new List<DoiTuong>();
            foreach (DataRow row in dt.Rows) 
            {
                if (int.Parse(row["trangthai"].ToString()) == 0)
                    continue;
                KhachHang khachhang = new KhachHang();
                khachhang.Id = int.Parse(row["Mã khách hàng"].ToString());
                khachhang.HoLot = row["Họ lót"].ToString();
                khachhang.Ten = row["Tên"].ToString();
                khachhang.DiaChi = row["Địa chỉ"].ToString();
                khachhang.SoDienThoai = row["Số điện thoại"].ToString();
                ds.Add(khachhang);
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
                "khachhang.soDienThoai as N'Số điện thoại', " +
                "FROM khachhang";

            return db.Execute(sqlStr);
        }
        public int SoLuong(string )
        public bool Sua(params string[] dsTruong)
        {
            string id = dsTruong[0];
            string hoLot = dsTruong[1];
            string ten = dsTruong[2];
            string diaChi = dsTruong[3];
            string soDienThoai = dsTruong[4];
            
            //không được để trống các trường thông tin
            if(id.Equals("") || hoLot.Equals("") || ten.Equals("") || diaChi.Equals("") || soDienThoai.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }

            //kiểm tra id của khách hàng đã tồn tại hay chưa
            string idNhacCu = db.GetColumn("khachhang", "id", "id = " + id).ToString();
            





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




    }
}
