using apbd_10_orm.Entities;
using apbd_10_orm.Exceptions;
using apbd_10_orm.Repositories;

namespace apbd_10_orm.Services;

public class MedicamentService : IMedicamentService
{
    private readonly IMedicamentRepository _medicamentRepository;

    public MedicamentService(IMedicamentRepository medicamentRepository)
    {
        _medicamentRepository = medicamentRepository;
    }

    public async Task<Medicament> GetMedicamentByIdAsync(int id)
    {
        Medicament? medicament = await _medicamentRepository.GetMedicamentByIdAsync(id);
        EnsureMedicamentExists(medicament, id);
        return medicament!;
    }

    private void EnsureMedicamentExists(Medicament? medicament, int id)
    {
        if (medicament == null)
        {
            throw new DomainException($"Medicament with id={id} does not exits.");
        }
    }
}