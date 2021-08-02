using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Data;
using GoWMS.Server.Models;
using GoWMS.Server.Models.Mas;

namespace GoWMS.Server.Controllers
{
    public class MasService
    {
        readonly MasDAL objDAL = new MasDAL();

        public List<Mas_Pallet_Go> GetAllMasterPallets()
        {
            List<Mas_Pallet_Go> retlist = objDAL.GetAllMasterpalletGo().ToList();
            return retlist;
        }

        public List<Mas_Storagebin_Go> GetAllMasterStorageBins()
        {
            List<Mas_Storagebin_Go> retlist = objDAL.GetAllStorageBinGo().ToList();
            return retlist;
        }

        public List<Mas_Item_Go> GetAllMasterItems()
        {
            List<Mas_Item_Go> retlist = objDAL.GetAllMasteritemGo().ToList();
            return retlist;
        }

    }
}
