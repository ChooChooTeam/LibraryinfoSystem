using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace BLL
{
    public class RetrunWinAS
    {
        public static CircuBookClass montorTextBox1Changed(string astring)
        {
            CircuBookClass cBookc;
            try
            {
                cBookc = DAL.BookInfo.queryBookInfo(astring);
            }
            catch(ArgumentOutOfRangeException)
            {
                cBookc = new CircuBookClass(null, null);
            }
            return cBookc;
        }

    }
}
