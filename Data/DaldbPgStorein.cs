using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Npgsql;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Controllers;
using GoWMS.Server.Models;

namespace GoWMS.Server.Data
{
    public class DaldbPgStorein
    {
        readonly private string connString = ConnGlobals.GetConnLocalDBPG();

        public IEnumerable<Sap_Storein> GetAllStorein()
        {
            List<Sap_Storein> lstModels = new List<Sap_Storein>();
            using (NpgsqlConnection con = new NpgsqlConnection(connString))
            {
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * " +
                                                       "FROM public.sap_storein ", con)
                {
                    CommandType = CommandType.Text
                };
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Sap_Storein listRead = new Sap_Storein
                    {
                        Idx = rdr["idx"] == DBNull.Value ? null : (Int64?)rdr["idx"],
                        Created = rdr["created"] == DBNull.Value ? null : (DateTime?)rdr["created"],
                        Entity_Lock = rdr["entity_lock"] == DBNull.Value ? null : (Int32?)rdr["entity_lock"],
                        Modified = rdr["modified"] == DBNull.Value ? null : (DateTime?)rdr["modified"],
                        Client_Id = rdr["client_id"] == DBNull.Value ? null : (long?)rdr["client_id"],
                        Client_Ip = rdr["client_ip"].ToString(),
                        Su_No = rdr["su_no"].ToString(),
                        Po_No = rdr["po_no"].ToString(),
                        Item_Code = rdr["item_code"].ToString(),
                        Item_Name = rdr["item_name"].ToString(),
                        Movement_Type = rdr["movement_type"].ToString(),
                        Movement_Reason = rdr["movement_reason"].ToString(),
                        To_No = rdr["to_no"].ToString(),
                        Doc_Ref = rdr["doc_ref"].ToString(),
                        Ean = rdr["ean"].ToString(),
                        Invoice_No = rdr["invoice_no"].ToString(),
                        Receiving_Date = rdr["receiving_date"] == DBNull.Value ? null : (DateTime?)rdr["receiving_date"],
                        From_Stype = rdr["from_stype"].ToString(),
                        From_Bin = rdr["from_bin"].ToString(),
                        Art_Slip = rdr["art_slip"].ToString(),
                        Unit = rdr["unit"].ToString(),
                        Gate = rdr["gate"].ToString(),
                        Batch_Number = rdr["batch_number"].ToString(),
                        Qty = rdr["qty"] == DBNull.Value ? null : (int?)rdr["qty"],
                        To_Stype = rdr["to_stype"].ToString(),
                        To_Bin = rdr["to_bin"].ToString(),
                        Site = rdr["site"].ToString(),
                        Storage_Location = rdr["storage_location"].ToString(),
                        Warehouse = rdr["warehouse"].ToString(),
                        Su_Type = rdr["su_type"].ToString(),
                        Vendor_Code = rdr["vendor_code"] == DBNull.Value ? null : (int?)rdr["vendor_code"],
                        Total_Qty = rdr["total_qty"] == DBNull.Value ? null : (int?)rdr["total_qty"],
                        Text_Note = rdr["text_note"].ToString(),
                        Status = rdr["status"] == DBNull.Value ? null : (int?)rdr["status"],
                        Error_Code = rdr["error_code"].ToString(),
                        Created_By = rdr["created_by"].ToString(),
                        Created_Date = rdr["created_date"] == DBNull.Value ? null : (DateTime?)rdr["created_date"],
                        Update_By = rdr["update_by"].ToString(),
                        Update_Date = rdr["update_date"] == DBNull.Value ? null : (DateTime?)rdr["update_date"],
                        Net_Weight = rdr["net_weight"] == DBNull.Value ? null : (decimal?)rdr["net_weight"],
                        Net_Weight_Unit = rdr["net_weight_unit"].ToString(),
                        Po_Item = rdr["po_item"].ToString(),
                        Do_Number = rdr["do_number"].ToString(),
                        Do_Item = rdr["do_item"].ToString(),
                        Stock_Consign = rdr["stock_consign"].ToString(),
                        Article_Doc = rdr["article_doc"].ToString(),
                        Error_Msg_Sap = rdr["error_msg_sap"].ToString(),
                        Doc_Year =  rdr["doc_year"] == DBNull.Value ? null : (int?)rdr["doc_year"], 
                        Warehouse_No = rdr["warehouse_no"].ToString(),
                        Confirm_To = rdr["confirm_to"].ToString(),
                        To_Line = rdr["to_line"].ToString(),
                        Consign_Flag = rdr["consign_flag"].ToString(),
                        Store_Table = rdr["store_table"].ToString(),
                        Sap_Su = rdr["sap_su"].ToString()
                   

                    };
                    lstModels.Add(listRead);
                }
                con.Close();
            }
            return lstModels;
        }

    }
}
