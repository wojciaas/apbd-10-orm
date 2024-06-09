using apbd_10_orm.Entities;
using apbd_10_orm.Models;

namespace apbd_10_orm.Mappers;

public static class DoctorMapper
{
    public static DoctorResponseDto MapToResponseModel(this Doctor doctor)
    {
        return new DoctorResponseDto(
            IdDoctor:doctor.IdDoctor,
            FirstName:doctor.FirstName
        );
    }
}