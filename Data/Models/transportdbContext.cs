using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Data.Models.Mapping;
using Domain.Entities;

namespace Data.Models
{
    public partial class transportdbContext : DbContext
    {
        static transportdbContext()
        {
            Database.SetInitializer<transportdbContext>(null);
        }

        public transportdbContext()
            : base("Name=transportdbContext")
        {
        }

        public DbSet<city> cities { get; set; }
        public DbSet<message> messages { get; set; }
        public DbSet<paiement> paiement { get; set; }
        public DbSet<personaltrans> personaltrans { get; set; }
        public DbSet<planning> planning { get; set; }
        public DbSet<subscription> subscription { get; set; }
        public DbSet<transportationmean> transportationmeans { get; set; }
        public DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new cityMap());
            modelBuilder.Configurations.Add(new messageMap());
            modelBuilder.Configurations.Add(new paiementMap());
            modelBuilder.Configurations.Add(new personaltransMap());
            modelBuilder.Configurations.Add(new planningMap());
            modelBuilder.Configurations.Add(new subscriptionMap());
            modelBuilder.Configurations.Add(new transportationmeanMap());
            modelBuilder.Configurations.Add(new userMap());
        }
    }
}
