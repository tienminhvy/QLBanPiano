using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.DTO
{
    public class VaiTro : DoiTuong
    {
        // gồm các trường id, tên, danh sách quyền
        private int id;
        private string ten;
        private List<string> dsQuyen;

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public List<string> DsQuyen { get => dsQuyen; set => dsQuyen = value; }
        public VaiTro()
        {
            Id = -1;
            Ten = "";
            DsQuyen = null;
        }
        public VaiTro(int id, string ten, List<string> dsQuyen)
        {
            Id = id;
            Ten = ten;
            DsQuyen = dsQuyen;
        }
    }
}
