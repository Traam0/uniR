using UniR.Domain.Common.Abstract;

namespace UniR.Domain.Entities;

public class Group : Entity
{
    public uint Id { get; set; }

    public required string Name { get; set; }
    public ushort AcademicYear { get; set; }
    
    public uint BranchGradeId  {get; set;}
    public virtual BranchGrade? Grade { get; set; }
    public virtual ICollection<Teacher>  Teachers { get; set; } = [];
}