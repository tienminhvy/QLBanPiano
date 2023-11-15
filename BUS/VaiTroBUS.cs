﻿using QLBanPiano.DAL;
using QLBanPiano.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.BUS
{
    class VaiTroBUS : IBUS
    {
        DB db;
        public VaiTroBUS()
        {
            db = new DB();
        }
        public object GiaTriTruong(string tenTruong, string dieuKien)
        {
            return db.GetColumn("vaitro", tenTruong, dieuKien);
        }

        public List<DoiTuong> LayDS(string dieukien)
        {
            string sqlStr = "SELECT " +
                "* FROM vaitro WHERE " + dieukien;

            DataTable dt = db.Execute(sqlStr);
            List<DoiTuong> ds = new List<DoiTuong>();

            foreach (DataRow row in dt.Rows)
            {
                if (int.Parse(row["trangthai"].ToString()) == 0)
                    continue;
                VaiTro vaiTro = new VaiTro();
                vaiTro.Id = int.Parse(row["id"].ToString());
                vaiTro.Ten = row["ten"].ToString();
                List<string> dsQuyen = row["dsQuyen"].ToString().Split(',').ToList();
                vaiTro.DsQuyen = dsQuyen;
                ds.Add(vaiTro);
            }

            return ds;
        }

        public DataTable LayToanBoDS()
        {
            throw new NotImplementedException();
        }

        public int SoLuong(string dieuKien)
        {
            return db.GetCount("vaitro", dieuKien);
        }

        public bool Sua(params string[] dsTruong)
        {
            string id = dsTruong[0];
            string ten = dsTruong[1];
            string dsQuyen = dsTruong[2];

            string tenCu = db.GetColumn("vaitro", "ten", "id = " + id).ToString();
            if (tenCu != ten)
            {
                if (db.GetCount("vaitro", "ten = N'"+ten+"' and trangthai = 1") > 0)
                {
                    MessageBox.Show("Tên vai trò đã tồn tại trong CSDL");
                    return false;
                } else
                {
                    db.ExecuteNonQuery(string.Format("UPDATE vaitro " +
                    "SET ten = N'{0}', " +
                    "dsQuyen = '{1}' " +
                    "WHERE id = {2}", ten, dsQuyen, id));
                }
            } else
            {
                db.ExecuteNonQuery(string.Format("UPDATE vaitro " +
                "SET dsQuyen = '{0}' " +
                "WHERE id = {1}", dsQuyen, id));
            }
            return true;
        }

        public bool Them(params string[] dsTruong)
        {
            string ten = dsTruong[0];
            string dsQuyen = dsTruong[1];
            if (db.GetCount("nhaccu", "ten = N'"+ten+"' AND trangthai = 1") == 0)
            {
                MessageBox.Show("Vai trò đã tồn tại");
                return false;
            }
            int check = db.Insert(string.Format("INSERT INTO vaitro (ten, dsQuyen) " +
                "VALUES (N'{0}', '{1}')", ten, dsQuyen));
            return (check != -1);
        }

        public bool Xoa(string tieuChi)
        {
            db.ExecuteNonQuery(string.Format("UPDATE vaitro " +
                "SET trangthai = 0 " +
                "WHERE {1}", tieuChi));
            return true;
        }
    }
}
