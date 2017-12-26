using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Utility;
using System.Data.SqlClient;
namespace DAL
{
    public class BookInfo
    {
        public static CircuBookClass queryBookInfo(string ISBN)
        {
            string sql = "SELECT * FROM circuBookClass WHERE isbn = @isbn";
            SqlParameter para = new SqlParameter("@isbn", ISBN);
            SQLHelper.CoverToObject cto = new SQLHelper.CoverToObject(ReaderToCircuBookClass);
            var list = SQLHelper.Query(sql, cto,para);

            CircuBookClass cBookc = list[0] as CircuBookClass;

            return cBookc;   
        }


        private static CircuBookClass ReaderToCircuBookClass(SqlDataReader reader)
        {
            string isbn = reader.GetString(reader.GetOrdinal("isbn"));
            string bookName = reader.GetString(reader.GetOrdinal("bookName"));
            string mainAuthor = reader.GetString(reader.GetOrdinal("mainAuthor"));
            string otherAuthor = reader.GetString(reader.GetOrdinal("otherAuthor"));
            DateTime publicationYear = reader.GetDateTime(reader.GetOrdinal("publicationYear"));
            //string CDName = reader.GetString(reader.GetOrdinal("CDName"));
            decimal price = reader.GetDecimal(reader.GetOrdinal("price"));
            int bookNum = reader.GetInt16(reader.GetOrdinal("bookNum"));
            return new CircuBookClass(isbn, bookName, mainAuthor, otherAuthor, publicationYear, null, price, bookNum);
        }
    }
}
