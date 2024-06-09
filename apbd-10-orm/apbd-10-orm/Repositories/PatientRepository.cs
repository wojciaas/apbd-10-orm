using apbd_10_orm.Context;
using apbd_10_orm.Entities;
using Microsoft.EntityFrameworkCore;

namespace apbd_10_orm.Repositories;

public class PatientRepository : IPatientRepository
{
    private readonly HospitalDbContext _dbContext;

    public PatientRepository(HospitalDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Patient?> GetPatientByIdAsync(int id)
    {
        return await _dbContext.Patients
            .Include(p => p.Prescriptions)
            .ThenInclude(pr => pr.PrescriptionMedicaments)
            .ThenInclude(pm => pm.Medicament)
            .Include(p => p.Prescriptions)
            .ThenInclude(pr => pr.Doctor)
            .FirstOrDefaultAsync(p => p.IdPatient == id);;
    }

    public async Task AddPatientAsync(Patient patient)
    {
        await _dbContext.Patients.AddAsync(patient);
        await _dbContext.SaveChangesAsync();
    }
}