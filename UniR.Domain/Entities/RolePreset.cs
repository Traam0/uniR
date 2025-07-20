using UniR.Domain.Common.Abstract;

namespace UniR.Domain.Entities;

public class RolePreset : Entity
{
    public uint Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }

    public virtual ICollection<RolePresetPermissions> Permissions { get; set; } = [];
}