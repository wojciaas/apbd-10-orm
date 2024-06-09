using apbd_10_orm.Entities;
using apbd_10_orm.Models;

namespace apbd_10_orm.Mappers;

public static class PrescriptionMapper
{
    public static PrescriptionResponseDto MapToResponseModel(this Prescription prescription)
    {
        return new PrescriptionResponseDto(
            IdPrescription:prescription.IdPrescription,
            Date:prescription.Date,
            DueDate:prescription.DueDate,
            Medicaments:prescription.PrescriptionMedicaments.Select(pm => pm.MapToResponseModel()).ToList(),
            Doctor:prescription.Doctor.MapToResponseModel()
        );
    }
}