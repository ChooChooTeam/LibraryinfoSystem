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
    public class ReaderTypeInfo
    {

        public static ReaderType QueryReaderTypeInfo(int typeID)
        {
            string sql = "SELECT * FROM ReaderType WHERE  typeID= @typeID";
            SqlParameter para = new SqlParameter("@typeID", typeID.ToString());
            SQLHelper.CoverToObject cto = new SQLHelper.CoverToObject(ReaderToBorrowRecordClass);
            var list = SQLHelper.Query(sql, cto, para);

            ReaderType Info = list[0] as ReaderType;

            return Info;
        }


        private static ReaderType ReaderToBorrowRecordClass(SqlDataReader ReaderType)
        {
            int typeID = ReaderType.GetInt16(ReaderType.GetOrdinal("typeID"));
            string typeName = ReaderType.GetString(ReaderType.GetOrdinal("typeName"));
            int borrowDuration = ReaderType.GetInt32(ReaderType.GetOrdinal("borrowDuration"));
            int reBorrowNum = ReaderType.GetInt16(ReaderType.GetOrdinal("reBorrowNum"));
            return new ReaderType(typeID, typeName, borrowDuration, reBorrowNum);
        }
    }
}
