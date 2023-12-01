using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
using ClosedXML.Excel;
using DocumentFormat.OpenXml;
using QLBanPiano.DAL;
using System.Data.SqlClient;
using QLBanPiano.DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;

using OfficeOpenXml;
using System.Globalization;

namespace QLBanPiano.BUS
{
    public class IOFileBUS
    {
        DB db;
        public IOFileBUS() {
            db = new DB();
        }

        public DataTable ImportFormExcelToDataTable(string filename)
        {
            DataTable result = new();
            DataTable temp = new();
            bool isHeader = true;
            // Sử dụng FileStream để mở tệp Excel
            using (var wb = new XLWorkbook(filename))
            {
                var ws = wb.Worksheet(1);
                // Lấy tên của các cột từ dòng header (dòng đầu tiên)
                foreach(var row in ws.RowsUsed())
                {
                    if(row.CellsUsed().Any(cell => !string.IsNullOrEmpty(cell.Value.ToString())))
                    {
                        if (isHeader)
                        {
                            foreach (var cell in row.Cells())
                            {
                                temp.Columns.Add(cell.Value.ToString());
                            }
                            isHeader = false;
                        }
                        else
                        {
                            DataRow dataRow = temp.NewRow();
                            int colIndex = 0;
                            foreach (var cell in row.Cells())
                            {
                                if (colIndex < temp.Columns.Count)
                                {
                                    dataRow[colIndex++] = cell.Value;
                                }
                                else
                                {
                                    MessageBox.Show("Not fit !");
                                }
                            }
                            temp.Rows.Add(dataRow);
                        }
                    }
                }
                result = sort(temp);// sort dựa trên cột ID truyền vào 

            }
            return result;
        }
        public bool ImportConstraint(DataTable fkTable,string fkTableName,string sqlString)//SqlString lay tu ben bus của những đối tượng có ràng buộc như hóa đơn,phiếu nhập
        {//VD : fkTable của phiếu nhập là chi tiết phiếu nhập, fkTableName là chitietphieunhap
            return db.InsertConstraintedData(fkTable,fkTableName,sqlString);
        }
        public int returnIdCount(DataTable table,int id)
        {
            int count = 0;
            foreach(DataRow row in table.Rows)
            {
                if (row["ID"] != DBNull.Value && Convert.ToInt32(row["ID"]) == id)
                {
                    count++;
                }
            }
            return count;

        }
        public List<string> GetListHeader(string filename)
        {
            var list = new List<string>();
            using (XLWorkbook wb = new XLWorkbook(filename))
            {
                // Lấy sheet đầu tiên trong workbook
                var ws = wb.Worksheet(1);
                // Lấy dòng đầu tiên
                var headerRow = ws.FirstRow();
                foreach(var cell in headerRow.Cells())
                {
                    list.Add(cell.Value.ToString());
                }
            }
                return list;
        }
        private DataTable sort(DataTable dt)
        {
            DataTable sortedTable = new();
            try
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataView dv = dt.DefaultView;
                    dv.Sort = "ID ASC";
                    sortedTable = dv.ToTable();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return sortedTable;
        }
        /////////////////////////////EXPORT///////////////////////////////
        public bool ExportHoaDonToPdf(HoaDonPDFExcel hoadon,string filename)
        {
            Document doc = new Document();
            try
            {
                PdfWriter.GetInstance(doc, new FileStream(filename, FileMode.Create));
                doc.Open();
                //Tạo header
                Paragraph header = new Paragraph("SixTeenShop - Hóa đơn bán hàng");
                header.Alignment = Element.ALIGN_CENTER;
                doc.Add(header);

                doc.Add(new Paragraph("\nNgày: " + hoadon.ThoiGian.ToString("dd/MM/yyyy hh:mm:ss tt")+"\n"));

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool ExportToExcel(DataTable table, string filename)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            if (table == null || table.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất ra Excel.");
                return false;
            }

            try
            {
                using (ExcelPackage package = new())
                {
                    // Tạo một worksheet mới
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                    // Đưa dữ liệu từ DataTable vào worksheet
                    worksheet.Cells["A1"].LoadFromDataTable(table, true);

                    // Xác định định dạng cho cột "Thời gian"
                    worksheet.Column(2).Style.Numberformat.Format = "MM/dd/yyyy hh:mm:ss";

                    // Lưu file Excel
                    var file = new FileInfo(filename);
                    package.SaveAs(file);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Lỗi khi tạo hoặc mở file Excel. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel. " + ex.Message);
                return false;
            }

            return true;
        }

    }
}
