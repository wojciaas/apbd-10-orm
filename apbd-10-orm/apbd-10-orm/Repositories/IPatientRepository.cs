using apbd_10_orm.Entities;

namespace apbd_10_orm.Repositories;

public interface IPatientRepository
{
    public Task<Patient?> GetPatientByIdAsync(int id);
    public Task AddPatientAsync(Patient patient);
}