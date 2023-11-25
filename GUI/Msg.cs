using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanPiano.GUI
{
    public class Msg
    {
        private DialogResult res;
        public Msg(string msg, string type = "") {
            switch (type)
            {
                case "err":
                    res = MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "warn":
                    res = MessageBox.Show(msg, "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    break;
                default:
                    res = MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        public DialogResult Res
        {
            get { return res; }
        }
    }
}
