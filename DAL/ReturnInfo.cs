using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using Utility;

namespace DAL
{
    public class ReturnInfo
    {
        public static void changeBorrowRecord(string circuBookNo)
        {
            string sql = "update borrowRecord set returnTime=GETDATE() where circuBookNo=@circuBookNo and returnTime is null";
            SqlParameter para = new SqlParameter("@circuBookNo", circuBookNo);
            SQLHelper.Update(sql, para);
        }

        public static int getOverDueDay(string circuBookNo)
        {
            string sql = "select datediff(DAY,GETDATE(),borrowRecord.dateToReturn)as atime from borrowRecord where circuBookNo=@circuBookNo and returnTime is null";
            SqlParameter para = new SqlParameter("@circuBookNo", circuBookNo);
            SQLHelper.CoverToObject cto = new SQLHelper.CoverToObject(ReaderToOverDue);
            var list = SQLHelper.Query(sql, cto, para);

            int overDueDay = (int)list[0];
            return overDueDay;

        }

        public static object ReaderToOverDue(SqlDataReader reader)
        {
            int overDueDay = reader.GetInt32(reader.GetOrdinal("atime"));
            return overDueDay;
        }

        public static decimal getPrice(string circuBookNo)
        {
            string sql = "select price from circuBookClass,circuBook where circuBook.isbn=circuBookClass.isbn and circuBook.circuBookNo=@circuBookNo";
            SqlParameter para = new SqlParameter("@circuBookNo", circuBookNo);
            SQLHelper.CoverToObject cto = new SQLHelper.CoverToObject(ReaderToPrice);
            var list = SQLHelper.Query(sql, cto, para);

            decimal price = (decimal)list[0];
            return price;
        }

        public static object ReaderToPrice(SqlDataReader reader)
        {
            decimal price = reader.GetDecimal(reader.GetOrdinal("price"));
            return price;
        }
    }
}
