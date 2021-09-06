using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Wgc
{
    public class PACKETINGS
    {
		public string PACKETING_CODE { get; set; }
		public string PACKETING_NAME { get; set; }
		public decimal? PACKAGE_WEIGHT { get; set; }
		public string ITEM_CODE { get; set; }
		public string PACKAGE_TPYE { get; set; }
		public string ITEM_UM { get; set; }
		public decimal? TARE_WEIGHT { get; set; }
		public decimal? GROSS_WEIGHT { get; set; }
	}
}
