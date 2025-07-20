using UniR.Domain.Common.Abstract;
using UniR.Domain.Entities.Abstract;

namespace UniR.Domain.Entities;

public class Teacher : Person
{
    public ushort Id { get; set; }
    
    public Guid AppUserId { get; set; }
    public virtual AppUser? AppUser { get; set; }

    public virtual ICollection<Subject> Subjects { get; set; } = [];
    public virtual ICollection<Group> Groups { get; set; } = [];
}