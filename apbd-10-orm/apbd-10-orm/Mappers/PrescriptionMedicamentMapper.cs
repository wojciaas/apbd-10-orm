using apbd_10_orm.Entities;
using apbd_10_orm.Models;

namespace apbd_10_orm.Mappers;

public static class PrescriptionMedicamentMapper
{
    public static MedicamentResponseDto MapToResponseModel(this PrescriptionMedicament prescriptionMedicament)
    {
        return new MedicamentResponseDto(
            IdMedicament:prescriptionMedicament.IdMedicament,
            Name:prescriptionMedicament.Medicament.Name,
            Dose:prescriptionMedicament.Dose,
            Description:prescriptionMedicament.Medicament.Description
        );
    }
}