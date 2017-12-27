using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data.SqlClient;
using Utility;

namespace BLL
{
    public class BorrowWinAS
    {

        public static DataSet GetUserHavingBook(String libraryCardID) {
            return null;
        }
        public static LibraryCard GetLibraryCardIdInfo(String libraryCardID) {

                LibraryCard card = LibraryCardIfo.QueryLibraryCardIfo(libraryCardID);
                return card;
 

        }
        public static bool GetUserHaveMoneyToPay(String libraryCardID) {
            DataTable dataTable;
            string sql = "select damageRecord.damageIndex,damageReason.damageExplain,circuBookClass.bookName,damageRecord.damageTime,damageRecord.damageMoney " +
                   "from damageRecord join(circuBook join circuBookClass on circuBook.isbn = circuBookClass.isbn)on damageRecord.circuBookNo = circuBook.circuBookNo " +
                   "join damageReason on damageReason.damageReasonIndex = damageRecord.damageReasonIndex " +
                   "where damageRecord.damageRtnTIme is NULL and damageRecord.libraryCardID = @libraryCardID";
            SqlParameter para = new SqlParameter("@libraryCardID", libraryCardID);

            dataTable = SQLHelper.getDataTable(sql, para);
            //dataTable.
            if (dataTable.Rows.Count == 0)
            {
                return false;
            }
            return true;

        }
       
        public static ReaderType GetreaderTypeInfo(int typeID)
        {

                ReaderType readerType = ReaderTypeInfo.QueryReaderTypeInfo(typeID);
                return readerType;

        }
    
        //  public static CircuBookClass GetCircuBookInfo(String circuBookNo) {
        //     CircuBookClass book = BookInfo.queryBookInfo(circuBookNo);
        // }
       
    }
}
