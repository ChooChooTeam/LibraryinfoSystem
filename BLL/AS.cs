using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace BLL
{
    public  class AS
    {
            static public LibraryCard HaveLibraryCard(String libraryCardID) {
            LibraryCard card;
            try
            {
                card=BorrowWinAS.GetLibraryCardIdInfo(libraryCardID);

            }
            catch (System.ArgumentOutOfRangeException)
            {
                

                return null;
            }
            return card;
        }
        public static bool BookBorrowAble(String circuBookNo)
        {
          
            String sql = "select * from borrowRecord where circuBookNo=@circuBookNo and returnTime is NULL; ";
            SqlParameter para = new SqlParameter("@circuBookNo", circuBookNo);
            if (SQLHelper.getDataTable(sql, para).Rows.Count > 0) {
                return false;
            }
            
            return true;
        }

    }
}
