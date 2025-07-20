using UniR.Domain.Enums;
using UniR.Domain.Entities.Baas;
using UniR.Domain.Common.Abstract;
using UniR.Domain.Entities.Abstract;

namespace UniR.Domain.Entities;

public class AppUser : AuditableEntity
{
    public Guid Id { get; set; }

    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public required string Phone { get; set; }
    public string? Image { get; set; }
    public AppUserRole Role { get; set; }

    public Guid AppId { get; set; }
    public virtual App? App { get; set; }

    public virtual ICollection<Person> Profiles { get; set; } = new List<Person>();
}