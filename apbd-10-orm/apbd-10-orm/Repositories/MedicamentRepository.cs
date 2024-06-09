using apbd_10_orm.Context;
using apbd_10_orm.Entities;
using Microsoft.EntityFrameworkCore;

namespace apbd_10_orm.Repositories;

public class MedicamentRepository : IMedicamentRepository
{
    private readonly HospitalDbContext _dbContext;

    public MedicamentRepository(HospitalDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Medicament?> GetMedicamentByIdAsync(int id)
    {
        return await _dbContext.Medicaments
            .FirstOrDefaultAsync(m => m.IdMedicament == id);
    }
}