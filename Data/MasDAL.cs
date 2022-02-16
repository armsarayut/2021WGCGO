using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Npgsql;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using GoWMS.Server.Controllers;
using GoWMS.Server.Models;
using GoWMS.Server.Models.Mas;
using NpgsqlTypes;
using Serilog;

namespace GoWMS.Server.Data
{
    public class MasDAL
    {
        readonly private string connectionString = ConnGlobals.GetConnLocalDBPG();

        public IEnumerable<Mas_Pallet_Go> GetAllMasterpalletGo()
        {
            List<Mas_Pallet_Go> lstobj = new List<Mas_Pallet_Go>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder Sql = new StringBuilder();
                Sql.AppendLine("select *");
                Sql.AppendLine("from wms.mas_pallet_go");
                Sql.AppendLine("order by efidx");
                
                NpgsqlCommand cmd = new NpgsqlCommand(Sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Mas_Pallet_Go objrd = new Mas_Pallet_Go
                    {
                        Efidx = rdr["efidx"] == DBNull.Value ? null : (Int64?)rdr["efidx"],
                        Efstatus = rdr["efstatus"] == DBNull.Value ? null : (Int32?)rdr["efstatus"],
                        Created = rdr["created"] == DBNull.Value ? null : (DateTime?)rdr["created"],
                        Modified = rdr["modified"] == DBNull.Value ? null : (DateTime?)rdr["modified"],
                        Innovator = rdr["innovator"] == DBNull.Value ? null : (Int64?)rdr["innovator"],
                        Device = rdr["device"].ToString(),
                        Palletno = rdr["palletno"].ToString(),
                        Pallettype = rdr["pallettype"] == DBNull.Value ? null : (Int32?)rdr["pallettype"]  
                    };
                    lstobj.Add(objrd);
                }
                con.Close();
            }
            return lstobj;
        }

