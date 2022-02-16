using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Public
{
    public class Sap_Operateresult
    {
		public Int64? Idx { get; set; }
		public DateTime? Created { get; set; }
		public Int32? Entity_Lock { get; set; }
		public DateTime? Modified { get; set; }
		public Int64? Client_Id { get; set; }
		public string Client_Ip { get; set; }
		
		public string Work_Type { get; set; }
		public string Movement_Type { get; set; }
		public string Movemet_Reason { get; set; }
		public string Item_Code { get; set; }
		public string Batch_Number { get; set; }
		public string Su_No { get; set; }
		public string Dest_Su_No { get; set; }
		public string Order_No { get; set; }
		public string To_No { get; set; }
		public string To_Line { get; set; }
		public string Doc_Ref { get; set; }
		public Int32? Status { get; set; }
		public Decimal? Result_Qty { get; set; }
		public Decimal? Shortge_Qty { get; set; }
		public string Location_No { get; set; }
		public string Po_No { get; set; }
		public string Invoice_No { get; set; }
		public DateTime? Recviving_Date { get; set; }
		public DateTime? Delivery_Date { get; set; }
		public string Create_By { get; set; }
		public DateTime? Created_Date { get; set; }
		public string Order_Line { get; set; }
		public string Queue_No { get; set; }
		public string Crane_No { get; set; }
		public string Ship_To_Code { get; set; }
		public string Ship_Name { get; set; }
		public Int32? Delivery_Priority { get; set; }
		public string Item_Name { get; set; }
		public string Pallet_No { get; set; }
		public string Ref_No { get; set; }
		public string Ref_Line { get; set; }
		public string Remark { get; set; }
	}
}
