using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Rpt
{
    public class Rpt_Audittrial_Go
    {
		public Int64? Efidx { get; set; }
		public Int32? Efstatus { get; set; }
		public DateTime? Created { get; set; }
		public DateTime? Modified { get; set; }
		public Int64? Innovator { get; set; }
		public string Device { get; set; }
		public string Menu_Name { get; set; }
		public string Action_Desc { get; set; }
	}
}