        public IEnumerable<Mas_Storagebin_Go> GetAllStorageBinGo()
        {
            List<Mas_Storagebin_Go> lstobj = new List<Mas_Storagebin_Go>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder Sql = new StringBuilder();
                Sql.AppendLine("select *");
                Sql.AppendLine("from wms.mas_storagebin_go");
                Sql.AppendLine("order by efidx");

                NpgsqlCommand cmd = new NpgsqlCommand(Sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Mas_Storagebin_Go objrd = new Mas_Storagebin_Go
                    {
                        Efidx = rdr["efidx"] == DBNull.Value ? null : (Int64?)rdr["efidx"],
                        Efstatus = rdr["efstatus"] == DBNull.Value ? null : (Int32?)rdr["efstatus"],
                        Created = rdr["created"] == DBNull.Value ? null : (DateTime?)rdr["created"],
                        Modified = rdr["modified"] == DBNull.Value ? null : (DateTime?)rdr["modified"],
                        Innovator = rdr["innovator"] == DBNull.Value ? null : (Int64?)rdr["innovator"],
                        Device = rdr["device"].ToString(),
                        Stocode = rdr["stocode"].ToString(),
                        Binno = rdr["binno"].ToString(),
                        Binname = rdr["binname"].ToString(),
                        Pallletno = rdr["pallletno"].ToString()
                    };
                    lstobj.Add(objrd);
                }
                con.Close();
            }
            return lstobj;
        }

        public IEnumerable<Mas_Item_Go> GetAllMasteritemGo()
        {
            List<Mas_Item_Go> lstobj = new List<Mas_Item_Go>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder Sql = new StringBuilder();
                Sql.AppendLine("select *");
                Sql.AppendLine("from wms.mas_item_go");
                Sql.AppendLine("order by efidx");

                NpgsqlCommand cmd = new NpgsqlCommand(Sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Mas_Item_Go objrd = new Mas_Item_Go
                    {
                        Efidx = rdr["efidx"] == DBNull.Value ? null : (Int64?)rdr["efidx"],
                        Efstatus = rdr["efstatus"] == DBNull.Value ? null : (Int32?)rdr["efstatus"],
                        Created = rdr["created"] == DBNull.Value ? null : (DateTime?)rdr["created"],
                        Modified = rdr["modified"] == DBNull.Value ? null : (DateTime?)rdr["modified"],
                        Innovator = rdr["innovator"] == DBNull.Value ? null : (Int64?)rdr["innovator"],
                        Device = rdr["device"].ToString(),
                        Itemcode = rdr["itemcode"].ToString(),
                        Itemname = rdr["itemname"].ToString(),
                        Itembrand = rdr["itembrand"].ToString(),
                        Weightnet = rdr["weightnet"] == DBNull.Value ? null : (decimal?)rdr["weightnet"],
                        Weightgross = rdr["weightgross"] == DBNull.Value ? null : (decimal?)rdr["weightgross"],
                        Weightuint = rdr["weightuint"].ToString(),
                        Vendor = rdr["vendor"].ToString()
                    };
                    lstobj.Add(objrd);
                }
                con.Close();
            }
            return lstobj;
        }

        public IEnumerable<Mas_Storage_Go> GetAllMasterstorageGo()
        {
            List<Mas_Storage_Go> lstobj = new List<Mas_Storage_Go>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder Sql = new StringBuilder();
                Sql.AppendLine("select *");
                Sql.AppendLine("from wms.mas_storage_go");
                Sql.AppendLine("order by efidx");

                NpgsqlCommand cmd = new NpgsqlCommand(Sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Mas_Storage_Go objrd = new Mas_Storage_Go
                    {
                        Efidx = rdr["efidx"] == DBNull.Value ? null : (Int64?)rdr["efidx"],
                        Efstatus = rdr["efstatus"] == DBNull.Value ? null : (Int32?)rdr["efstatus"],
                        Created = rdr["created"] == DBNull.Value ? null : (DateTime?)rdr["created"],
                        Modified = rdr["modified"] == DBNull.Value ? null : (DateTime?)rdr["modified"],
                        Innovator = rdr["innovator"] == DBNull.Value ? null : (Int64?)rdr["innovator"],
                        Device = rdr["device"].ToString(),
                        Stocode = rdr["stocode"].ToString(),
                        Stoname = rdr["stoname"].ToString(),
                        Stoaddress = rdr["stoaddress"].ToString()
                    };
                    lstobj.Add(objrd);
                }
                con.Close();
            }
            return lstobj;
        }

        public IEnumerable<Mas_Worktype_Go> GetAllMasterworktypeGo()
        {
            List<Mas_Worktype_Go> lstobj = new List<Mas_Worktype_Go>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder Sql = new StringBuilder();
                Sql.AppendLine("select *");
                Sql.AppendLine("from wms.mas_worktype_go");
                Sql.AppendLine("order by efidx");

                NpgsqlCommand cmd = new NpgsqlCommand(Sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Mas_Worktype_Go objrd = new Mas_Worktype_Go
                    {
                        Efidx = rdr["efidx"] == DBNull.Value ? null : (Int64?)rdr["efidx"],
                        Efstatus = rdr["efstatus"] == DBNull.Value ? null : (Int32?)rdr["efstatus"],
                        Created = rdr["created"] == DBNull.Value ? null : (DateTime?)rdr["created"],
                        Modified = rdr["modified"] == DBNull.Value ? null : (DateTime?)rdr["modified"],
                        Innovator = rdr["innovator"] == DBNull.Value ? null : (Int64?)rdr["innovator"],
                        Device = rdr["device"].ToString(),
                        Workcode = rdr["workcode"].ToString(),
                        Description = rdr["description"].ToString()
                    };
                    lstobj.Add(objrd);
                }
                con.Close();
            }
            return lstobj;
        }

        public IEnumerable<Mas_Status_Go> GetAllMasterstatusGo()
        {
            List<Mas_Status_Go> lstobj = new List<Mas_Status_Go>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder Sql = new StringBuilder();
                Sql.AppendLine("select *");
                Sql.AppendLine("from wms.mas_status_go");
                Sql.AppendLine("order by efidx");

                NpgsqlCommand cmd = new NpgsqlCommand(Sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Mas_Status_Go objrd = new Mas_Status_Go
                    {
                        Efidx = rdr["efidx"] == DBNull.Value ? null : (Int64?)rdr["efidx"],
                        Efstatus = rdr["efstatus"] == DBNull.Value ? null : (Int32?)rdr["efstatus"],
                        Created = rdr["created"] == DBNull.Value ? null : (DateTime?)rdr["created"],
                        Modified = rdr["modified"] == DBNull.Value ? null : (DateTime?)rdr["modified"],
                        Innovator = rdr["innovator"] == DBNull.Value ? null : (Int64?)rdr["innovator"],
                        Device = rdr["device"].ToString(),
                        Statcode = rdr["statcode"] == DBNull.Value ? null : (Int32?)rdr["statcode"],
                        Description = rdr["description"].ToString()
                    };
                    lstobj.Add(objrd);
                }
                con.Close();
            }
            return lstobj;
        }

        public IEnumerable<Mas_Reason_Go> GetAllMasterreasonGo()
        {
            List<Mas_Reason_Go> lstobj = new List<Mas_Reason_Go>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder Sql = new StringBuilder();
                Sql.AppendLine("select *");
                Sql.AppendLine("from wms.mas_reason_go");
                Sql.AppendLine("order by efidx");

                NpgsqlCommand cmd = new NpgsqlCommand(Sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Mas_Reason_Go objrd = new Mas_Reason_Go
                    {
                        Efidx = rdr["efidx"] == DBNull.Value ? null : (Int64?)rdr["efidx"],
                        Efstatus = rdr["efstatus"] == DBNull.Value ? null : (Int32?)rdr["efstatus"],
                        Created = rdr["created"] == DBNull.Value ? null : (DateTime?)rdr["created"],
                        Modified = rdr["modified"] == DBNull.Value ? null : (DateTime?)rdr["modified"],
                        Innovator = rdr["innovator"] == DBNull.Value ? null : (Int64?)rdr["innovator"],
                        Device = rdr["device"].ToString(),
                        Rescode = rdr["rescode"].ToString(),
                        Description = rdr["description"].ToString()
                    };
                    lstobj.Add(objrd);
                }
                con.Close();
            }
            return lstobj;
        }

        public Boolean ValidateMasterpallet(string spallet)
        {
            Boolean bret = false;

            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                try
                {
                    StringBuilder Sql = new StringBuilder();
                    Sql.AppendLine("select *");
                    Sql.AppendLine("from wms.mas_pallet_go");
                    Sql.AppendLine("where palletno = @palletno");

                    NpgsqlCommand cmd = new NpgsqlCommand(Sql.ToString(), con)
                    {
                        CommandType = CommandType.Text
                    };

                    con.Open();

                    cmd.Parameters.AddWithValue("@palletno", NpgsqlDbType.Varchar, spallet);

                    NpgsqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        bret = true;
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
            return bret;
        }

    }
}
