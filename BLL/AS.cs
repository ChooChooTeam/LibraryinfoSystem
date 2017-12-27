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
            static public bool HaveLibraryCard(String libraryCardID) {
            ;
            try
            {
                 BorrowWinAS.GetLibraryCardIdInfo(libraryCardID);

            }
            catch (System.ArgumentOutOfRangeException)
            {
                

                return false;
            }
            return true;
        }
        public static bool BookBorrowAble(String circuBookNo)
        {
            try { 
            String sql = "select * from borrowRecord where circuBookNo=@circuBookNo and returnTime is NULL; ";
            SqlParameter para = new SqlParameter("@circuBookNo", circuBookNo);
            SQLHelper.getDataTable(sql, para);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return true;
            }
            return false;
        }

    }
}
