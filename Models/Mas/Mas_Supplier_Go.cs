using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Mas
{
	public class Mas_Supplier_Go
	{

		public Int64? Efidx { get; set; }
		public Int32? Efstatus { get; set; }
		public DateTime? Created { get; set; }
		public DateTime? Modified { get; set; }
		public Int64? Innovator { get; set; }
		public string Device { get; set; }
		public string Supcode { get; set; }
		public string Supname { get; set; }
		public string Supaddress { get; set; }
		public string Suptel { get; set; }
		public string Supfax { get; set; }
		public string Supemail { get; set; }
		public string Supcontract { get; set; }

	}
}
