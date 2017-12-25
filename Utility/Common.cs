using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    class Common
    {
        /// <summary>
        /// 获得数据库配置信息,默认位于当前主项目的App.config中
        /// </summary>
        /// <returns>
        /// 数据库连接参数的字符串
        /// </returns>
        public static string getSqlConStr()
        {
            // 需要在引用中导入System.configuration
            return System.Configuration.ConfigurationManager.AppSettings["sqlServConn"];
        }
    }
}
