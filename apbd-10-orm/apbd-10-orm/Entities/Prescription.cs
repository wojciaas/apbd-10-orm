namespace apbd_10_orm.Entities
{
    public class Prescription
    {
        public int IdPrescription { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }
        public virtual Patient Patient { get; set; } = null!;
        public virtual Doctor Doctor { get; set; } = null!;

        public virtual ICollection<PrescriptionMedicament> PrescriptionMedicaments { get; set; } =
            new List<PrescriptionMedicament>();
    }
}
