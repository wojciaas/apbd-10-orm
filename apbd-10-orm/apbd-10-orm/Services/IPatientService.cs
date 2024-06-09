using apbd_10_orm.Models;

namespace apbd_10_orm.Services;

public interface IPatientService
{
    public Task<PatientResponseDto> GetPatientByIdAsync(int id);
    public Task AddPatientAsync(PatientRequestDto patient);
}