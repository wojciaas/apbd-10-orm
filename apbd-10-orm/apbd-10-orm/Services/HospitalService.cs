using apbd_10_orm.Entities;
using apbd_10_orm.Exceptions;
using apbd_10_orm.Models;

namespace apbd_10_orm.Services;

public class HospitalService : IHospitalService
{
    private readonly IPrescriptionService _prescriptionService;
    private readonly IPatientService _patientService;
    private readonly IMedicamentService _medicamentService;

    public HospitalService(IPrescriptionService prescriptionService, IPatientService patientService, MedicamentService medicamentService)
    {
        _prescriptionService = prescriptionService;
        _patientService = patientService;
    }


    public async Task AddPrescriptionAsync(PrescriptionRequestDto prescriptionRequestDto)
    {
        (
                PatientRequestDto patient, 
                List<MedicamentRequestDto> medicaments, 
                DateTime date, 
                DateTime dueDate
        ) = prescriptionRequestDto;
        try
        {
            await _patientService.GetPatientByIdAsync(patient.IdPatient);
        }
        catch (DomainException ignored)
        {
            await _patientService.AddPatientAsync(patient);
        }
        
        List<Medicament> meds = new List<Medicament>();
        EnsureMedicamentsLessThan10(meds);
        foreach (var vmMedicament in medicaments)
        {
            meds.Add(await _medicamentService.GetMedicamentByIdAsync(vmMedicament.IdMedicament));
        }
        EnsureDueDateIsAfterOrEqualDate(date, dueDate);
        await _prescriptionService.AddPrescriptionAsync(new Prescription
        {
            Date = date,
            DueDate = dueDate,
            IdPatient = patient.IdPatient,
            IdDoctor = 1,
            Medicaments = meds
        });
    }

    private void EnsureMedicamentsLessThan10(List<Medicament> meds)
    {
        if (meds.Count > 10)
        {
            throw new DomainException($"The amount of medicaments is greater than 10.");
        }
    }
    
    private void EnsureDueDateIsAfterOrEqualDate(DateTime date, DateTime dueDate)
    {
        if (dueDate < date)
        {
            throw new DomainException($"Due date {dueDate} is before the date {date}.");
        }
    }

    public async Task<PatientResponseDto> GetPatientByIdAsync(int id)
    {
        return await _patientService.GetPatientByIdAsync(id);
    }
}