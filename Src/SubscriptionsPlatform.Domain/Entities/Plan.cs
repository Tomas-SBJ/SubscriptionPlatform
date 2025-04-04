using SubscriptionsPlatform.Domain.Entities.Abstractions;

namespace SubscriptionsPlatform.Domain.Entities;

public class Plan() : Base
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}