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
    class SQLHelper
    {
        private static string sqlInfo = Common.getSqlConStr();

        

        /// <summary>
        /// 连接数据库并执行一条查询指令,返回查询数据的游标
        /// </summary>
        /// <param name="sql">待执行的SQL指令</param>
        /// <param name="param">SQL中的参数</param>
        /// <returns>执行成功,返回相应的数据游标,否则返回null数据库游标</returns>
        /// 注意
        /// 1. 此函数返回的游标需要手动释放
        /// 2. 使用前需要先调用Read()一次
        private static SqlDataReader query(string sql,params SqlParameter[] param)
        {
            SqlConnection conn = null;
            SqlDataReader sdr = null;

            try
            {
                conn = new SqlConnection(sqlInfo);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddRange(param);
                sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    return sdr;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (conn!= null)
                {
                    conn.Dispose();
                }
            }
        }



    }
}
