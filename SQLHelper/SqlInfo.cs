using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHelper
{
    public enum SqlType { MSSQL,MYSQL}

    public class SqlInfo
    {
        SqlType _sqlType;
        string server;
        string userId;
        string password;
        string database;
        int port;

        public SqlInfo(SqlType sqlType)
        {
            _sqlType = sqlType;
        }

        public string Server
        {
            get
            {
                return server;
            }

            set
            {
                server = value;
            }
        }

        public string UserId
        {
            get
            {
                return userId;
            }

            set
            {
                userId = value;
            }
        }

        public string Password { get { return password; } set { password = value; } }

        public string Database
        {
            get
            {
                return database;
            }

            set
            {
                database = value;
            }
        }

        public int Port
        {
            get
            {
                return port;
            }

            set
            {
                port = value;
            }
        }

        public SqlType SqlType
        {
            get
            {
                return _sqlType;
            }

            set
            {
                _sqlType = value;
            }
        }
    }
}
