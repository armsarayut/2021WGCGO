using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Oub
{
	public class Oub_Prepareorder_Go
	{

		public Int64? Efidx { get; set; }
		public Int32? Efstatus { get; set; }
		public DateTime? Created { get; set; }
		public DateTime? Modified { get; set; }
		public Int64? Innovator { get; set; }
		public string Device { get; set; }
		public string Ordertype { get; set; }
		public string Docno { get; set; }
		public string Itemcode { get; set; }
		public string Itemtag { get; set; }
		public string Lotno { get; set; }
		public Decimal? Need { get; set; }
		public Decimal? Picked { get; set; }
		public Int64? Refapiid { get; set; }
	}
}
