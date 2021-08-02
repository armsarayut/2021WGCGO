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
using GoWMS.Server.Models.Inv;


namespace GoWMS.Server.Data
{
    public class InvDAL
    {
        readonly private string connectionString = ConnGlobals.GetConnLocalDBPG();

        public IEnumerable<InvStockList> GetStockList()
        {
            List<InvStockList> lstobj = new List<InvStockList>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder Sql = new StringBuilder();
                /*
                Sql.AppendLine("select row_number() over(order by  t1.item_code asc) AS rn,");
                Sql.AppendLine("t1.item_code, t1.item_name, t1.qty, t1.su_no, t1.palletcode, t3.shelfname ");
                Sql.AppendLine("from public.sap_stock t1");
                Sql.AppendLine("left join public.sap_itemmaster_v t2");
                Sql.AppendLine("on t1.item_code=t2.article");
                Sql.AppendLine("left join wcs.set_shelf t3");
                Sql.AppendLine("on t1.palletcode=t3.lpncode ");
                Sql.AppendLine("order by item_code");
                */
                Sql.AppendLine("select row_number() over(order by  itemcode asc) AS rn,");
                Sql.AppendLine("itemcode, itemname, quantity, pallettag, pallteno, storagearea, storagebin");
                Sql.AppendLine("from wms.inv_stock_go ");
                Sql.AppendLine("order by itemcode");

                NpgsqlCommand cmd = new NpgsqlCommand(Sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };

                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    InvStockList objrd = new InvStockList
                    {
                        Rn= rdr["rn"] == DBNull.Value ? null : (Int64?)rdr["rn"],
                        Item_code = rdr["itemcode"].ToString(),
                        Item_name = rdr["itemname"].ToString(),
                        Qty = rdr["quantity"] == DBNull.Value ? null : (decimal?)rdr["quantity"],
                        Su_no = rdr["pallettag"].ToString(),
                        Palletcode = rdr["pallteno"].ToString(),
                        Shelfname = rdr["storagebin"].ToString(),
                        StorageArae = rdr["storagearea"].ToString()
                    };
                    lstobj.Add(objrd);
                }
                con.Close();
            }
            return lstobj;
        }

        public IEnumerable<InvStockSum> GetStockSum()
        {
            List<InvStockSum> lstobj = new List<InvStockSum>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                StringBuilder Sql = new StringBuilder();

                Sql.AppendLine("select row_number() over(order by itemcode asc) AS rn,");
                Sql.AppendLine("itemcode, itemname, sum(quantity) as totalstock, count(pallteno) as countpallet");
                Sql.AppendLine("from wms.inv_stock_go ");
                Sql.AppendLine("group by itemcode, itemname");
                Sql.AppendLine("order by itemcode");

                NpgsqlCommand cmd = new NpgsqlCommand(Sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };

                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    InvStockSum objrd = new InvStockSum
                    {
                        Rn = rdr["rn"] == DBNull.Value ? null : (Int64?)rdr["rn"],
                        Item_code = rdr["itemcode"].ToString(),
                        Item_name = rdr["itemname"].ToString(),
                        Totalstock = rdr["totalstock"] == DBNull.Value ? null : (Decimal?)rdr["totalstock"],
                        Countpallet = rdr["countpallet"] == DBNull.Value ? null : (Int64?)rdr["countpallet"]
                    };
                    lstobj.Add(objrd);
                }
                con.Close();
            }
            return lstobj;
        }

        public IEnumerable<Vrpt_shelf_listInfo> GetShelfLocation()
        {
            List<Vrpt_shelf_listInfo> lstobj = new List<Vrpt_shelf_listInfo>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                 StringBuilder Sql = new StringBuilder();
                Sql.AppendLine("SELECT modified, srm_no, shelf_no, shelfcode, shelfname");
                Sql.AppendLine(", shelfbank, shelfframe, shelfbay, shelflevel, shelfstatus");
                Sql.AppendLine(", lpncode, refercode, actual_weight, actual_size, desc_size, st_desc");
                Sql.AppendLine("from  wcs.vrpt_shelf_list");
                Sql.AppendLine("order by shelf_no asc");

                NpgsqlCommand cmd = new NpgsqlCommand(Sql.ToString(), con)
                {
                    CommandType = CommandType.Text
                };

                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Vrpt_shelf_listInfo objrd = new Vrpt_shelf_listInfo
                    {
                       
                        Srm_no = rdr["srm_no"] == DBNull.Value ? null : (Int32?)rdr["srm_no"],
                        Shelf_no = rdr["shelf_no"] == DBNull.Value ? null : (Int32?)rdr["shelf_no"],
                        Shelfcode = rdr["shelfcode"].ToString(),
                        Shelfname  = rdr["shelfname"].ToString(),
                        Shelfbank = rdr["shelfbank"] == DBNull.Value ? null : (Int16?)rdr["shelfbank"],
                        Shelfbay = rdr["shelfbay"] == DBNull.Value ? null : (Int32?)rdr["shelfbay"],
                        Shelfframe = rdr["shelfframe"] == DBNull.Value ? null : (Int16?)rdr["shelfframe"],
                        Shelflevel = rdr["shelflevel"] == DBNull.Value ? null : (Int16?)rdr["shelflevel"],
                        Shelfstatus = rdr["shelfstatus"] == DBNull.Value ? null : (Int32?)rdr["shelfstatus"],
                        Lpncode= rdr["lpncode"].ToString(),
                        Refercode = rdr["refercode"].ToString(),
                        Actual_weight = rdr["actual_weight"] == DBNull.Value ? null : (decimal?)rdr["actual_weight"],
                        Actual_size = rdr["actual_size"] == DBNull.Value ? null : (Int32?)rdr["actual_size"],
                        Desc_size = rdr["desc_size"].ToString(),
                        St_desc = rdr["st_desc"].ToString()

                    };
                    lstobj.Add(objrd);
                }
                con.Close();
            }
            return lstobj;
        }




    }
}
