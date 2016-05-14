using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class cityMap : EntityTypeConfiguration<city>
    {
        public cityMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.picture)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("city", "transportdb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.latitude).HasColumnName("latitude");
            this.Property(t => t.longitude).HasColumnName("longitude");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.picture).HasColumnName("picture");
        }
    }
}
