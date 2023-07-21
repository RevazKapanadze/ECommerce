using Application.Dtos;
using System.ComponentModel.DataAnnotations;

public class RegisterDto : LoginDto
{
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email address.")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Phone number is required.")]
    [RegularExpression(@"^\d{9}$", ErrorMessage = "Invalid phone number. Phone number must be 9 digits.")]
    public string? PhoneNumber { get; set; }
}
