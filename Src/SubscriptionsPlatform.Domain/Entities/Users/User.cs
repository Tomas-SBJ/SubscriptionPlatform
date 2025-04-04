using SubscriptionsPlatform.Domain.Entities.Abstractions;

namespace SubscriptionsPlatform.Domain.Entities;

public class User(
    string username,
    string password
    ) : Base
{
    public string Username { get; set; } = username;
    public string Password { get; set; } = password;
}