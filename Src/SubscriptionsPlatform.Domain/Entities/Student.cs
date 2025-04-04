using SubscriptionsPlatform.Domain.Entities.Abstractions;

namespace SubscriptionsPlatform.Domain.Entities;

public class Student : Base
{
    public string Name { get; set; }
    public string Email { get; set; }
    
    public User User { get; set; }
    public IList<Subscription> Subscriptions { get; set; }

    public bool IsPremium => Subscriptions.Any(x => x.IsActive);
}