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
    public class ReaderInfo
    {
        public static Reader QueryReaderInfo(string LibraryCardID)
        {
            string sql = "SELECT * FROM Reader WHERE  libraryCardID= @libraryCardID";
            SqlParameter para = new SqlParameter("@libraryCardID", LibraryCardID);
            SQLHelper.CoverToObject cto = new SQLHelper.CoverToObject(ReaderToBorrowRecordClass);
            var list = SQLHelper.Query(sql, cto, para);

            Reader cardInfo = list[0] as Reader;

            return cardInfo;
        }


        private static Reader ReaderToBorrowRecordClass(SqlDataReader Reader)
        {
            string ID = Reader.GetString(Reader.GetOrdinal("ID"));
            int libraryCardID = Reader.GetInt32(Reader.GetOrdinal("libraryCardID"));
            int typeID = Reader.GetInt16(Reader.GetOrdinal("typeID"));
            string sex = Reader.GetString(Reader.GetOrdinal("sex"));
            return new Reader(ID, libraryCardID, typeID, sex);
        }
    }

}
