using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Npgsql;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Controllers;
using GoWMS.Server.Models;
using GoWMS.Server.Models.Public;
using NpgsqlTypes;
using System.Text;

namespace GoWMS.Server.Data
{
    public class ReportDAL
    {
        readonly private string connectionString = ConnGlobals.GetConnLocalDBPG();

        public IEnumerable<Rpt_Audittrial> GetAllAudittrial()
        {
            List<Rpt_Audittrial> lstobj = new List<Rpt_Audittrial>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select * ");
                sql.AppendLine("from public.api_cylinder_go");
                sql.AppendLine("order by efidx");
                NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };
                con.Open();

                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Rpt_Audittrial objrd = new Rpt_Audittrial
                    {
                        Idx = rdr["efidx"] == DBNull.Value ? null : (Int64?)rdr["efidx"],
                        Entity_Lock = rdr["efstatus"] == DBNull.Value ? null : (Int32?)rdr["efstatus"],
                        Created = rdr["created"] == DBNull.Value ? null : (DateTime?)rdr["created"],
                        Modified = rdr["modified"] == DBNull.Value ? null : (DateTime?)rdr["modified"],
                        Client_Id = rdr["innovator"] == DBNull.Value ? null : (Int64?)rdr["innovator"],
                        Client_Ip = rdr["device"].ToString(),

                        //Material_Code = rdr["material_code"].ToString(),
                        //Material_Description = rdr["material_description"].ToString(),
                        //Customer_Code = rdr["customer_code"].ToString(),
                        //Customer_Description = rdr["customer_description"].ToString(),
                        //Customer_Reference = rdr["customer_reference"].ToString(),
                        //Color1 = rdr["color1"].ToString(),
                        //Cylinder1 = rdr["cylinder1"].ToString(),
                        //Color2 = rdr["color2"].ToString(),
                        //Cylinder2 = rdr["cylinder2"].ToString(),
                        //Color3 = rdr["color3"].ToString(),
                        //Cylinder3 = rdr["cylinder3"].ToString(),
                        //Color4 = rdr["color4"].ToString(),
                        //Cylinder4 = rdr["cylinder4"].ToString(),
                        //Color5 = rdr["color5"].ToString(),
                        //Cylinder5 = rdr["cylinder5"].ToString(),
                        //Color6 = rdr["color6"].ToString(),
                        //Cylinder6 = rdr["cylinder6"].ToString(),
                        //Color7 = rdr["color7"].ToString(),
                        //Cylinder7 = rdr["cylinder7"].ToString(),
                        //Color8 = rdr["color8"].ToString(),
                        //Cylinder8 = rdr["cylinder8"].ToString(),
                        //Color9 = rdr["color9"].ToString(),
                        //Cylinder9 = rdr["cylinder9"].ToString(),
                        //Color10 = rdr["color10"].ToString(),
                        //Cylinder10 = rdr["cylinder10"].ToString()
                    };
                    lstobj.Add(objrd);
                }
                con.Close();
            }
            return lstobj;
        }
        public Boolean InsertAudittrial(String actdesc , String munname)
        {
            Boolean bRet = false;
            long iUser = 0 ;
            long iClient = 0;
            string sClient = "127.0.0.1";
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("insert into public.rpt_audittrial(");
            sql.AppendLine("client_id, client_ip, id_stuser, menu_name, action_desc");
            sql.AppendLine(")");
            sql.AppendLine("Values(");
            sql.AppendLine("@client_id, @client_ip, @id_stuser, @menu_name, @action_desc");
            sql.AppendLine(")");
            sql.AppendLine(";");

            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };
                cmd.Parameters.AddWithValue("@client_id", NpgsqlDbType.Bigint, iClient);
                cmd.Parameters.AddWithValue("@client_ip", NpgsqlDbType.Varchar, sClient);
                cmd.Parameters.AddWithValue("@client_ip", NpgsqlDbType.Bigint, iUser);
                cmd.Parameters.AddWithValue("@menu_name", NpgsqlDbType.Varchar, munname);
                cmd.Parameters.AddWithValue("@action_desc", NpgsqlDbType.Varchar, actdesc);
                try
                {
                    con.Open();
                }
                catch (NpgsqlException exp)
                {
                    string msgexcep = exp.Message.ToString();
                    goto ConnClose;
                }
                //----------------------------------------------------------
                NpgsqlTransaction trans = con.BeginTransaction();
                cmd.Connection = con;
                cmd.Transaction = trans;
                try
                {
                    cmd.ExecuteNonQuery();
                    trans.Commit();
                    bRet = true;
                }
                catch (NpgsqlException exp)
                {
                    string msgexcep = exp.Message.ToString();
                    trans.Rollback();
                }
                finally
                {
                    con.Close();
                }
            }
        ConnClose:
            return bRet;
        }
    }
}
