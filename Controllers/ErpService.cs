using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Data;
using GoWMS.Server.Models;
using GoWMS.Server.Models.Erp;
using GoWMS.Server.Models.Api;


namespace GoWMS.Server.Controllers
{
    public class ErpService
    {
        readonly ErpDAL objDAL = new ErpDAL();

        public List<V_Receiving_OrdersInfo> GetAllErpReceivingOrders()
        {
            List<V_Receiving_OrdersInfo> ListRet = objDAL.GetAllErpReceivingOrders().ToList();
            return ListRet;
        }

        public List<V_CylinderInfo> GetAllErpCylinders()
        {
            List<V_CylinderInfo> ListRet = objDAL.GetAllErpCylinders().ToList();
            return ListRet;
        }

        public Task<IEnumerable<V_List_OF_Materials_NeedsInfo>> GetAllErpListofNeeds()
        {
            //List<V_List_OF_Materials_NeedsInfo> ListRet = objDAL.GetAllErpListofNeeds().ToList();
            return objDAL.GetAllErpListofNeeds();
        }

        public List<Api_Deliveryorder_Go> GetAllErpListofNeedsbyMo(string mocode)
        {
            List<Api_Deliveryorder_Go> ListRet = objDAL.GetAllErpListofNeedsByMo(mocode).ToList();
            return ListRet;
        }

        public List<V_Reserved_MaterialsInfo> GetAllErpReservedMaterials()
        {
            List<V_Reserved_MaterialsInfo> ListRet = objDAL.GetAllErpReservedMaterials().ToList();
            return ListRet;
        }
        public List<Api_Deliveryorder_Go> GetAllErpReservedMaterialsbyMo(string mocode)
        {
            List<Api_Deliveryorder_Go> ListRet = objDAL.GetAllErpReservedMaterialsbyMo(mocode).ToList();
            return ListRet;
        }

        public List<MaterialInfo> GetAllErpMatReceivingOrders()
        {
            List<MaterialInfo> ListRet = objDAL.GetAllErpMatReceivingOrders().ToList();
            return ListRet;
        }

        public List<Api_Receivingorders_Go> GetErpMatReceivingOrdersByTag(string Tag)
        {
            List<Api_Receivingorders_Go> ListRet = objDAL.GetErpReceivingOrdersByTag(Tag).ToList();
            return ListRet;
        }


    }
}
