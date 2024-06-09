using apbd_10_orm.Models;

namespace apbd_10_orm.Services;

public interface IPrescriptionService
{
    public Task AddPrescriptionAsync(PrescriptionRequestDto prescriptionRequestDto);
}