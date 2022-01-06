using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Das
{
    public class DasLocation
    {
		public Int64? Efidx { get; set; }
		public Int32? Efstatus { get; set; }
		public DateTime? Created { get; set; }
		public DateTime? Modified { get; set; }
		public Int64? Innovator { get; set; }
		public string Device { get; set; }
		public string Whcode { get; set; }
		public string Lane { get; set; }
		public Int32? Loctotal { get; set; }
		public Int32? Locuse { get; set; }
		public Int32? Locempty { get; set; }
		public string Description { get; set; }
	}
}
