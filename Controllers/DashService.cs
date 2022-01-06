using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Data;
using GoWMS.Server.Models;
using GoWMS.Server.Models.Das;
using GoWMS.Server.Models.Public;

namespace GoWMS.Server.Controllers
{
    public class DashService
    {
        readonly DashDAL objDAL = new DashDAL();

        public List<Vrpt_operationresult_sum> GetAllOrderofDay()
        {
            List<Vrpt_operationresult_sum> retlist = objDAL.GetAllOrderofDay().ToList();
            return retlist;
        }
            public List<Vrpt_shelfsummary> GetAllLocationSummary()
        {
            List<Vrpt_shelfsummary> retlist = objDAL.GetAllLocationSummary().ToList();
            return retlist;
        }

        public List<VLocationDash> GetAllTasworkofday()
        {
            List<VLocationDash> retlist = objDAL.GetAllTasworkofday().ToList();
            return retlist;
        }
    }
}
