using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class transportationmeanMap : EntityTypeConfiguration<transportationmean>
    {
        public transportationmeanMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.fuel)
                .HasMaxLength(255);

            this.Property(t => t.mark)
                .HasMaxLength(255);

            this.Property(t => t.model)
                .HasMaxLength(255);

            this.Property(t => t.picture)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("transportationmean", "transportdb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.circulation_date).HasColumnName("circulation_date");
            this.Property(t => t.fuel).HasColumnName("fuel");
            this.Property(t => t.km).HasColumnName("km");
            this.Property(t => t.mark).HasColumnName("mark");
            this.Property(t => t.model).HasColumnName("model");
            this.Property(t => t.nmbrPlaces).HasColumnName("nmbrPlaces");
            this.Property(t => t.picture).HasColumnName("picture");
            this.Property(t => t.registrationNumber).HasColumnName("registrationNumber");
        }
    }
}
