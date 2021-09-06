using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Api
{
    public class Customers
    {
		public Int64? Efidx { get; set; }
		public Int32? Efstatus { get; set; }
		public DateTime Created { get; set; }
		public DateTime Modified { get; set; }
		public Int64? Innovator { get; set; }
		public String Device { get; set; }
		public String Customer_code { get; set; }
		public String Cust_name_thai { get; set; }
		public String Status { get; set; }
	}
}
