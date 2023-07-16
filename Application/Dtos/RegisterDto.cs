namespace Application.Dtos
{
    public class RegisterDto : LoginDto
    {
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
