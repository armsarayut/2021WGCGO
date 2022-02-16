using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Models;
using Npgsql;
using NpgsqlTypes;
using System.Text;
using System.Data;
using Serilog;


namespace GoWMS.Server.Data
{
    public class UserDAL
    {
        readonly private string connectionString = ConnGlobals.GetConnLocalDBPG();


        public IEnumerable<Userinfo> GetUser(string uusname , string uspass)
        {
            List<Userinfo> lstobj = new List<Userinfo>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                try
                {
                    StringBuilder sql = new StringBuilder();

                    sql.AppendLine("select u.idx, u.usid, u.usfirstname, u.uspass");
                    sql.AppendLine(", u.ugid");
                    sql.AppendLine("from public.set_users u");
                    sql.AppendLine("inner join public.set_usergroups g");
                    sql.AppendLine("on u.ugid=g.idx");
                    sql.AppendLine("where");
                    sql.AppendLine("u.usid=@usid");
                    sql.AppendLine("and");
                    sql.AppendLine("u.uspass=@uspass");
                    sql.AppendLine("Limit 1");
                    sql.AppendLine(";");

                    NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), con)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.AddWithValue("@usid", NpgsqlDbType.Varchar, uusname);
                    cmd.Parameters.AddWithValue("@uspass", NpgsqlDbType.Varchar, uspass);

                    con.Open();

                    NpgsqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Userinfo objrd = new Userinfo
                        {
                            Usid = rdr["idx"] == DBNull.Value ? null : (long?)rdr["idx"],
                            Usname = rdr["usfirstname"].ToString(),
                            Uspass = rdr["uspass"].ToString(),
                            Usgid = rdr["ugid"] == DBNull.Value ? null : (long?)rdr["ugid"],
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

        public IEnumerable<Userroleinfo> GetUserRole(string menu_desc, long group_id)
        {
            List<Userroleinfo> lstobj = new List<Userroleinfo>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                try
                {
                    StringBuilder sql = new StringBuilder();

                    sql.AppendLine("SELECT  role_acc, role_add, role_edit, role_del, role_rpt, role_apv");
                    sql.AppendLine("FROM public.vrole");
                    sql.AppendLine("WHERE menu_desc = @menu_desc");
                    sql.AppendLine("AND group_id = @group_id");
                    sql.AppendLine(";");


                    NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), con)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.AddWithValue("@menu_desc", NpgsqlDbType.Varchar, menu_desc);
                    cmd.Parameters.AddWithValue("@group_id", NpgsqlDbType.Bigint, group_id);

                    con.Open();

                    NpgsqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Userroleinfo objrd = new Userroleinfo
                        {
                            Role_acc = rdr["role_acc"] == DBNull.Value ? false : (bool?)rdr["role_acc"],
                            Role_add = rdr["role_add"] == DBNull.Value ? false : (bool?)rdr["role_add"],
                            Role_edit = rdr["role_edit"] == DBNull.Value ? false : (bool?)rdr["role_edit"],
                            Role_del = rdr["role_del"] == DBNull.Value ? false : (bool?)rdr["role_del"],
                            Role_rpt = rdr["role_rpt"] == DBNull.Value ? false : (bool?)rdr["role_rpt"],
                            Role_apv = rdr["role_apv"] == DBNull.Value ? false : (bool?)rdr["role_apv"],

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
    }
}
