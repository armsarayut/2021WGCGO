using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Public
{
    public class Sap_Stock
    {
		public Int64? Idx { get; set; }
		public string Su_No { get; set; }
		public string Po_No { get; set; }
		public string Item_Code { get; set; }
		public string Item_Name { get; set; }
		public string Movement_Type { get; set; }
		public string Movement_Reason { get; set; }
		public string To_No { get; set; }
		public string Doc_Ref { get; set; }
		public string Ean { get; set; }
		public string Invoice_No { get; set; }
		public DateTime? Receiving_Date { get; set; }
		public string From_Stype { get; set; }
		public string From_Bin { get; set; }
		public string Art_Slip { get; set; }
		public string Unit { get; set; }
		public string Gate { get; set; }
		public string Batch_Number { get; set; }
		public Decimal? Qty { get; set; }
		public string To_Stype { get; set; }
		public string To_Bin { get; set; }
		public string Site { get; set; }
		public string Storage_Location { get; set; }
		public string Warehouse { get; set; }
		public string Su_Type { get; set; }
		public Int32? Vendor_Code { get; set; }
		public Decimal? Total_Qty { get; set; }
		public string Text_Note { get; set; }
		public Int32? Status { get; set; }
		public string Error_Code { get; set; }
		public string Created_By { get; set; }
		public DateTime? Created_Date { get; set; }
		public string Update_By { get; set; }
		public DateTime? Update_Date { get; set; }
		public Decimal? Net_Weight { get; set; }
		public string Net_Weight_Unit { get; set; }
		public string Po_Item { get; set; }
		public string Do_Number { get; set; }
		public string Do_Item { get; set; }
		public string Stock_Consign { get; set; }
		public string Article_Doc { get; set; }
		public string Error_Msg_Sap { get; set; }
		public Decimal? Doc_Year { get; set; }
		public string Warehouse_No { get; set; }
		public string Confirm_To { get; set; }
		public string To_Line { get; set; }
		public string Consign_Flag { get; set; }
		public DateTime? Sync_Time { get; set; }
		public DateTime? Store_Time { get; set; }
		public string Palletcode { get; set; }
	}
}
