using UniR.Domain.Common.Abstract;

namespace UniR.Domain.Entities.Baas;

public class SubscriptionTier : Entity
{
    public uint Id { get; set; }
    
    public required string Name { get; set; }
    public required string PriceId { get; set; }
    public uint ApiCallLimit { get; set; }
    public uint MonthlyPrice { get; set; }
    public string? Description { get; set; }

    public virtual ICollection<SubscriptionFeature> Features { get; set; } = [];

}