using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Utility;

namespace DAL
{
    public class LibraryCardIfo
    {
        public static LibraryCard QueryLibraryCardIfo(string LibraryCardID)
        {
            string sql = "SELECT * FROM libraryCard WHERE  libraryCardID= @libraryCardID";
            SqlParameter para = new SqlParameter("@libraryCardID", LibraryCardID);
            SQLHelper.CoverToObject cto = new SQLHelper.CoverToObject(ReaderToBorrowRecordClass);
            var list = SQLHelper.Query(sql, cto, para);

            LibraryCard cardInfo = list[0] as LibraryCard;

            return cardInfo;
        }


        private static LibraryCard ReaderToBorrowRecordClass(SqlDataReader reader)
        {
            int libraryCardID = reader.GetInt32(reader.GetOrdinal("libraryCardID"));
            int typeID = reader.GetInt16(reader.GetOrdinal("typeID"));
            string name = reader.GetString(reader.GetOrdinal("name"));
            string sex = reader.GetString(reader.GetOrdinal("sex"));
            string ID = reader.GetString(reader.GetOrdinal("ID"));
            DateTime regTime = reader.GetDateTime(reader.GetOrdinal("regTime"));
            DateTime dueTime = reader.GetDateTime(reader.GetOrdinal("dueTime"));
            return new LibraryCard(libraryCardID,typeID,name, sex,ID,regTime,dueTime);
        }
    }
}
