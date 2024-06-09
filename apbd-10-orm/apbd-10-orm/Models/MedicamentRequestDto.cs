using System.ComponentModel.DataAnnotations;

namespace apbd_10_orm.Models;

public record MedicamentRequestDto(
    [Required]
    int IdMedicament,
    int? Dose,
    
    [Required]
    [MaxLength(100)]
    string Description
    );