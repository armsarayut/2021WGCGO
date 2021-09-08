using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.DataAccess;
using GoWMS.Server.Models.Oub;

namespace GoWMS.Server.Repositories
{
    public class OubDeliveryorderRepository : IOubDeliveryorderRepository
    {
        private readonly IDataContext _context;
        public OubDeliveryorderRepository(IDataContext context)
        {
            _context = context;
        }

        public Task Add(Oub_Deliveryorder_Go OubDeliveryorder)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Oub_Deliveryorder_Go> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Oub_Deliveryorder_Go>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(Oub_Deliveryorder_Go OubDeliveryorder)
        {
            throw new NotImplementedException();
        }
    }
}
