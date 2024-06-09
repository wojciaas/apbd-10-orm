using apbd_10_orm.Models;

namespace apbd_10_orm.Services;

public interface IHospitalService
{
    public Task AddPrescriptionAsync(PrescriptionRequestDto prescriptionRequestDto);
    public Task<PatientResponseDto> GetPatientByIdAsync(int id);
}