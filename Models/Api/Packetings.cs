using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Api
{
    public class Packetings
    {
		public Int64? Efidx { get; set; }
		public Int32? Efstatus { get; set; }
		public DateTime? Created { get; set; }
		public DateTime? Modified { get; set; }
		public Int64? Innovator { get; set; }
		public String Device { get; set; }
		public String Packeting_code { get; set; }
		public String Packeting_name { get; set; }
		public Decimal? Package_weight { get; set; }
		public String Item_code { get; set; }
		public String Package_tpye { get; set; }
		public String Item_um { get; set; }
		public String Package_type { get; set; }
		public Decimal? Tare_weight { get; set; }
		public Decimal? Gross_weight { get; set; }
	}
}
