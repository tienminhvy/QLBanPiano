using DocumentFormat.OpenXml.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.DTO
{
    public class Piano : NhacCu, DoiTuong
    {
        private int id;
        private string phanloai;

        public int Id { get => id; set => id = value; }
        public string Phanloai { get => phanloai; set => phanloai = value; }

        public Piano()
        {
            id = -1;
            phanloai = "";
        }

        public Piano(int id, string phanloai, NhacCu nhacCu) : base(nhacCu.Id, nhacCu.Ma, nhacCu.Ten, nhacCu.DacDiemNoiBat, nhacCu.MoTaChiTiet,nhacCu.Gia, nhacCu.HinhAnh, nhacCu.SoLuong, nhacCu.ThuongHieu)
        {
            this.id = id;
            this.phanloai = phanloai;
        }
    }
}