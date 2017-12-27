using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using Utility;

namespace DAL
{
    public class ReturnInfo
    {
        public static void changeBorrowRecord(string circuBookNo)
        {
            string sql = "update borrowRecord set returnTime=GETDATE() where circuBookNo=@circuBookNo and returnTime is null";
            SqlParameter para = new SqlParameter("@circuBookNo", circuBookNo);
            SQLHelper.Update(sql, para);
        }
    }
}
