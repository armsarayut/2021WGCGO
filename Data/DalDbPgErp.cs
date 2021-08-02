using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Npgsql;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Controllers;
using GoWMS.Server.Models;
using GoWMS.Server.Models.Api;

namespace GoWMS.Server.Data
{
    public class DalDbPgErp
    {
        readonly private string connectionString = ConnGlobals.GetConnLocalDBPG();

        public IEnumerable<Api_Itemmaster_Go> GetApi_Itemmaster_Gos()
        {
            List<Api_Itemmaster_Go> lstApiItemmaster = new List<Api_Itemmaster_Go>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT efidx, efstatus, created, modified, innovator, device, itemcode " +
                                                       "FROM public.api_itemmaster_go ", con)
                {
                    CommandType = CommandType.Text
                };
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Api_Itemmaster_Go GR = new Api_Itemmaster_Go
                    {
                        Efidx = rdr["efidx"] == DBNull.Value ? null : (Int64?)rdr["efidx"],
                        Efstatus = rdr["efstatus"] == DBNull.Value ? null : (int?)rdr["efstatus"],
                        Created = rdr["created"] == DBNull.Value ? null : (DateTime?)rdr["created"],
                        Modified = rdr["modified"] == DBNull.Value ? null : (DateTime?)rdr["modified"],
                        Innovator = rdr["innovator"] == DBNull.Value ? null : (long?)rdr["innovator"],
                        Device = rdr["device"].ToString(),
                        Itemcode = rdr["itemcode"].ToString()
                       
                    };
                    lstApiItemmaster.Add(GR);
                }
                con.Close();
            }
            return lstApiItemmaster;
        }
    }
}
