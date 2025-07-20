using UniR.Domain.Common.Abstract;

namespace UniR.Domain.Entities.Baas;

public class App : AuditableEntity
{
    public Guid Id { get; set; }

    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public bool IsActive { get; set; }
    public string? Logo {get; set;}

    
    public Guid UserId { get; set; }
    public virtual User? User { get; set; }
}