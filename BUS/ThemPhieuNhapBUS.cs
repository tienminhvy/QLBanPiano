using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanPiano.DAL;

namespace QLBanPiano.BUS
{
    public class ThemPhieuNhapBUS
    {
        DB db;
        public ThemPhieuNhapBUS() {
            db = new();
        }
        public int LayID()
        {
            int id = db.ExecuteScalar("phieunhap", "id");
            return id + 1;
        }
    }
}
