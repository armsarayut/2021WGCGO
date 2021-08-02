using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Api
{
	public class Api_Reservedmaterials_Go
	{

		public Int64? Efidx { get; set; }
		public Int32? Efstatus { get; set; }
		public DateTime? Created { get; set; }
		public DateTime? Modified { get; set; }
		public Int64? Innovator { get; set; }
		public string Device { get; set; }
		public string Package_Id { get; set; }
		public string Roll_Id { get; set; }
		public string Material_Code { get; set; }
		public string Material_Description { get; set; }
		public Decimal? Quantity { get; set; }
		public string Unit { get; set; }
		public string Wh_Code { get; set; }
		public string Warehouse { get; set; }
		public string Locationno { get; set; }
		public string Job { get; set; }
		public string Job_Code { get; set; }
		public string Mo_Barcode { get; set; }

	}
}
