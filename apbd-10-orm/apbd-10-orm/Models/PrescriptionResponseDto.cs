namespace apbd_10_orm.Models;

public record PrescriptionResponseDto(
    int IdPrescription,
    DateTime Date,
    DateTime DueDate,
    List<MedicamentResponseDto> Medicaments,
    DoctorResponseDto Doctor
    );