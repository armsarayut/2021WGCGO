using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models
{
    public class WhStorageCapacity
    {
        public Int64? Rn { get; set; }
        public string Srmname { get; set; }
        public Int32? Srmno { get; set; }
        public Int64? Locavlt1 { get; set; }
        public Int64? Locavlt2 { get; set; }
        public Int64? Locemp { get; set; }
        public Int64? Plemp { get; set; }
        public Int64? Perr { get; set; }
        public Int64? Prohloc { get; set; }
        public Int64? Total { get; set; }
        public decimal? OccRate { get; set; }
    }
}
