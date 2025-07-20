using UniR.Domain.Common.Abstract;

namespace UniR.Domain.Entities;

public class Subject : Entity
{
    public Guid Id { get; set; }
    public required string Name {get; set;}
    private string Code { get; set; } = null!;

    public virtual ICollection<Teacher> Teachers { get; set; } = [];
}