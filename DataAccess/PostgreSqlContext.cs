using Microsoft.EntityFrameworkCore;
using GoWMS.Server.Models;
using GoWMS.Server.Models.Oub;


namespace GoWMS.Server.DataAccess
{
    public class PostgreSqlContext: DbContext, IDataContext
    {
        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options) : base(options)
        {

        }
        DbSet<Oub_Deliveryorder_Go> IDataContext.OubDeliveryorderGos { get; init ; }
    }
}
