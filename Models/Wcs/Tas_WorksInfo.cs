using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models.Wcs
{
    public class Tas_WorksInfo
    {
        public Int64? Idx { get; set; }

        public DateTime? Created { get; set; }

        public Int32? Entity_Lock { get; set; }

        public DateTime? Modified { get; set; }

        public Int64? Client_Id { get; set; }

        public string Client_Ip { get; set; }

        public string Su_No { get; set; }

        public string Lpncode { get; set; }

        public string Work_Code { get; set; }

        public string Work_Status { get; set; }

        public string Work_Srm { get; set; }

        public string Work_Location { get; set; }

        public Decimal? Work_Weight { get; set; }

        public Decimal? Actual_Weight { get; set; }

        public Int32? Work_Size { get; set; }

        public Int32? Actual_Size { get; set; }

        public string Work_Gate { get; set; }

        public string Work_Ref { get; set; }

        public DateTime? Ctime { get; set; }

        public DateTime? Stime { get; set; }

        public DateTime? Etime { get; set; }

        public Int32? Work_Priority { get; set; }
    }
}
