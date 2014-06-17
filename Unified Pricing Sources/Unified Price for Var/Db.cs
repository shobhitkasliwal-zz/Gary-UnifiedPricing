using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Unified_Price_for_Var
{
    public static class Db
    {
        public static string _connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(Application.StartupPath, "UnifiedPricingDB.accdb") + ";Persist Security Info=False;";
      
        public static System.Data.DataTable ExecuteDataTable(string query)
        {
            using (var connection = new OleDbConnection(_connectionString))
            {
                OleDbCommand command = connection.CreateCommand();
                command.CommandText = query;

                //try
                {
                    connection.Open();                    

                    var dt = new System.Data.DataTable();
                    dt.Load(command.ExecuteReader());
                    
                    connection.Close();
                    command.Dispose();

                    return dt;
                }
                /*catch (Exception ex)
                {
                    Log.Exception(ex);
                    return null;
                }*/
            }            
        }

        public static System.Data.DataTable ExecuteDataTable(string format, params object[] args)
        {
            return ExecuteDataTable(string.Format(format, args));
        }

        public static void NonQuery(string query)
        {
            using (var connection = new OleDbConnection(_connectionString))
            {
                OleDbCommand command = connection.CreateCommand();
                command.CommandText = query;

                //try
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                    command.Dispose();
                }
                /*catch (Exception ex)
                {
                    Log.Exception(ex);                    
                }*/
            }
        }

        /// <summary>
        /// Returns a string with backslashes before characters that need to be quoted
        /// </summary>
        /// <param name="InputTxt">Text string need to be escape with slashes</param>
        public static string AddSlashes(string InputTxt)
        {

            return InputTxt.Replace("'", "''");
        }

        public static object ExecuteScalar(string format, params object[] args)
        {
            return ExecuteScalar(string.Format(format, args));
        }

        public static object ExecuteScalar(string query)
        {
            using (var connection = new OleDbConnection(_connectionString))
            {
                OleDbCommand command = connection.CreateCommand();
                command.CommandText = query;

                //try
                {
                    connection.Open();

                    return command.ExecuteScalar();

                    connection.Close();
                    command.Dispose();
                }
                /*catch (Exception ex)
                {
                    Log.Exception(ex);                    
                }*/
            }
        }

        public static void NonQuery(string format, params object[] args)
        {
            NonQuery(string.Format(format, args));
        }

        public static DataRow ExecuteDataRow(string query)
        {
            using (var connection = new OleDbConnection(_connectionString))
            {
                OleDbCommand command = connection.CreateCommand();
                command.CommandText = query;

                try
                {
                    connection.Open();

                    var dt = new System.Data.DataTable();
                    dt.Load(command.ExecuteReader());

                    connection.Close();
                    command.Dispose();

                    if(dt.Rows.Count > 0)
                        return dt.Rows[0];
                    return null;
                }
                catch (Exception ex)
                {
                    Log.Exception(ex);
                    return null;
                }
            }
        }

        public static DataRow ExecuteDataRow(string format, params object[] args)
        {
            return ExecuteDataRow(string.Format(format, args));
        }
    }
}
