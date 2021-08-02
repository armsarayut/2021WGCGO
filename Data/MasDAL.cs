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







    }
}
