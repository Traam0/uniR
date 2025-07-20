using UniR.Domain.Common.Abstract;
using UniR.Domain.Enums;

namespace UniR.Domain.Entities.Baas;

public class AppSubscription : AuditableEntity
{
    public Guid Id { get; set; }
    
    public DateTimeOffset StartTime { get; set; }
    public DateTimeOffset EndTime { get; set; }
    public SubscriptionStatus Status { get; set; }

    public Guid AppId { get; set; }
    public virtual App? App { get; set; }
    
    public uint SubscriptionTierId { get; set; }
    public virtual SubscriptionTier? SubscriptionTier { get; set; }
}