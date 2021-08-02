using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Oub
{
	public class Oub_Retrieval_Go
	{

		public Int64? Efidx { get; set; }
		public Int32? Efstatus { get; set; }
		public DateTime? Created { get; set; }
		public DateTime? Modified { get; set; }
		public Int64? Innovator { get; set; }
		public string Device { get; set; }
		public string Loadkey { get; set; }
		public string Loadtype { get; set; }
		public Int32? Priority { get; set; }
		public string Palletno { get; set; }
		public DateTime? Started { get; set; }
		public DateTime? Loadted { get; set; }
		public DateTime? Completed { get; set; }
		public string Storageno { get; set; }
		public string Storagearea { get; set; }
		public string Storagebin { get; set; }

	}
}
