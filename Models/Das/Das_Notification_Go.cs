using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Das
{
    public class Das_Notification_Go
    {
		public Int64? Efidx { get; set; }
		public Int32? Efstatus { get; set; }
		public DateTime? Created { get; set; }
		public DateTime? Modified { get; set; }
		public Int64? Innovator { get; set; }
		public string Device { get; set; }
		public string Msgfrom { get; set; }
		public string Msgname { get; set; }
		public DateTime? Msgtime { get; set; }
		public Int32? Msgpriority { get; set; }
		public string Description { get; set; }
	}
}
