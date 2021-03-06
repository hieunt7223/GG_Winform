﻿using GG.Entity;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace GG.Repository
{
    public class GGRepository
    {
        /// <summary>
        /// Lấy dữ liệu theo query SQL
        /// </summary>
        /// <param name="strTableName"></param>
        /// <returns></returns>
        public static DataTable SelectByQuerySQL(string querySQL)
        {
            var _context = new ContextDb();

            var table = new DataTable();
            var cmd = _context.Database.GetDbConnection().CreateCommand();

            cmd.CommandText = querySQL;
            cmd.Connection.Open();
            table.Load(cmd.ExecuteReader());
            cmd.Connection.Close();

            return table;
        }

    }
}
