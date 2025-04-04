namespace SubscriptionsPlatform.Domain.Entities.Abstractions;

public abstract class Base
{
    public Guid Id { get; init; } = Guid.NewGuid();
    internal DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    internal DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public void SetUpdatedProperties()
    {
        UpdatedAt = DateTime.UtcNow;
    }
}