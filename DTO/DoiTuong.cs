using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.DTO
{
    public interface DoiTuong
    {
        // gồm tạo mới, sửa và xoá
        public static bool TaoMoi(dynamic []args) {
            return true;
        }
        public bool Sua(dynamic[] args);

        public static bool Xoa(dynamic []args)
        {
            return true;
        }
    }
}
