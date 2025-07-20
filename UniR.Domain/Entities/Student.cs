using UniR.Domain.Entities.Abstract;

namespace UniR.Domain.Entities.Baas;

public class Student : Person
{
    public Guid Id { get; set; }
    public string? RegistrationNumber { get; set; }

    public Guid AppUserId { get; set; }
    public virtual AppUser? AppUser { get; set; }

    public uint? GroupId { get; set; }
    public virtual Group? Group { get; set; }

    public virtual ICollection<Parent> Parents { get; set; } = [];
}