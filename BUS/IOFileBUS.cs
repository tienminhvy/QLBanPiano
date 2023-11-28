using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using QLBanPiano.DAL;
using System.Data.SqlClient;

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
    }
}
