using GoWMS.Server.Models.Oub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GoWMS.Server.DataAccess
{
    public class DataAccessProvider: IDataAccessProvider
    {
        private readonly PostgreSqlContext _context;

        public DataAccessProvider(PostgreSqlContext context)
        {
            _context = context;
        }

        public void AddOubDeliveryorderRecord(Oub_Deliveryorder_Go Deliveryorder_Go)
        {
            //_context.OubDeliveryorders.Add(Deliveryorder_Go);
            _context.SaveChanges();
        }

        public void DeleteOubDeliveryorderRecord(long idx)
        {
            throw new NotImplementedException();
        }

        public List<Oub_Deliveryorder_Go> GetOubDeliveryorderRecords()
        {
            throw new NotImplementedException();
        }

        public Oub_Deliveryorder_Go GetOubDeliveryorderSingleRecord(long id)
        {
            throw new NotImplementedException();
        }

        public void UpdateOubDeliveryorderRecord(Oub_Deliveryorder_Go Deliveryorder_Go)
        {
            throw new NotImplementedException();
        }
    }
}
