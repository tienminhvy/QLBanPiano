using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.DTO
{
    public class Piano
    {
        private int id;
        private string phanloai;
        private NhacCu nhacCu;

        public int Id { get => id; set => id = value; }
        public string Phanloai { get => phanloai; set => phanloai = value; }
        public NhacCu NhacCu { get => nhacCu; set => nhacCu = value; }

        public Piano() {
            id = -1;
            phanloai = "";
            nhacCu = null;
        }

        public Piano(int id, string phanloai, NhacCu nhacCu)
        {
            this.id = id;
            this.phanloai = phanloai;
            this.nhacCu = nhacCu;
        }
    }
}
