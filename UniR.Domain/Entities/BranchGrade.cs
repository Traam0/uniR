using UniR.Domain.Common.Abstract;

namespace UniR.Domain.Entities;

public class BranchGrade : Entity
{
    public uint Id { get; set; }
    
    public byte Grade  { get; set; }
    public string Code { get; set; } = null!;
    
    public uint BranchId { get; set; }
    public virtual Branch? Branch { get; set; }
    public virtual ICollection<Subject> Subjects { get; set; } = [];
    public virtual ICollection<Group> Groups { get; set; } = [];
}