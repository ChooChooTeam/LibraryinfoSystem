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
                LibraryCard card = LibraryCardIfo.queryLibraryCardIfo(libraryCardID);
                return card;
            }
            catch (Exception)
            {
                
                throw;
            }
            

        }
    }
}
