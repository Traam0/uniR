using UniR.Domain.Common.Abstract;

namespace UniR.Domain.Entities.Baas;

public class SubscriptionFeature : Entity
{
    public byte Id { get; set; }
    public required string Name { get; set; }
    public bool IsAvailable { get; set; }

    public virtual ICollection<SubscriptionTier> SubscriptionTiers { get; set; } = [];
}