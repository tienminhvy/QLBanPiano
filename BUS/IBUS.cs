using QLBanPiano.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.BUS
{
    interface IBUS
    {
        public abstract DataTable LayToanBoDS();
        public abstract List<DoiTuong> LayDS(string dieukien);
        public abstract int SoLuong(string dieuKien);
        public abstract object GiaTriTruong(string tenTruong, string dieuKien);
        public abstract bool Them(params string[] dsTruong);
        public abstract bool Sua(params string[] dsTruong);
        public abstract bool Xoa(string tieuChi);
    }
}
