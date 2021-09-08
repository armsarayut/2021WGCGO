using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GoWMS.Server.Models.Oub;
using System.Threading;

namespace GoWMS.Server.DataAccess
{
    public interface IDataContext
    {
        DbSet<Oub_Deliveryorder_Go> OubDeliveryorderGos { get; init; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
