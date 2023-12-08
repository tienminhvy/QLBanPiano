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
using QLBanPiano.DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;
using System.Globalization;
using Image = iTextSharp.text.Image;
using DocumentFormat.OpenXml.Math;
using Font = iTextSharp.text.Font;
using Paragraph = iTextSharp.text.Paragraph;
using Org.BouncyCastle.Utilities.Encoders;
using DocumentFormat.OpenXml.Office2013.Excel;
using System.Text.RegularExpressions;
using Microsoft.Reporting.Map.WebForms.BingMaps;

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
                                    // MessageBox.Show("Not fit !");
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
        public DataTable ImportFormExcelToDataTableWithOutID(string filename)
        {
            
            DataTable result = new();
            DataTable temp = new();
            bool isHeader = true;
            // Sử dụng FileStream để mở tệp Excel
            using (var wb = new XLWorkbook(filename))
            {
                var ws = wb.Worksheet(1);
                // Lấy tên của các cột từ dòng header (dòng đầu tiên)
                foreach (var row in ws.RowsUsed())
                {
                    if (row.CellsUsed().Any(cell => !string.IsNullOrEmpty(cell.Value.ToString())))
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
                                    // MessageBox.Show("Not fit !");
                                }
                            }
                            temp.Rows.Add(dataRow);
                        }
                    }
                }
                result = temp;
                //result = sort(temp);// sort dựa trên cột ID truyền vào 
                // không có cột id nên k sort
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
        private byte[] ImageToByte(Bitmap img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        /////////////////////////////EXPORT///////////////////////////////
        public bool ExportHoaDonToPdf(HoaDonPDFExcel hoadon,string filename)
        {
            // Thiết lập font mặc định cho toàn bộ tài liệu
            try
            {
                ChiTietHoaDonBUS chitiet = new();
                DataTable dt = chitiet.LayChiTietHoaDon(hoadon.Id);
                DataTable dataTable = dt.Clone();
                foreach (DataRow row in dt.Rows)
                {
                    dataTable.ImportRow(row);
                }
                dataTable.Columns.Remove("ID");
                dataTable.Columns.Remove("Thời gian");
                dataTable.Columns.Remove("Mã nhân viên");
                dataTable.Columns.Remove("Tên nhân viên");
                dataTable.Columns.Remove("Mã khách hàng");
                dataTable.Columns.Remove("Tên khách hàng");

                dataTable.Columns.Add("Tổng tiền", typeof(int));
                long total_Price = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    row["Tổng tiền"] = Convert.ToInt64(row["SL"]) * Convert.ToInt64(row["Đơn giá"]);
                    total_Price += Convert.ToInt64(row["Tổng tiền"]);
                }
                int soLuong = 0;
                long tongTien = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    soLuong += Convert.ToInt32(row["SL"]);
                    tongTien += Convert.ToInt64(row["Đơn giá"]);
                }
                dataTable.Columns["Tên nhạc cụ"].ColumnName = "Name";
                dataTable.Columns["SL"].ColumnName = "Quantity";
                dataTable.Columns["Đơn giá"].ColumnName = "Price";
                dataTable.Columns["Tổng tiền"].ColumnName = "Total";
                //Open file stream
                FileStream fs = new FileStream(filename,FileMode.Create,FileAccess.Write,FileShare.None);
                Document doc = new();
                doc.SetPageSize(iTextSharp.text.PageSize.A5);
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();
                
                //LOGO
                BaseFont bfLogo = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fLogo = new Font(bfLogo, 20, Font.BOLD, BaseColor.BLACK);
                Image img = Image.GetInstance(ImageToByte(Properties.Resources.Logo128));
                img.ScaleAbsolute(32, 32);
                Paragraph logoHeader = new();
                Chunk logoChunk = new Chunk(img,0,-12);
                Phrase phrase = new();
                phrase.Add(logoChunk);
                Chunk chunk = new Chunk("SixTeenShop");
                phrase.Add(chunk);
                logoHeader.Add(phrase);
                logoHeader.Alignment = Element.ALIGN_CENTER;
                doc.Add(logoHeader);
                //Blank
                for(int i = 0; i < 2; i++)
                {
                    Paragraph p = new Paragraph();
                    p.Add(new Chunk("\n"));
                    doc.Add(p);
                }
                //Header
                BaseFont bfHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN,BaseFont.CP1252,BaseFont.NOT_EMBEDDED);
                Font fHeader = new Font(bfHeader, 16, Font.BOLD, BaseColor.BLACK);
                Paragraph header = new();
                header.Alignment = Element.ALIGN_CENTER;
                header.Add(new Chunk("BILL DETAILS",fHeader));
                doc.Add(header);
                //Blank
                Paragraph blank = new(new Chunk("\n"));
                doc.Add(blank);
                //Id Hoa Don
                Paragraph id = new();
                id.Alignment = Element.ALIGN_CENTER;
                id.Add(new Chunk("ID : " + hoadon.Id));
                doc.Add(id);
                //Blank
                for (int i = 0; i < 1; i++)
                {
                    Paragraph p = new Paragraph();
                    p.Add(new Chunk("\n"));
                    doc.Add(p);
                }
                //Table
                PdfPTable table = new PdfPTable(dataTable.Columns.Count);

                // Thêm dòng tiêu đề từ DataTable
                foreach (DataColumn column in dataTable.Columns)
                {
                    table.DefaultCell.Border = PdfPCell.BOTTOM_BORDER;
                    table.AddCell(column.ColumnName);
                }

                // Thêm dữ liệu từ DataTable
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (object cellValue in row.ItemArray)
                    {
 
                        PdfPCell cell = new PdfPCell(new Phrase(cellValue.ToString()));
                        cell.Border = PdfPCell.BOTTOM_BORDER;
                        cell.HorizontalAlignment = Element.ALIGN_LEFT;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(cell);
                    }
                }
                // Thêm bảng vào tài liệu
                doc.Add(table);
                //Total
                BaseFont bfTotal = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fTotal = new Font(bfLogo, 13, Font.NORMAL, BaseColor.BLACK);
                Paragraph total = new();
                total.Alignment = Element.ALIGN_LEFT;
                Phrase totalPhrase = new();
                Chunk textTotal = new Chunk("           Total : ");
                totalPhrase.Add(textTotal);
                Chunk quanTotal = new Chunk("          " + soLuong);
                totalPhrase.Add(quanTotal);
                Chunk priceTotal = new Chunk("                                        " + tongTien);
                totalPhrase.Add(priceTotal);
                total.Add(totalPhrase);
                doc.Add(total);
                //Line separator
                Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.DottedLineSeparator()));
                doc.Add(line);
                //Tên nhân viên 
                Paragraph nhanvien_name = new();
                Chunk text_nv = new("           Staff's name : ");
                nhanvien_name.Add(text_nv);
                string nv_name = RemoveDiacritics(dt.Rows[0]["Tên nhân viên"].ToString());
                Chunk chunk_nv_name = new Chunk("   "+nv_name);
                nhanvien_name.Add(chunk_nv_name);
                nhanvien_name.Alignment = Element.ALIGN_LEFT;
                doc.Add(nhanvien_name);
                //Thời gian
                Paragraph time = new();
                Chunk text_time = new("           Date : ");
                time.Add(text_time);
                string Day = hoadon.ThoiGian.ToString("dd/MM/yyyy");
                string Time = hoadon.ThoiGian.ToString("hh:mm:ss");
                Chunk hoadon_day = new Chunk("     " + Day + "     -   Time : ");
                time.Add(hoadon_day);
                Chunk hoadon_Time = new Chunk(Time);
                time.Add(hoadon_Time);
                doc.Add(time);
                //Tên khách hàng
                Paragraph khachhang_name = new();
                Chunk text_kh = new("           Customer's name : ");
                khachhang_name.Add(text_kh);
                string kh_name = RemoveDiacritics(dt.Rows[0]["Tên khách hàng"].ToString());
                Chunk chunk_kh_name = new Chunk("   " + kh_name);
                khachhang_name.Add(chunk_kh_name);
                khachhang_name.Alignment = Element.ALIGN_LEFT;
                doc.Add(khachhang_name);
                //Line seperator
                doc.Add(line);
                //Thanks 
                Paragraph thanks = new(new Chunk("Thanks for purchasing at our shop !!!"));
                thanks.Alignment = Element.ALIGN_CENTER;
                doc.Add(thanks);
                doc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : "+ex.Message);
                return false;
            }
            return true;
        }
        private string RemoveDiacritics(string text)
        {
            string normalizedString = text.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
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
                    worksheet.Columns.AutoFit();
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
