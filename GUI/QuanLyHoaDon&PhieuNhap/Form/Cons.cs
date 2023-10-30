using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano
{
    public class Cons
    {
        public static string menu = "       Menu";
        public static string home = "               Home";
        public static string billsDetails = "Bills Details";
        public static string importsDetail = "      Imports Details";
        public static string exit = "       Exit";
        public static int slideBarMinWidth = 60;
        public static int slideBarMaxWidth = 250;

        public static string maHDtextBox = "Theo mã hóa đơn";
        public static string maNCtextBox = "Theo mã nhạc cụ";
        public static string soLuongTextBox = "Theo số lượng";
        public static Font textBoxFont = new Font("Times New Roman", 10);
        public static Color textColor = Color.FromArgb(171, 171, 171);
    }
}
