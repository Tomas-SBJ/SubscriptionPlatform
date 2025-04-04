using SubscriptionsPlatform.Domain.Entities.Abstractions;

namespace SubscriptionsPlatform.Domain.Entities;

public class Subscription : Base
{
    public DateTime? EndDate { get; set; }
    
    public Plan Plan { get; set; }

    public bool IsActive => EndDate != null && EndDate > DateTime.Now;
}