using apbd_10_orm.Entities;
using apbd_10_orm.Models;

namespace apbd_10_orm.Mappers;

public static class PatientMapper
{
    public static PatientResponseDto MapToResponseModel(this Patient patient)
    {
        return new PatientResponseDto(
            patient.IdPatient,
            patient.FirstName,
            patient.LastName,
            patient.BirthDate,
            patient.Prescriptions.Select(p => p.MapToResponseModel()).OrderBy(p => p.DueDate).ToList()
            );
    }
}