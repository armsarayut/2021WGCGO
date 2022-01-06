using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Data;
using GoWMS.Server.Models;

namespace GoWMS.Server.Controllers
{
    public class AdminController
    {
        readonly AdminDAL objDAL = new AdminDAL();

        public List<Current_role> GetPageRole(string pageid, Int64 groupid)
        {
            List<Current_role> ListRet = objDAL.GetPageRole(pageid, groupid).ToList();
            return ListRet;
        }

    }
}
