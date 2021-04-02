using System.Data.Entity;
using CustomerInterface;
using DataAccessLayerInterface;

namespace DataAccessLayerEf
{
    public class EfUow : DbContext, IUow
    {
        public EfUow() : base("name=ConnectionString")
        {
        }

        public void Commit()
        {
            SaveChanges();
        }

        public void Rollback()
        {
            Dispose();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerBase>().ToTable("Customer");
        }
    }
}