using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class personaltransMap : EntityTypeConfiguration<personaltrans>
    {
        public personaltransMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.arrivalPlace)
                .HasMaxLength(255);

            this.Property(t => t.description)
                .HasMaxLength(1073741823);

            this.Property(t => t.startPlace)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("t_personaltrans", "transportdb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.arrivalPlace).HasColumnName("arrivalPlace");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.startPlace).HasColumnName("startPlace");
            this.Property(t => t.client_fk).HasColumnName("client_fk");

            // Relationships
            this.HasOptional(t => t.user)
                .WithMany(t => t.personaltrans)
                .HasForeignKey(d => d.client_fk);

        }
    }
}
