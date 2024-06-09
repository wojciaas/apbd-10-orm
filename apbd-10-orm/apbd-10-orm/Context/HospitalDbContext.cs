using apbd_10_orm.Entities;
using Microsoft.EntityFrameworkCore;

namespace apbd_10_orm.Context
{
    public class HospitalDbContext : DbContext
    {
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Medicament> Medicaments { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }

        public HospitalDbContext()
        {
        }

        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HospitalDbContext).Assembly);
        }
    }
}