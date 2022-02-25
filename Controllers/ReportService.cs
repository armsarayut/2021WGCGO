using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Data;

namespace GoWMS.Server.Controllers
{
    public class ReportService
    {
        readonly ReportDAL objDAL = new ReportDAL();

        public Boolean InsertAudittrial(String actdesc, String munname)
        {
            bool bRet = objDAL.InsertAudittrial(actdesc, munname,0);

            return bRet;
        }
        public Boolean InsertAudittrial(String actdesc, String munname, long user)
        {
            bool bRet = objDAL.InsertAudittrial(actdesc, munname, user);

            return bRet;
        }
    }
}
