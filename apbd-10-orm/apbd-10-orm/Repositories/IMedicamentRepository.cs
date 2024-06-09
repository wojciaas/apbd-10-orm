using apbd_10_orm.Entities;

namespace apbd_10_orm.Repositories;

public interface IMedicamentRepository
{
    public Task<Medicament?> GetMedicamentByIdAsync(int id);
}