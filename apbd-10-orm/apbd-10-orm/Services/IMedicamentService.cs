using apbd_10_orm.Entities;

namespace apbd_10_orm.Services;

public interface IMedicamentService
{
    public Task<Medicament> GetMedicamentByIdAsync(int id);
}