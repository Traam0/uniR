using UniR.Domain.Common.Abstract;

namespace UniR.Domain.Entities;

public class Exam : AuditableEntity
{
    public Guid Id { get; set; } // {Id, Unique, ReadOnly}
    public required string Title { get; set; }
    public string? Description { get; set; }
    public DateTimeOffset ExamDate { get; set; }
    public uint Duration { get; set; }

    public Guid SubjectId { get; set; }
    public virtual Subject? Subject { get; set; }

    public ushort TeacherId { get; set; }
    public virtual Teacher? Teacher { get; set; }

    public ICollection<Group> Groups { get; set; } = [];
    // public ICollection<Grade> Grades { get; set; } = [];
}