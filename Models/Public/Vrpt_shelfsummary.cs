using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Public
{
    public class Vrpt_shelfsummary
    {
        public string Srm_Name { get; set; }
        public Int32? Srm_No { get; set; }
        public Int64? Locavl { get; set; }
        public Int64? Locemp { get; set; }
        public Int64? Plemp { get; set; }
        public Int64? Plerr { get; set; }
        public Int64? Prohloc { get; set; }
        public Int64? Total { get; set; }
        public decimal? Percen { get; set; }

    }
}
