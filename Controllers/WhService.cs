﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Data;
using GoWMS.Server.Models;
using GoWMS.Server.Models.Public;
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

        public List<Sap_StoreoutInfo> GetPicklist(string sPallet)
        {
            List<Sap_StoreoutInfo> lisRet = objDAL.GetPicklist(sPallet).ToList();
            return lisRet;
        }

        public bool UpdateCount(List<Sap_StoreoutInfo> listupdate)
        {
            bool bRet = objDAL.UpdateCount(listupdate);
            return bRet;

        }
        public bool SapComplete(string sPallet)
        {
            bool bRet = objDAL.SapComplete(sPallet);
            return bRet;
        }


    }
}
