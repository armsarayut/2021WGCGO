using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Public
{
    public class Sap_Batchorder
    {
		public Int64? Idx { get; set; }
		public DateTime? Cdate { get; set; }
		public Int32? Created { get; set; }
		public string Batch_No { get; set; }
		public Int64? Storeout_Id { get; set; }
		public string Order_No { get; set; }
		public string Ship_To_Code { get; set; }
		public string Ship_Name { get; set; }
		public string Item_Code { get; set; }
		public string Item_Name { get; set; }
		public string Batch_Number { get; set; }
		public string Su_No { get; set; }
		public string Palletcode { get; set; }
		public Decimal? Pallet_Qty { get; set; }
		public Decimal? Need_Qty { get; set; }
		public Decimal? Payqty { get; set; }
		public Int32? State { get; set; }
		public DateTime? Ctime { get; set; }
		public DateTime? Mtime { get; set; }
		public DateTime? Stime { get; set; }
	}
}
