namespace SubscriptionsPlatform.Domain.Entities.Users;

public interface IUserRepository
{
    Task<Guid> AddAsync(User user);
    Task<User?> GetNameAndPasswordAsync(string username, string password);
}