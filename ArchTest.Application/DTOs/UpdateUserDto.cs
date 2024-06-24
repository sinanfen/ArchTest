namespace ArchTest.Application.DTOs;

public class UpdateUserDto
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; } // Örnek, sadece gerekli bilgiler
}
