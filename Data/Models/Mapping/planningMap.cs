using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class planningMap : EntityTypeConfiguration<planning>
    {
        public planningMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.title)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("t_planning", "transportdb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.heureDepart).HasColumnName("heureDepart");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.city_fk).HasColumnName("city_fk");
            this.Property(t => t.driver_fk).HasColumnName("driver_fk");
            this.Property(t => t.transportationMean_fk).HasColumnName("transportationMean_fk");

            // Relationships
            this.HasOptional(t => t.city)
                .WithMany(t => t.planning)
                .HasForeignKey(d => d.city_fk);
            this.HasOptional(t => t.user)
                .WithMany(t => t.planning)
                .HasForeignKey(d => d.driver_fk);
            this.HasOptional(t => t.transportationmean)
                .WithMany(t => t.planning)
                .HasForeignKey(d => d.transportationMean_fk);

        }
    }
}
