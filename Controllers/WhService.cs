using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Data;
using GoWMS.Server.Models;
using Microsoft.AspNetCore.Mvc;


namespace GoWMS.Server.Controllers
{
    public class WhService
    {
        readonly WarehouseDAL objDAL = new WarehouseDAL();
        public List<WhStorageCapacity> GetWhStorageCapacities()
        {
            List<WhStorageCapacity> lisRet = objDAL.GetStorageCapacities().ToList();
            return lisRet;
        }

        public List<WhStorageList> GetWhStorageLists()
        {
            List<WhStorageList> lisRet = objDAL.GetStorageLists().ToList();
            return lisRet;
        }

    }
}
