using apbd_10_orm.Models;
using apbd_10_orm.Repositories;

namespace apbd_10_orm.Services;

public class PrescriptionService : IPrescriptionService
{
    private readonly IPrescriptionRepository _prescriptionRepository;
    private readonly IPatientRepository _patientRepository;

    public PrescriptionService(IPrescriptionRepository prescriptionRepository, IPatientRepository patientRepository)
    {
        _prescriptionRepository = prescriptionRepository;
        _patientRepository = patientRepository;
    }

    public Task AddPrescriptionAsync(PrescriptionRequestDto prescriptionRequestDto)
    {
        throw new NotImplementedException();
    }
    
    
}