using UniR.Domain.Common.Abstract;

namespace UniR.Domain.Entities;

public class RolePresetPermissions : Entity
{
    public ulong Id { get; set; }
    public required string Permission { get; set; }

    public uint PresetId { get; set; }
    public virtual RolePreset? Preset { get; set; }
}