using System.ComponentModel.DataAnnotations;

namespace CW10_S30391.DTOs;

public class ClientTripCreateDto
{
    [Required] 
    [MaxLength(120)] 
    public string FirstName { get; set; } = null!;
    
    [Required]
    [MaxLength(120)]
    public string LastName { get; set; } = null!;
    
    [Required]
    [MaxLength(120)]
    public string Email { get; set; } = null!;
    
    [Required]
    [MaxLength(120)]
    public string Telephone { get; set; } = null!;
    
    [Required]
    [MaxLength(120)]
    public string Pesel { get; set; } = null!;
    
    [Required]
    public int IdTrip { get; set; }
    
    [Required]
    [MaxLength(120)]
    public string TripName { get; set; } = null!;
    
    [Required]
    [MaxLength(120)]
    public DateTime? PaymentDate { get; set; } 
    
}