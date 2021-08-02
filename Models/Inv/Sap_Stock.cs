using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Inv
{
    public class Sap_Stock
    {
        private Int64? m_idx;
        public Int64? Idx { get => m_idx; set => m_idx = value; }

        private string m_su_no;
        public string Su_No { get => m_su_no; set => m_su_no = value; }

        private string m_po_no;
        public string Po_No { get => m_po_no; set => m_po_no = value; }

        private string m_item_code;
        public string Item_Code { get => m_item_code; set => m_item_code = value; }

        private string m_item_name;
        public string Item_Name { get => m_item_name; set => m_item_name = value; }

        private string m_movement_type;
        public string Movement_Type { get => m_movement_type; set => m_movement_type = value; }

        private string m_movement_reason;
        public string Movement_Reason { get => m_movement_reason; set => m_movement_reason = value; }

        private string m_to_no;
        public string To_No { get => m_to_no; set => m_to_no = value; }

        private string m_doc_ref;
        public string Doc_Ref { get => m_doc_ref; set => m_doc_ref = value; }

        private string m_ean;
        public string Ean { get => m_ean; set => m_ean = value; }

        private string m_invoice_no;
        public string Invoice_No { get => m_invoice_no; set => m_invoice_no = value; }

        private DateTime? m_receiving_date;
        public DateTime? Receiving_Date { get => m_receiving_date; set => m_receiving_date = value; }

        private string m_from_stype;
        public string From_Stype { get => m_from_stype; set => m_from_stype = value; }

        private string m_from_bin;
        public string From_Bin { get => m_from_bin; set => m_from_bin = value; }

        private string m_art_slip;
        public string Art_Slip { get => m_art_slip; set => m_art_slip = value; }

        private string m_unit;
        public string Unit { get => m_unit; set => m_unit = value; }

        private string m_gate;
        public string Gate { get => m_gate; set => m_gate = value; }

        private string m_batch_number;
        public string Batch_Number { get => m_batch_number; set => m_batch_number = value; }

        private Int32? m_qty;
        public Int32? Qty { get => m_qty; set => m_qty = value; }

        private string m_to_stype;
        public string To_Stype { get => m_to_stype; set => m_to_stype = value; }

        private string m_to_bin;
        public string To_Bin { get => m_to_bin; set => m_to_bin = value; }

        private string m_site;
        public string Site { get => m_site; set => m_site = value; }

        private string m_storage_location;
        public string Storage_Location { get => m_storage_location; set => m_storage_location = value; }

        private string m_warehouse;
        public string Warehouse { get => m_warehouse; set => m_warehouse = value; }

        private string m_su_type;
        public string Su_Type { get => m_su_type; set => m_su_type = value; }

        private Int32? m_vendor_code;
        public Int32? Vendor_Code { get => m_vendor_code; set => m_vendor_code = value; }

        private Int32? m_total_qty;
        public Int32? Total_Qty { get => m_total_qty; set => m_total_qty = value; }

        private string m_text_note;
        public string Text_Note { get => m_text_note; set => m_text_note = value; }

        private Int32? m_status;
        public Int32? Status { get => m_status; set => m_status = value; }

        private string m_error_code;
        public string Error_Code { get => m_error_code; set => m_error_code = value; }

        private string m_created_by;
        public string Created_By { get => m_created_by; set => m_created_by = value; }

        private DateTime? m_created_date;
        public DateTime? Created_Date { get => m_created_date; set => m_created_date = value; }

        private string m_update_by;
        public string Update_By { get => m_update_by; set => m_update_by = value; }

        private DateTime? m_update_date;
        public DateTime? Update_Date { get => m_update_date; set => m_update_date = value; }

        private Double? m_net_weight;
        public Double? Net_Weight { get => m_net_weight; set => m_net_weight = value; }

        private string m_net_weight_unit;
        public string Net_Weight_Unit { get => m_net_weight_unit; set => m_net_weight_unit = value; }

        private string m_po_item;
        public string Po_Item { get => m_po_item; set => m_po_item = value; }

        private string m_do_number;
        public string Do_Number { get => m_do_number; set => m_do_number = value; }

        private string m_do_item;
        public string Do_Item { get => m_do_item; set => m_do_item = value; }

        private string m_stock_consign;
        public string Stock_Consign { get => m_stock_consign; set => m_stock_consign = value; }

        private string m_article_doc;
        public string Article_Doc { get => m_article_doc; set => m_article_doc = value; }

        private string m_error_msg_sap;
        public string Error_Msg_Sap { get => m_error_msg_sap; set => m_error_msg_sap = value; }

        private Int32? m_doc_year;
        public Int32? Doc_Year { get => m_doc_year; set => m_doc_year = value; }

        private string m_warehouse_no;
        public string Warehouse_No { get => m_warehouse_no; set => m_warehouse_no = value; }

        private string m_confirm_to;
        public string Confirm_To { get => m_confirm_to; set => m_confirm_to = value; }

        private string m_to_line;
        public string To_Line { get => m_to_line; set => m_to_line = value; }

        private string m_consign_flag;
        public string Consign_Flag { get => m_consign_flag; set => m_consign_flag = value; }

        private DateTime? m_sync_time;
        public DateTime? Sync_Time { get => m_sync_time; set => m_sync_time = value; }

        private DateTime? m_store_time;
        public DateTime? Store_Time { get => m_store_time; set => m_store_time = value; }

        private string m_palletcode;
        public string Palletcode { get => m_palletcode; set => m_palletcode = value; }


    }
}
