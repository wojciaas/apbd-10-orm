namespace apbd_10_orm.Models;

public record PrescriptionRequestDto(
    PatientRequestDto Patient,
    List<MedicamentRequestDto> Medicaments,
    DateTime Date,
    DateTime DueDate
    );