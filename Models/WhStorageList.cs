using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models
{
    public class WhStorageList
    {
         public Int64? Rn { get; set; }
        public Int32? Shelfno { get; set; }
        public string Shelfcode { get; set; }
        public string Shelfname { get; set; }
        public Int32? Srmno { get; set; }
        public Int16? Shelfbank { get; set; }
        public Int32? Shelfbay { get; set; }
        public Int16? Shelflevel { get; set; }
        public Int32? Shelfstatus { get; set; }
        public string Lpncode { get; set; }
        public Int32? Actualsize { get; set; }
        public string Descsize { get; set; }
        public string Stdesc { get; set; }
        public string Backcolor { get; set; }
        public string Focecolor { get; set; }
        public DateTime? Modified { get; set; }
    }
}
