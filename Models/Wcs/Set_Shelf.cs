using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Wcs
{
    public class Set_Shelf
    {
		public Int64? Idx { get; set; }
		public DateTime? Created { get; set; }
		public Int32? Entity_Lock { get; set; }
		public DateTime? Modified { get; set; }
		public Int64? Client_Id { get; set; }
		public string Client_Ip { get; set; }
		public Int32? Store_No { get; set; }
		public Int32? Srm_No { get; set; }
		public Int32? Shelf_No { get; set; }
		public string Shelfcode { get; set; }
		public string Shelfname { get; set; }
		public Int16? Shelfbank { get; set; }
		public Int16? Shelfframe { get; set; }
		public Int32? Shelfbay { get; set; }
		public Int16? Shelflevel { get; set; }
		public Int32? Shelfstatus { get; set; }
		public Int16? Pickorder { get; set; }
		public string Lpncode { get; set; }
		public string Refercode { get; set; }
		public Decimal? Actual_Weight { get; set; }
		public Int32? Actual_Size { get; set; }
	}
}
