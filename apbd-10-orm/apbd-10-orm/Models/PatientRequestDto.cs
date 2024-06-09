using System.ComponentModel.DataAnnotations;

namespace apbd_10_orm.Models;

public record PatientRequestDto(
    [Required]
    int IdPatient,
    
    [Required]
    [MaxLength(100)]
    string FirstName,
    
    [Required]
    [MaxLength(100)]
    string LastName,
    
    [Required]
    DateTime BirthDate
    );