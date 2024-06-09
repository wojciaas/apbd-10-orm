using apbd_10_orm.Models;
using apbd_10_orm.Services;
using Microsoft.AspNetCore.Mvc;

namespace apbd_10_orm.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HospitalController : ControllerBase
{
    private readonly IHospitalService _hospitalService;

    public HospitalController(IHospitalService hospitalService)
    {
        _hospitalService = hospitalService;
    }

    [HttpPost("prescriptions/add")]
    public async Task<IActionResult> AddPrescription(PrescriptionRequestDto prescriptionRequestDto)
    {
        await _hospitalService.AddPrescriptionAsync(prescriptionRequestDto);
        return Ok();
    }
    
    [HttpGet("patients/{id:int}")]
    public async Task<IActionResult> GetPatient(int id)
    {
        return Ok(await _hospitalService.GetPatientByIdAsync(id));
    }
}