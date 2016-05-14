using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class userMap : EntityTypeConfiguration<user>
    {
        public userMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.myDType)
                .IsRequired()
                .HasMaxLength(31);

            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.address)
                .HasMaxLength(255);

            this.Property(t => t.login)
                .HasMaxLength(255);

            this.Property(t => t.mail)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.password)
                .HasMaxLength(255);

            this.Property(t => t.picture)
                .HasMaxLength(255);

            this.Property(t => t.profession)
                .HasMaxLength(255);

            this.Property(t => t.fax)
                .HasMaxLength(255);

            this.Property(t => t.matricule)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("user", "transportdb");
            this.Property(t => t.myDType).HasColumnName("myDType");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.address).HasColumnName("address");
            this.Property(t => t.birth_date).HasColumnName("birth_date");
            this.Property(t => t.login).HasColumnName("login");
            this.Property(t => t.mail).HasColumnName("mail");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.picture).HasColumnName("picture");
            this.Property(t => t.profession).HasColumnName("profession");
            this.Property(t => t.fax).HasColumnName("fax");
            this.Property(t => t.phoneNumber).HasColumnName("phoneNumber");
            this.Property(t => t.drivingLicence).HasColumnName("drivingLicence");
            this.Property(t => t.matricule).HasColumnName("matricule");
        }
    }
}
