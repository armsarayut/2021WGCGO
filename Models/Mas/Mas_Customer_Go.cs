using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Mas
{
	public class Mas_Customer_Go
	{

		public Int64? Efidx { get; set; }
		public Int32? Efstatus { get; set; }
		public DateTime? Created { get; set; }
		public DateTime? Modified { get; set; }
		public Int64? Innovator { get; set; }
		public string Device { get; set; }
		public string Cuscode { get; set; }
		public string Cusname { get; set; }
		public string Cusaddress { get; set; }
		public string Custel { get; set; }
		public string Cusfax { get; set; }
		public string Cusemail { get; set; }
		public string Cuscontract { get; set; }

	}
}
