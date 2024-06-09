using apbd_10_orm.Entities;
using apbd_10_orm.Exceptions;
using apbd_10_orm.Mappers;
using apbd_10_orm.Models;
using apbd_10_orm.Repositories;

namespace apbd_10_orm.Services;

public class PatientService : IPatientService
{
    private readonly IPatientRepository _patientRepository;

    public PatientService(IPatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
    }

    public async Task<PatientResponseDto> GetPatientByIdAsync(int id)
    {
        Patient? patient = await _patientRepository.GetPatientByIdAsync(id);
        EnsurePatientExist(patient, id);
        return patient!.MapToResponseModel();
    }

    private void EnsurePatientExist(Patient? patient, int id)
    {
        if (patient == null)
        {
            throw new DomainException($"Patient with id={id} does not exits.");
        }
    }

    public async Task AddPatientAsync(PatientRequestDto patient)
    {
        await _patientRepository.AddPatientAsync(new Patient
            {
                IdPatient = patient.IdPatient,
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                BirthDate = patient.BirthDate
            }
            );
    }
}