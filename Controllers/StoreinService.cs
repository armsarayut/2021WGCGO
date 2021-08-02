using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Data;
using GoWMS.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoWMS.Server.Controllers
{
    public class StoreinService
    {
        readonly DaldbPgStorein objDAL = new DaldbPgStorein();

        public List<Sap_Storein> GetAllStorein()
        {
            List<Sap_Storein> lisRet = objDAL.GetAllStorein().ToList();
            return lisRet;
        }
    }
}
