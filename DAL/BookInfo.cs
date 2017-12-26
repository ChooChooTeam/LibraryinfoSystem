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
        public static CircuBookClass queryBookInfo(string circuBookNo)
        {
            string sql = "select bookName,publishingHouse from circuBookClass, circuBook where circuBook.isbn = circuBookClass.isbn and circuBook.circuBookNo = @circuBookNo";
            SqlParameter para = new SqlParameter("@circuBookNo", circuBookNo);
            SQLHelper.CoverToObject cto = new SQLHelper.CoverToObject(ReaderToBkPH);
            var list = SQLHelper.Query(sql, cto,para);

            CircuBookClass cBookc = list[0] as CircuBookClass;

            return cBookc;   
        }

        public static List<object> queryABookInfo(string circuBookNo)
        {
            // 注意连接字符串之间的空格
            string sql = "SELECT circuBook.isbn,bookName" + 
                " FROM circuBook JOIN circuBookClass ON (circuBook.isbn = circuBookClass.isbn)"+
                " WHERE circuBookNo = @cNo";
            SqlParameter para = new SqlParameter("@cNo", circuBookNo);

            SQLHelper.CoverToList ctl = new SQLHelper.CoverToList(ReaderToBookInfo);

            var list = SQLHelper.Query(sql, ctl, para);
            
            return list[0];
        }


        private static CircuBookClass ReaderToCircuBookClass(SqlDataReader reader)
        {
            string isbn = reader.GetString(reader.GetOrdinal("isbn"));
            string bookName = reader.GetString(reader.GetOrdinal("bookName"));
            string mainAuthor = reader.GetString(reader.GetOrdinal("mainAuthor"));
            string otherAuthor = reader.GetString(reader.GetOrdinal("otherAuthor"));
            DateTime publicationYear = reader.GetDateTime(reader.GetOrdinal("publicationYear"));
            string publishingHouse = reader.GetString(reader.GetOrdinal("publishingHouse"));
            decimal price = reader.GetDecimal(reader.GetOrdinal("price"));
            int bookNum = reader.GetInt16(reader.GetOrdinal("bookNum"));
            return new CircuBookClass(isbn, bookName, mainAuthor, otherAuthor, publicationYear, publishingHouse, price, bookNum);
        }
        private static CircuBookClass ReaderToBkPH(SqlDataReader reader)
        {
            string publishingHouse = reader.GetString(reader.GetOrdinal("publishingHouse"));
            string bookName = reader.GetString(reader.GetOrdinal("bookName"));
            //return new CircuBookClass(null, bookName, null, null, null, publishingHouse, null, null);
            return new CircuBookClass(bookName, publishingHouse);
        }

        private static List<object> ReaderToBookInfo(SqlDataReader reader)
        {
            string isbn = reader.GetString(reader.GetOrdinal("isbn"));
            string bookName = reader.GetString(reader.GetOrdinal("bookName"));

            List<object> list = new List<object>();
            list.Add(isbn);
            list.Add(bookName);

            return list;
        }
    }
}
