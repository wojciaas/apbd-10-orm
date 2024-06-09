using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apbd_10_orm.Entities.Configs
{
    public class PatientEfConfig : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(p => p.IdPatient);
            builder.Property(p => p.IdPatient).UseIdentityColumn();
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.BirthDate).IsRequired().HasColumnType("datetime");

            builder.ToTable("Patient");
        }
    }
}

