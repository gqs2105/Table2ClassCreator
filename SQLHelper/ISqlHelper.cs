using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SQLHelper
{
    public interface ISqlHelper
    {
        /// <summary>
        /// 测试连接是否正常
        /// </summary>
        /// <returns></returns>
        bool TestConnection();
        /// <summary>
        /// 对连接执行 Transcat-SQL 并返回受影响的行数.
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns></returns>
        int ExecuteNonQuery(string cmdText);

        DataTable ExecuteDataTable(string cmdText);
    }
}
