using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Data;
using GoWMS.Server.Models;
using GoWMS.Server.Models.Api;
using Microsoft.AspNetCore.Mvc;

namespace GoWMS.Server.Controllers
{
    public class ErpApiService
    {
        readonly ApiDAL objDAL = new ApiDAL();

        public List<Api_Itemmaster_Go> GetAllApiItemmasterGos()
        {
            List<Api_Itemmaster_Go> retlist = objDAL.GetAllApiItemmasterGo().ToList();
            return retlist;
        }

        public List<Api_Cylinder_Go> GetAllApiCylinderGos()
        {
            List<Api_Cylinder_Go> retlist = objDAL.GetAllApiCylinderGo().ToList();
            return retlist;
        }

        public List<Api_Listofmaterialsneeds_Go> GetAllApiListofNeedGos()
        {
            List<Api_Listofmaterialsneeds_Go> retlist = objDAL.GetAllApiListofNeedGo().ToList();
            return retlist;
        }

        public List<Api_Receivingorders_Go> GetAllApiRecevingorderGos()
        {
            List<Api_Receivingorders_Go> retlist = objDAL.GetAllApiRecevingorderGo().ToList();
            return retlist;
        }
        public List<Api_Reservedmaterials_Go> GetAllApiReservedmaterialGos()
        {
            List<Api_Reservedmaterials_Go> retlist = objDAL.GetAllApiReservedmaterialGo().ToList();
            return retlist;
        }

        public List<Api_Receivingorders_Go> GetAllApiRecevingorderGosypallet(string pallet)
        {
            List<Api_Receivingorders_Go> retlist = objDAL.GetApiRecevingorderGoBypallet(pallet).ToList();
            return retlist;
        }
        public string CancelReceivingOrderbypack(string pallet, string pack)
        {
            objDAL.CancelReceivingOrdersBypack(pallet, pack);
            return "Cancel Successfully";
        }

        public string UpdateReceivingOrderbypallet(string pallet)
        {
            objDAL.UpdateReceivingOrdersBypallet(pallet);
            return "Update Successfully";
        }

        public string UpdateReceivingOrderbypack(string pallet, string pack)
        {
            objDAL.UpdateReceivingOrdersBypack(pallet, pack);
            return "Update Successfully";
        }

        public string InsertReceivingOrderbypack(List<Api_Receivingorders_Go> listOrder, string pallet)
        {
            objDAL.InsertReceivingOrdersBypack(listOrder,pallet);
            return "Update Successfully";
        }

        public string SetMappedPallet(string pallet)
        {
            objDAL.SetMappPallet(pallet);
            return "Map Successfully";
        }

        public List<Api_Deliveryorder_Go> GetAllApiDeliveryorder()
        {
            List<Api_Deliveryorder_Go> retlist = objDAL.GetAllDeliveryorderGo().ToList();
            return retlist;
        }



    }
}
