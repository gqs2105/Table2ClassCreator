using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Table2ClassCreator
{
    public static class TableClassFileCreator
    {
        #region fields
        static string str = "using System;\r\n"
                          + "\r\n"
                          + "namespace Model\r\n"
                          + "{{\r\n"
                          + "    public class {0}\r\n"
                          + "    {{\r\n"
                          + "{1}"
                          + "    }}\r\n"
                          + "}}\r\n";
        static string strMebmerFunction = "        public string get{0}\r\n"
                                        + "        {{\r\n"
                                        + "            return \"{1}\";\r\n"
                                        + "        }}\r\n";
        static string strUpdateTeamplate = "UPDATE {0} SET {1}";
        static string strField = "", strAttr = "";
        #endregion
        public static string CreateString(DataTable dataTable)
        {
            string tableName = dataTable.TableName;
            string strSelectByColumnNameCmdText = "SELECT * FROM " + tableName + " ";
            string temp1 = "        {0} {1};\r\n";
            string temp2 = "        public {0} {1} {{ get {{ return {2}; }} set {{ {3} = value; }} }}\r\n";
            string strSetTemp = "{0} = `\" + {1} + \"`,";
            string strsetttttttttt = "";
            foreach (DataColumn dc in dataTable.Columns)
            {
                strField += string.Format(temp1, dc.DataType.Name, "_" + dc.ColumnName);
                strAttr += string.Format(temp2,
                    dc.DataType.Name,
                    dc.ColumnName,
                    "_" + dc.ColumnName,
                    "_" + dc.ColumnName);
                strsetttttttttt += string.Format(strSetTemp, dc.ColumnName, "_" + dc.ColumnName);
            }
            strsetttttttttt = strsetttttttttt.Substring(0, strsetttttttttt.Length - 1);
            //判断 DataTable 是否存在主键
            if (dataTable.PrimaryKey.Count() > 0)
            {
                var dc = from column in dataTable.PrimaryKey
                         where column.AutoIncrement
                         select column;
                DataColumn dtColumn;
                if (dc.Count() > 0)//判断所有主键中是否包含自动增长的主键
                {
                    dtColumn = dc.First();
                }
                else
                {
                    dtColumn = dataTable.PrimaryKey.First();
                }
                strsetttttttttt += string.Format(" WHERE {0} = \'{1}\';",
                    dtColumn.ColumnName,
                    "_"+dtColumn.ColumnName);
            }
            else
            {
                strsetttttttttt += " ;";
            }

            string UpdateString = string.Format(strMebmerFunction,
                "UpdateString",
                string.Format(strUpdateTeamplate,tableName,strsetttttttttt));

            return string.Format(str,tableName, strField + UpdateString + strAttr);      

        }
    }
}
