using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Npgsql;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Controllers;
using GoWMS.Server.Models;
using System.Text;

namespace GoWMS.Server.Data
{
    public class WarehouseDAL
    {
        readonly private string connString = ConnGlobals.GetConnLocalDBPG();

        public IEnumerable<WhStorageCapacity> GetStorageCapacities()
        {
            List<WhStorageCapacity> lstModels = new List<WhStorageCapacity>();
            using (NpgsqlConnection con = new NpgsqlConnection(connString))
            {
                StringBuilder sqlQurey = new StringBuilder();
                /*
                sqlQurey.AppendLine("select row_number() over(order by srm_no asc) AS rn");
                sqlQurey.AppendLine(", srm_name, srm_no, locavlt1, locavlt2 , locemp, plemp, plerr, prohloc, total, percen/100.00 AS percen");
                sqlQurey.AppendLine("from wcs.vrpt_shelfsummary_bytype");
                sqlQurey.AppendLine("order by srm_no asc");
                sqlQurey.AppendLine(";");
                */
                sqlQurey.AppendLine("select row_number() over(order by srm_no asc) AS rn");
                sqlQurey.AppendLine(", srm_name, srm_no, locavl, locemp, plemp, plerr, prohloc, total, percen");
                sqlQurey.AppendLine("from wcs.vrpt_shelfsummary");
                sqlQurey.AppendLine("order by srm_no asc");
                sqlQurey.AppendLine(";");

                NpgsqlCommand cmd = new NpgsqlCommand(sqlQurey.ToString(), con)
                {
                    CommandType = CommandType.Text
                };
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    WhStorageCapacity listRead = new WhStorageCapacity
                    {
                        Rn =  rdr["rn"] == DBNull.Value ? null : (Int64?)rdr["rn"],
                        Srmname = rdr["srm_name"].ToString(),
                        Srmno = rdr["srm_no"] == DBNull.Value ? null : (Int32?)rdr["srm_no"],
                        Locavlt1 = rdr["locavl"] == DBNull.Value ? null : (Int64?)rdr["locavl"],
                        Locavlt2 = rdr["locavl"] == DBNull.Value ? null : (Int64?)rdr["locavl"],
                        Locemp = rdr["locemp"] == DBNull.Value ? null : (Int64?)rdr["locemp"],
                        Plemp = rdr["plemp"] == DBNull.Value ? null : (Int64?)rdr["plemp"],
                        Perr = rdr["plerr"] == DBNull.Value ? null : (Int64?)rdr["plerr"],
                        Prohloc = rdr["prohloc"] == DBNull.Value ? null : (Int64?)rdr["prohloc"],
                        Total = rdr["total"] == DBNull.Value ? null : (Int64?)rdr["total"],
                        OccRate = rdr["percen"] == DBNull.Value ? null : (decimal?)rdr["percen"],
                    };
                    lstModels.Add(listRead);
                }
                con.Close();
            }
            return lstModels;
        }

        //---------------------------------------------------------------------------------------------

        public IEnumerable<WhStorageList> GetStorageLists()
        {
            List<WhStorageList> lstModels = new List<WhStorageList>();
            using (NpgsqlConnection con = new NpgsqlConnection(connString))
            {
                StringBuilder sqlQurey = new StringBuilder();

                sqlQurey.AppendLine("select row_number() over(order by shelf_no asc) AS rn");
                sqlQurey.AppendLine(", shelf_no, shelfcode, shelfname");
                sqlQurey.AppendLine(", srm_no, shelfbank, shelfbay, shelflevel, shelfstatus");
                sqlQurey.AppendLine(", lpncode, actual_size, desc_size, st_desc, backcolor, focecolor, modified");
                sqlQurey.AppendLine("from wcs.vrpt_shelf_list");
                sqlQurey.AppendLine("order by shelf_no asc");
                sqlQurey.AppendLine(";");


                NpgsqlCommand cmd = new NpgsqlCommand(sqlQurey.ToString(), con)
                {
                    CommandType = CommandType.Text
                };
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    WhStorageList listRead = new WhStorageList
                    {
                        Rn = rdr["rn"] == DBNull.Value ? null : (Int64?)rdr["rn"],
                        Shelfno = rdr["shelf_no"] == DBNull.Value ? null : (Int32?)rdr["shelf_no"],
                        Shelfcode = rdr["shelfcode"].ToString(),
                        Shelfname = rdr["shelfname"].ToString(),
                        Srmno = rdr["srm_no"] == DBNull.Value ? null : (Int32?)rdr["srm_no"],
                        Shelfbank = rdr["shelfbank"] == DBNull.Value ? null : (Int16?)rdr["shelfbank"],
                        Shelfbay = rdr["shelfbay"] == DBNull.Value ? null : (Int32?)rdr["shelfbay"],
                        Shelflevel = rdr["shelflevel"] == DBNull.Value ? null : (Int16?)rdr["shelflevel"],
                        Shelfstatus = rdr["shelfstatus"] == DBNull.Value ? null : (Int32?)rdr["shelfstatus"],
                        Lpncode = rdr["lpncode"].ToString(),
                        Actualsize = rdr["actual_size"] == DBNull.Value ? null : (Int32?)rdr["actual_size"],
                        Descsize = rdr["desc_size"].ToString(),
                        Stdesc = rdr["st_desc"].ToString(),
                        Backcolor = rdr["backcolor"].ToString(),
                        Focecolor = rdr["focecolor"].ToString(),
                        Modified = rdr["modified"] == DBNull.Value ? null : (DateTime?)rdr["modified"]
                    };
                    lstModels.Add(listRead);
                }
                con.Close();
            }
            return lstModels;
        }

    }
}
