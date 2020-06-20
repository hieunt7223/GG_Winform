using GG.Common;
using GG.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace GG.Repository
{
    public class ADConfigColumnsRepository
    {
        /// <summary>
        /// Lấy dữ liệu theo table name
        /// </summary>
        /// <param name="strTableName"></param>
        /// <returns></returns>
        public static List<ADConfigColumns> GetDataConfigColumnsByTableName(string strTableName)
        {
            ContextDb _context = new ContextDb();
            var list = (from c in _context.ADConfigColumns
                        where c.AAStatus == Status.Alive.ToString() && c.ADConfigColumnTableName == strTableName
                        select c);
            return list.ToList();
        }

        /// <summary>
        /// Lấy dữ liệu theo table name
        /// </summary>
        /// <param name="strTableName"></param>
        /// <returns></returns>
        public static List<ADConfigColumns> GetAllData()
        {
            ContextDb _context = new ContextDb();
            var list = (from c in _context.ADConfigColumns
                        where c.AAStatus == Status.Alive.ToString()
                        select c);
            return list.ToList();
        }

        /// <summary>
        /// Lấy dữ liệu theo điều kiện lọc
        /// </summary>
        /// <param name="DisplayMember"></param>
        /// <param name="ValueMember"></param>
        /// <param name="table"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static DataTable SelectValueBySQLQueryString(string DisplayMember, string ValueMember, string table, string filter)
        {
            DataTable dt = new DataTable();
            string sqlstring = string.Empty;
            string value = ValueMember.ToString() + "," + DisplayMember.Replace(";", ",").ToString();
            if (!string.IsNullOrWhiteSpace(filter))
            {
                sqlstring = string.Format("SELECT {0} FROM {1} WHERE {2}", value, table.ToString(), filter);
            }
            else
            {
                sqlstring = string.Format("SELECT {0} FROM {1} ", value, table.ToString());
            }
            dt = GGRepository.SelectByQuerySQL(sqlstring);
            return dt;
        }
    }
}
