using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHelper
{
    /// <summary>
    /// 用于生成 SqlHelper 的类
    /// </summary>
    public static class SqlHelperCreator
    {
        /// <summary>
        /// 根据提供的 sqlInfo 生成一个连接数据库的 ISqlHelper
        /// </summary>
        /// <param name="sqlInfo"></param>
        /// <returns></returns>
        public static ISqlHelper Create(SqlInfo sqlInfo)
        {
            switch(sqlInfo.SqlType)
            {
                case SqlType.MSSQL:return new MsSqlHelper(sqlInfo);
                case SqlType.MYSQL:return new MySqlHelper(sqlInfo);
                default: return new MySqlHelper(sqlInfo);
            }
        }
    }
}
