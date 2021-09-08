using Microsoft.EntityFrameworkCore;
using GoWMS.Server.Models;
using GoWMS.Server.Models.Oub;
using System.Collections.Generic;
using System;

namespace GoWMS.Server.DataAccess
{
    public interface IDataAccessProvider
    {
        void AddOubDeliveryorderRecord(Oub_Deliveryorder_Go Deliveryorder_Go);
        void UpdateOubDeliveryorderRecord(Oub_Deliveryorder_Go Deliveryorder_Go);
        void DeleteOubDeliveryorderRecord(Int64 idx);
        Oub_Deliveryorder_Go GetOubDeliveryorderSingleRecord(Int64 id);
        List<Oub_Deliveryorder_Go> GetOubDeliveryorderRecords();
    }
}
