using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Threading.Tasks;

namespace Utility
{
    public class SQLHelper
    {
        private static string sqlInfo = Common.getSqlConStr();

        public delegate object CoverToObject(SqlDataReader reader);
        public delegate List<object> CoverToList(SqlDataReader reader);
       

        public static List<object> testDB()
        {
           return Query("SELECT * FROM circuBookClass", (reader) => { return reader["bookName"]; });
        }

        /// <summary>
        /// 连接数据库并执行一条查询指令,返回查询数据的列表
        /// </summary>
        /// <param name="sql">待执行的SQL指令</param>
        /// <param name="toStr">将DataReader转化为Object的函数</param>
        /// <param name="param">SQL指令中的参数</param>
        /// <returns>包含指定数据的列表</returns>
        public static List<object> Query(string sql,CoverToObject toObject,params SqlParameter[] param)
        {
            List<object> list = new List<object>();
            using (SqlConnection conn = new SqlConnection(sqlInfo))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                if (param.Length != 0)
                {
                    cmd.Parameters.AddRange(param);
                }

                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.HasRows && sdr.Read())
                    {
                        list.Add(toObject(sdr));
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// 连接数据库并执行一条查询指令,返回查询数据的列表(每一列包含多个数据)
        /// </summary>
        /// <param name="sql">待执行的SQL指令</param>
        /// <param name="toList">将DataReader转化为List的函数</param>
        /// <param name="param">SQL指令中的参数</param>
        /// <returns>包含指定数据的列表(每列包含多个数据)</returns>
        public static List<List<object>> Query(string sql, CoverToList toList, params SqlParameter[] param)
        {
            List<List<object>> list = new List<List<object>>();
            using (SqlConnection conn = new SqlConnection(sqlInfo))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                if (param.Length != 0)
                {
                    cmd.Parameters.AddRange(param);
                }

                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.HasRows && sdr.Read())
                    {
                        list.Add(toList(sdr));
                    }
                }
            }

            return list;
        }



    }
}
