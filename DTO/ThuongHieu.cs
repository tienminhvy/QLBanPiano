using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.DTO
{
    public class ThuongHieu : DoiTuong
    {
        private int id;
        private string ma;
        private string ten;
        private string moTa;

        public int Id { get => id; set => id = value; }
        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string MoTa { get => moTa; set => moTa = value; }

        public ThuongHieu()
        {
            Id = -1;
            Ma = "";
            Ten = "";
            MoTa = "";
        }
        public ThuongHieu(int id, string ma, string ten, string moTa)
        {
            Id = id;
            Ma = ma;
            Ten = ten;
            MoTa = moTa;
        }
    }
}