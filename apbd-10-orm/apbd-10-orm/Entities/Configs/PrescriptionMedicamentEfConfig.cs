using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apbd_10_orm.Entities.Configs
{
    public class PrescriptionMedicamentEfConfig : IEntityTypeConfiguration<PrescriptionMedicament>
    {
        public void Configure(EntityTypeBuilder<PrescriptionMedicament> builder)
        {
            builder.HasKey(pm => new { pm.IdPrescription, pm.IdMedicament });
            builder.HasOne(pm => pm.Prescription)
                .WithMany(pr => pr.PrescriptionMedicaments)
                .HasForeignKey(pm => pm.IdPrescription)
                .HasConstraintName("PrescriptionMedicament_Prescription");
            builder.HasOne(pm => pm.Medicament)
                .WithMany(m => m.PrescriptionMedicaments)
                .HasForeignKey(pm => pm.IdMedicament)
                .HasConstraintName("PrescriptionMedicament_Medicament");

            builder.ToTable("Prescription_Medicament");
        }
    }
}