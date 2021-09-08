using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Models.Oub;


namespace GoWMS.Server.Repositories
{
    public interface IOubDeliveryorderRepository
    {
        Task<Oub_Deliveryorder_Go> Get(long id);
        Task<IEnumerable<Oub_Deliveryorder_Go>> GetAll();
        Task Add(Oub_Deliveryorder_Go OubDeliveryorder);
        Task Delete(long id);
        Task Update(Oub_Deliveryorder_Go OubDeliveryorder);

    }
}
