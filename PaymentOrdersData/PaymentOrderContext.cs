using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebApp.Models;

namespace PaymentOrdersData
{
    public class PaymentOrderContext : DbContext, IDbContext
    {
        public PaymentOrderContext() : base("WebAppContext")
        {

        }

        public DbSet<PaymentOrder> PaymentOrders { get; set; }

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }

        public new IDbSet<T> Set<T>() where T: class
        {
            return base.Set<T>();
        }
    }
}
