using UniR.Domain.Common.Abstract;

namespace UniR.Domain.Entities;

public class Branch : Entity
{
    public uint Id { get; set; }
    
    public required string Name { get; set; }
    public string? Description { get; set; }
    
    public uint ProgramId  { get; set; }
    public virtual AcademicProgram? Program { get; set; }
    public ICollection<BranchGrade> Grades { get; set; } = [];
}