using UniR.Domain.Common.Abstract;

namespace UniR.Domain.Entities;

public class AcademicProgram : Entity
{
    public uint Id { get; set; }
    public required string Name { get; set; }
    public string Duration { get; set; } = null!;

    public virtual ICollection<Branch> Branches { get; set; } = [];
}