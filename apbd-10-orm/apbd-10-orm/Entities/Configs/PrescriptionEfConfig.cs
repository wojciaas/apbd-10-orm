using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apbd_10_orm.Entities.Configs
{
    public class PrescriptionEfConfig : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.HasKey(pr => pr.IdPrescription);
            builder.Property(pr => pr.IdPrescription).UseIdentityColumn();
            builder.Property(pm => pm.Date).IsRequired().HasColumnType("datetime");
            builder.Property(pm => pm.DueDate).IsRequired().HasColumnType("datetime");
            builder.HasOne(pr => pr.Patient)
                .WithMany(p => p.Prescriptions)
                .HasForeignKey(pr => pr.IdPatient)
                .HasConstraintName("Patient_Prescription")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(pr => pr.Doctor)
                .WithMany(d => d.Prescriptions)
                .HasForeignKey(pr => pr.IdDoctor)
                .HasConstraintName("Prescription_Doctor")
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Prescription");
        }
    }
}