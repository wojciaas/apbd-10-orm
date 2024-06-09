namespace apbd_10_orm.Models;

public record PatientResponseDto(
    int IdPatient,
    string FirstName,
    string LastName,
    DateTime BirthDate,
    List<PrescriptionResponseDto> Prescriptions
    );