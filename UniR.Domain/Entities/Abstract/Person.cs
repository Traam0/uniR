using UniR.Domain.Common.Abstract;
using UniR.Domain.Enums;

namespace UniR.Domain.Entities.Abstract;

public abstract class Person : AuditableEntity
{
    public required string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public required string LastName { get; set; }
    public string? IdentificationNumber { get; set; }
    public string? Phone { get; set; }
    public IdentificationType IdentificationType { get; set; }
    public Gender Gender { get; set; }
}