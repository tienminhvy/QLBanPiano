using QLBanPiano.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.BUS
{
    class TaiKhoanBUS : IBUS
    {
        public object GiaTriTruong(string tenTruong, string dieuKien)
        {
            // có
            throw new NotImplementedException();
        }

        public List<DoiTuong> LayDS(string dieuKien)
        {
            throw new NotImplementedException();
        }

        public DataTable LayToanBoDS()
        {
            throw new NotImplementedException();
        }

        public int SoLuong(string dieuKien)
        {
            throw new NotImplementedException();
        }

        public bool Sua(params string[] dsTruong)
        {
            // có
            throw new NotImplementedException();
        }

        public bool Them(params string[] dsTruong)
        {
            // có
            throw new NotImplementedException();
        }

        public bool Validate(params string[] dsTruong)
        {
            // có
            throw new NotImplementedException();
        }

        public bool Xoa(string tieuChi)
        {
            // có - soft delete
            throw new NotImplementedException();
        }
    }
}
