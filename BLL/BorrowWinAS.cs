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
            try
            {
                LibraryCard card = LibraryCardIfo.QueryLibraryCardIfo(libraryCardID);
                return card;
            }
            catch (Exception)
            {
                
                throw;
            }
           

            

        }
        public static Reader GetreaderInfo(String libraryCardID)
        {
            try
            {
                Reader reader = ReaderInfo.QueryReaderInfo(libraryCardID);
                return reader;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static ReaderType GetreaderTypeInfo(int typeID)
        {
            try
            {
                ReaderType readerType = ReaderTypeInfo.QueryReaderTypeInfo(typeID);
                return readerType;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
