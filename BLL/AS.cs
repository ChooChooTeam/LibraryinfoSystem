using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
