using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
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
