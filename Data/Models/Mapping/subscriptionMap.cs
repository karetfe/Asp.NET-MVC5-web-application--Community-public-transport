using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class subscriptionMap : EntityTypeConfiguration<subscription>
    {
        public subscriptionMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.titel)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("t_subscription", "transportdb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.expiration_date).HasColumnName("expiration_date");
            this.Property(t => t.picture).HasColumnName("picture");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.sector).HasColumnName("sector");
            this.Property(t => t.start_date).HasColumnName("start_date");
            this.Property(t => t.titel).HasColumnName("titel");
            this.Property(t => t.typeSub).HasColumnName("typeSub");
            this.Property(t => t.client_fk).HasColumnName("client_fk");
            this.Property(t => t.manager_fk).HasColumnName("manager_fk");

            // Relationships
            this.HasOptional(t => t.user)
                .WithMany(t => t.subscription)
                .HasForeignKey(d => d.client_fk);
            this.HasOptional(t => t.user1)
                .WithMany(t => t.subscription1)
                .HasForeignKey(d => d.manager_fk);

        }
    }
}
