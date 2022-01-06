using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Models;
using NpgsqlTypes;
using Npgsql;
using System.Data;
using System.Text;

namespace GoWMS.Server.Data
{
    public class AdminDAL
    {
        readonly private string connectionString = ConnGlobals.GetConnLocalDBPG();

        public IEnumerable<Current_role> GetPageRole(string pageid, Int64 groupid)
        {
            List<Current_role> lstobj = new List<Current_role>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
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
                con.Open();
                cmd.Parameters.AddWithValue("@menu_desc", NpgsqlDbType.Varchar, pageid);
                cmd.Parameters.AddWithValue("@group_id", NpgsqlDbType.Bigint, groupid);
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Current_role objrd = new Current_role
                    {
                        Role_acc = rdr["role_acc"] == DBNull.Value ? null : (Boolean?)rdr["role_acc"],
                        Role_add = rdr["role_add"] == DBNull.Value ? null : (Boolean?)rdr["role_add"],
                        Role_edit = rdr["role_edit"] == DBNull.Value ? null : (Boolean?)rdr["role_edit"],
                        Role_del = rdr["role_del"] == DBNull.Value ? null : (Boolean?)rdr["role_del"],
                        Role_rpt = rdr["role_rpt"] == DBNull.Value ? null : (Boolean?)rdr["role_rpt"],
                        Role_apv = rdr["role_apv"] == DBNull.Value ? null : (Boolean?)rdr["role_apv"]
                    };
                    lstobj.Add(objrd);
                }
                con.Close();
            }
            return lstobj;
        }

        public Boolean InsertMenu(String mnuName  , String mundesc)
        {
            Boolean bRet = false;
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder sqlQurey = new StringBuilder();
                sqlQurey.AppendLine("Insert into public.set_menu");
                sqlQurey.AppendLine("(menu_code, menu_desc, modified)");
                sqlQurey.AppendLine("Values (@menu_code, @menu_desc, current_timestamp)");
                sqlQurey.AppendLine("on conflict (menu_code)");
                sqlQurey.AppendLine("do");
                sqlQurey.AppendLine("Update");
                sqlQurey.AppendLine("Set menu_desc = @menu_desc1");
                sqlQurey.AppendLine(", modified = current_timestamp");
                sqlQurey.AppendLine(";");
                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlQurey.ToString(), con)
                    {
                        CommandType = CommandType.Text
                    };
                    con.Open();
                    cmd.Parameters.AddWithValue("@menu_code", NpgsqlDbType.Varchar, mnuName);
                    cmd.Parameters.AddWithValue("@menu_desc", NpgsqlDbType.Varchar, mundesc);
                    cmd.Parameters.AddWithValue("@menu_desc1", NpgsqlDbType.Varchar, mundesc);
                    cmd.ExecuteNonQuery();
                    bRet = true;
                }
                catch (NpgsqlException exp)
                {

                }
                finally
                {
                    con.Close();
                }
            }
            return bRet;
        }

        public Boolean InsertPrivilege(String mnuName)
        {
            Boolean bRet = false;
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder sqlQurey = new StringBuilder();
                sqlQurey.AppendLine("Insert into public.set_privilege");
                sqlQurey.AppendLine("(group_id,menu_id)");
                sqlQurey.AppendLine("SELECT idx as group_id , menu_code as menu_id  FROM public.vmenu_group");
                sqlQurey.AppendLine("WHERE menu_code = @menu_code");
                sqlQurey.AppendLine("on conflict (group_id, menu_id)");
                sqlQurey.AppendLine("do");
                sqlQurey.AppendLine("update");
                sqlQurey.AppendLine(" Set menu_id = @menu_id");
                sqlQurey.AppendLine(";");
                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlQurey.ToString(), con)
                    {
                        CommandType = CommandType.Text
                    };
                    con.Open();
                    cmd.Parameters.AddWithValue("@menu_code", NpgsqlDbType.Varchar, mnuName);
                    cmd.Parameters.AddWithValue("@menu_id", NpgsqlDbType.Varchar, mnuName);
                    cmd.ExecuteNonQuery();
                    bRet = true;
                }
                catch (NpgsqlException exp)
                {

                } 
                finally
                {
                    con.Close();
                }
            }
            return bRet;
        }

        public Boolean IntialCreatePrivilege(Int64 iGrp)
        {
            Boolean bRet = false;
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder sqlQurey = new StringBuilder();
                sqlQurey.AppendLine("INSERT INTO  public.set_role (group_id, menu_id)");
                sqlQurey.AppendLine("SELECT @group_id , idx from public.set_menu");
                sqlQurey.AppendLine("WHERE NOT EXISTS");
                sqlQurey.AppendLine("(SELECT 1 FROM public.set_role WHERE set_role.group_id = @group_id1 and  set_role.menu_id=set_menu.idx)");
                sqlQurey.AppendLine(";");
                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlQurey.ToString(), con)
                    {
                        CommandType = CommandType.Text
                    };
                    con.Open();
                    cmd.Parameters.AddWithValue("@group_id", NpgsqlDbType.Bigint, iGrp);
                    cmd.Parameters.AddWithValue("@group_id1", NpgsqlDbType.Bigint, iGrp);
                    cmd.ExecuteNonQuery();
                    bRet = true;
                }
                catch (NpgsqlException exp)
                {

                }
                finally
                {
                    con.Close();
                }
            }
            return bRet;
        }

        public Boolean InsertAudittrial(String actdescen, String actdesclocal, String munname  , String ipaddress , Int64 iuser)
        {
            Boolean bRet = false;
            string ipadd ="";
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder sqlQurey = new StringBuilder();
                sqlQurey.AppendLine("insert into public.rpt_audittrial");
                sqlQurey.AppendLine("(client_id, client_ip, id_stuser, menu_name, action_desc)");
                sqlQurey.AppendLine("Values (@client_id, @client_ip, @id_stuser, @menu_name, @action_desc)");
                sqlQurey.AppendLine(";");
                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlQurey.ToString(), con)
                    {
                        CommandType = CommandType.Text
                    };
                    con.Open();
                    cmd.Parameters.AddWithValue("@client_id", NpgsqlDbType.Bigint, iuser);
                    cmd.Parameters.AddWithValue("@client_ip", NpgsqlDbType.Varchar, ipadd);
                    cmd.Parameters.AddWithValue("@id_stuser", NpgsqlDbType.Bigint, iuser);
                    cmd.Parameters.AddWithValue("@menu_name", NpgsqlDbType.Varchar, munname);
                    cmd.Parameters.AddWithValue("@action_desc", NpgsqlDbType.Varchar, actdesclocal);
                    cmd.ExecuteNonQuery();
                    bRet = true;
                }
                catch (NpgsqlException exp)
                {

                }
                finally
                {
                    con.Close();
                }
            }
            return bRet;
        }
    }
}
