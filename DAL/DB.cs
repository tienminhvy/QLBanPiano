using QLBanPiano.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLBanPiano.DAL
{
    class DB
    {
        SqlConnection sqlConn; //Doi tuong ket noi CSDL
        SqlDataAdapter da;//Bo dieu phoi du lieu
        DataSet ds; //Doi tuong chhua CSDL khi giao tiep
        public DB()
        {
            string server = "DESKTOP-VYTM\\VYTM_NEW";
            string strCnn = "Data Source=" + server + "; Database=qlbanpiano;User ID=sa;Password=";
            //string server = "LAPTOP-52VVCVMC";
            // string strCnn = "Data Source=" + server + "; Database=qlbanpiano;User ID=sa;Password=210703";
            sqlConn = new SqlConnection(strCnn);
        }
        //Phuong thuc de thuc hien cau lenh strSQL truy vân du lieu
        public int ExecuteScalar(string tableName, string colum)
        {
            try
            {
                string sqlString = string.Format("select max({1}) \r\nfrom {0}", tableName, colum);
                SqlCommand sqlcmd = new(sqlString, sqlConn);
                sqlConn.Open(); //Mo ket noi
                int count = (int)sqlcmd.ExecuteScalar();//Lenh hien lenh Them/Xoa/Sua
                sqlConn.Close();//Dong ket noi
                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nội dung: " + ex.Message, "Xảy ra lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public DataTable Execute(string sqlStr)
        {
            try
            {
                da = new SqlDataAdapter(sqlStr, sqlConn);
                ds = new DataSet();
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nội dung: " + ex.Message, "Xảy ra lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConn.Close();
                return null;
            }
            return ds.Tables[0];
        }
        //Phuong thuc de thuc hien cac lenh Them, Xoa, Sua
        public void ExecuteNonQuery(string strSQL)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
                sqlConn.Open(); //Mo ket noi
                sqlcmd.ExecuteNonQuery();//Lenh hien lenh Them/Xoa/Sua
                sqlConn.Close();//Dong ket noi
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nội dung: " + ex.Message, "Xảy ra lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConn.Close();
            }
        }

        public int GetCount(string tableName, string condition)
        {
            try
            {
                string sqlString = string.Format("select count(*) from {0} " +
                "where {1}", tableName, condition);
                SqlCommand sqlcmd = new SqlCommand(sqlString, sqlConn);
                sqlConn.Open(); //Mo ket noi
                int count = (int)sqlcmd.ExecuteScalar();//Lenh hien lenh Them/Xoa/Sua
                sqlConn.Close();//Dong ket noi
                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nội dung: " + ex.Message, "Xảy ra lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConn.Close();
                return -1;
            }
        }

        public object GetColumn(string tableName, string column, string condition)
        {
            try
            {
                string sqlString = string.Format("select {0} from {1} " + "where {2}",
                column, tableName, condition);
                SqlCommand sqlcmd = new SqlCommand(sqlString, sqlConn);
                sqlConn.Open(); //Mo ket noi
                object result = sqlcmd.ExecuteScalar(); // Lenh hien lenh Them/Xoa/Sua
                sqlConn.Close();//Dong ket noi
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nội dung: " + ex.Message, "Xảy ra lỗi",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConn.Close();
                return null;
            }
        }
        /// <summary>
        /// Phải có output INSERTED.ID!!!
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        public int Insert(string sqlString)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand(sqlString, sqlConn);
                sqlConn.Open(); //Mo ket noi
                int result = (int)sqlcmd.ExecuteScalar(); // Lenh hien lenh Them/Xoa/Sua
                sqlConn.Close();//Dong ket noi
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nội dung: " + ex.Message, "Xảy ra lỗi",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConn.Close();
                return -1;
            }
        }
    }
}
