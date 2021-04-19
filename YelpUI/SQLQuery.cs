﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace YelpUI
{
    public abstract class SQLQueries
    {

        private static string connectionString = "Host = localhost; Username = postgres; Database = yelpdb; password = postgres";
        private static string attributeQuery = "Select distinct b.business_id " +
                                            "From business b, businessattributes ba " +
                                            "WHERE ba.business_id IN (";

        public static string AttributeQuery { get { return attributeQuery; } }
        public string ConnectionString { get { return connectionString; } }

        public static void executeQuery(string sqlstr, Action<NpgsqlDataReader> myf)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = sqlstr;
                    try
                    {
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            myf(reader);
                        }
                    }
                    catch (NpgsqlException nex)
                    {
                        MessageBox.Show("SQL Error - " + nex.Message.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public static string CreateBaseSelectQuery(string args, string tables, string conditions)
        {
            StringBuilder sqlQuery = new StringBuilder();

            if (args != null && tables != null)
            {
                sqlQuery.Append("SELECT DISTINCT ");
                sqlQuery.Append(args);

                sqlQuery.Append(" FROM ");
                sqlQuery.Append(tables);

                if (conditions != null)
                {
                    sqlQuery.Append(" WHERE ");
                    sqlQuery.Append(conditions);
                }

            }
            return sqlQuery.ToString();
        }

        public static StringBuilder AddAttribute(StringBuilder query, string attribute, string attributeValue)
        {
            query.Insert(0, SQLQueries.AttributeQuery, 1);
            query.Append(") and b.business_id = ba.business_id and attribute_name = '");
            query.Append(attribute + "' and attribute_value = '" + attributeValue + "'");
            return query;
        }
    }
}
