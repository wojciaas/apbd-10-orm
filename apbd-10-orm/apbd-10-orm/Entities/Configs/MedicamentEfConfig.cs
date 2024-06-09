using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apbd_10_orm.Entities.Configs
{
    public class MedicamentEfConfig : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder.HasKey(m => m.IdMedicament);
            builder.Property(m => m.IdMedicament).UseIdentityColumn();
            builder.Property(m => m.Name).IsRequired().HasMaxLength(100);
            builder.Property(m => m.Description).IsRequired().HasMaxLength(100);
            builder.Property(m => m.Type).IsRequired().HasMaxLength(100);

            builder.ToTable("Medicament");
        }
    }
}