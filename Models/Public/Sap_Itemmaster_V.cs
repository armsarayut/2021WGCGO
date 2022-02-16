using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Public
{
    public class Sap_Itemmaster_V
    {
		public Int64? Idx { get; set; }
		public DateTime? Created { get; set; }
		public Int32? Entity_Lock { get; set; }
		public DateTime? Modified { get; set; }
		public Int64? Client_Id { get; set; }
		public string Client_Ip { get; set; }
		public string Item_Code { get; set; }
		public string Article { get; set; }
		public string Item_Name { get; set; }
		public string Mc_Code { get; set; }
		public string Uom { get; set; }
		public string Brand { get; set; }
		public string Tile_Size { get; set; }
		public string Tem_Flag { get; set; }
		public string Vendor { get; set; }
		public Decimal? Gross_Weight { get; set; }
		public string Weight_Unit { get; set; }
		public string Pack_Size_Box { get; set; }
		public string Pack_Size_Pal { get; set; }
		public string Batch_Management { get; set; }
		public string Class_Flag { get; set; }
		public string Consign_Flag { get; set; }
	}
}
