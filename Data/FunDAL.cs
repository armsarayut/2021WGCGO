using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using GoWMS.Server.Controllers;
using GoWMS.Server.Models;
using GoWMS.Server.Models.Wcs;
using GoWMS.Server.DataAccess;
using Serilog;

namespace GoWMS.Server.Data
{
    public class FunDAL
    {
        readonly private string connectionString = ConnGlobals.GetConnLocalDBPG();

        public IEnumerable<FucCreateRunning> GetRunningList(string sCode, int iPad)
        {
            List<FucCreateRunning> lstobj = new List<FucCreateRunning>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine("SELECT _retchk, _retrunning FROM");
                    sql.AppendLine("public.fuc_create_running(");
                    sql.AppendLine("@_seqcode, @_pad)");

                    NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), con)
                    {
                        CommandType = CommandType.Text
                    };
                    con.Open();
                    cmd.Parameters.AddWithValue("@_seqcode", sCode);
                    cmd.Parameters.AddWithValue("@_pad", iPad);
                    NpgsqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        FucCreateRunning objrd = new FucCreateRunning
                        {

                            RetCheck = rdr["_retchk"] == DBNull.Value ? null : (int?)rdr["_retchk"],
                            Running = rdr["_retrunning"].ToString()
                        };
                        lstobj.Add(objrd);
                    }
                }
                catch (NpgsqlException ex)
                {
                    Log.Error(ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            return lstobj;
        }

        public string GetRunning(string sCode, int iPad)
        {
            List<FucCreateRunning> lstobj = new List<FucCreateRunning>();
            string sRunning = null;

            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine("SELECT _retchk, _retrunning FROM");
                    sql.AppendLine("public.fuc_create_running(");
                    sql.AppendLine("@_seqcode, @_pad)");

                    NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), con)
                    {
                        CommandType = CommandType.Text
                    };
                    con.Open();
                    cmd.Parameters.AddWithValue("@_seqcode", sCode);
                    cmd.Parameters.AddWithValue("@_pad", iPad);
                    NpgsqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        sRunning = rdr["_retrunning"].ToString();
                    }
                }
                catch (NpgsqlException ex)
                {
                    Log.Error(ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            return sRunning;
        }
    }
}
