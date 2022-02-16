using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Data;
using GoWMS.Server.Models;

namespace GoWMS.Server.Controllers
{
    public class PublicFunServices
    {
        readonly FunDAL objDAL = new FunDAL();


        public List<FucCreateRunning> GetRunningList(string sCode, int iPad)
        {
            List<FucCreateRunning> retlist = objDAL.GetRunningList(sCode, iPad).ToList();
            return retlist;
        }

        public string GetRunning(string sCode, int iPad)
        {
            string sRunning;
            sRunning = objDAL.GetRunning(sCode, iPad);
            return sRunning;
        }


    }
}
