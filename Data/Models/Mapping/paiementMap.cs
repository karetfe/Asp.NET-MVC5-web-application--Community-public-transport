using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class paiementMap : EntityTypeConfiguration<paiement>
    {
        public paiementMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.reference)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("t_paiement", "transportdb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.codeCVV2).HasColumnName("codeCVV2");
            this.Property(t => t.confidentialCode).HasColumnName("confidentialCode");
            this.Property(t => t.numberCarteBancaire).HasColumnName("numberCarteBancaire");
            this.Property(t => t.reference).HasColumnName("reference");
        }
    }
}
