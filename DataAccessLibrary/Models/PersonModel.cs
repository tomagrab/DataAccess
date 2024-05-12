using System.ComponentModel.DataAnnotations;

namespace DataAccessLibrary.Models;

public class PersonModel
{
    public int Id { get; set; }
    [Required(ErrorMessage = "First name is required.")]
    [MaxLength(50, ErrorMessage = "First name is too long.")]
    public string? FirstName { get; set; }
    [Required(ErrorMessage = "Last name is required.")]
    [MaxLength(50, ErrorMessage = "Last name is too long.")]
    public string? LastName { get; set; }
}
