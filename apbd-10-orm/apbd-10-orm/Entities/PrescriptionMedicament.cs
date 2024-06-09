namespace apbd_10_orm.Entities
{
    public class PrescriptionMedicament
    {
        public int IdMedicament { get; set; }
        public int IdPrescription { get; set; }
        public int? Dose { get; set; }
        public string Details { get; set; } = null!;
        public virtual Medicament Medicament { get; set; } = null!;
        public virtual Prescription Prescription { get; set; } = null!;
    }   
}