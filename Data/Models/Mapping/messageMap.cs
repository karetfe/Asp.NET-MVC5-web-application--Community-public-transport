using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class messageMap : EntityTypeConfiguration<message>
    {
        public messageMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.subject)
                .HasMaxLength(255);

            this.Property(t => t.type)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("message", "transportdb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.subject).HasColumnName("subject");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.client_fk).HasColumnName("client_fk");

            // Relationships
            this.HasOptional(t => t.user)
                .WithMany(t => t.messages)
                .HasForeignKey(d => d.client_fk);

        }
    }
}
