using UniR.Domain.Common.Abstract;
using UniR.Domain.Entities.Baas;

namespace UniR.Domain.Entities;

public class Enrolment : AuditableEntity
{
    public Guid Id { get; set; }

    public uint AcademicYear { get; set; }
    public ushort StudentId { get; set; }
    public ushort BranchYearId { get; set; }

    // public EnrolmentStatus Status { get; set; } = EnrolmentStatus.Active;

    public Student? Student { get; set; }
    public BranchGrade? BranchGrade { get; set; }
}