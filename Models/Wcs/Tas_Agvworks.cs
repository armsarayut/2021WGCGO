using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Wcs
{
    public class Tas_Agvworks
    {
		public Int64? Idx { get; set; }
		public DateTime? Created { get; set; }
		public Int32? Entity_Lock { get; set; }
		public DateTime? Modified { get; set; }
		public Int64? Client_Id { get; set; }
		public string Client_Ip { get; set; }
		public string Lpncode { get; set; }
		public string Work_Code { get; set; }
		public Int32? Work_Status { get; set; }
		public Int64? Work_Id { get; set; }
		public string Agv_Name { get; set; }
		public string Gate_Source { get; set; }
		public string Gate_Dest { get; set; }
		public DateTime? Ctime { get; set; }
		public DateTime? Stime { get; set; }
		public DateTime? Etime { get; set; }
		public Int32? Work_Priority { get; set; }
	}
}
