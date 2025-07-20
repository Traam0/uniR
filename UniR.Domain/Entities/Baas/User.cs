using UniR.Domain.Common.Abstract;
using UniR.Domain.Enums;

namespace UniR.Domain.Entities.Baas;

public class User : AuditableEntity
{
    public Guid Id { get; set; }
    
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public uint Version { get; set; }
    public Role Role { get; set; }

    public virtual ICollection<App> Apps { get; set; } = [];
}