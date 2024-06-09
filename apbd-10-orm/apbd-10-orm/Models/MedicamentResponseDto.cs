namespace apbd_10_orm.Models;

public record MedicamentResponseDto(
    int IdMedicament,
    string Name,
    int? Dose,
    string Description
    );