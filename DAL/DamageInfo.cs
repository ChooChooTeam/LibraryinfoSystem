using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Utility;
using System.Data.SqlClient;
namespace DAL
{
    public class DamageInfo
    {
        public static List<DamageReason> getAllReason()
        {
            string sql = "SELECT * FROM damageReason";
            SQLHelper.CoverToObject cto = new SQLHelper.CoverToObject(ReaderToDamageReason);

            var objList = SQLHelper.Query(sql, cto);

            List<DamageReason> list = new List<DamageReason>();
            foreach(var i in objList)
            {
                list.Add(i as DamageReason);
            }

            return list;
        }

        public static DamageReason ReaderToDamageReason(SqlDataReader reader)
        {
            // 注意
            int index = reader.GetInt16(reader.GetOrdinal("damgeReasonIndex"));
            string damageExplain = reader.GetString(reader.GetOrdinal("damageExplain"));

            return new DamageReason(index, damageExplain);

        }


    }
}
