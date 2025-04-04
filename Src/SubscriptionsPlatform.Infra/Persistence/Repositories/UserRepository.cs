using Microsoft.EntityFrameworkCore;
using SubscriptionsPlatform.Domain.Entities;
using SubscriptionsPlatform.Domain.Entities.Users;
using SubscriptionsPlatform.Infra.Persistence.Contexts;

namespace SubscriptionsPlatform.Infra.Persistence.Repositories;

public class UserRepository(
    AppDbContext appDbContext
    ) : IUserRepository
{
    public async Task<Guid> AddAsync(User user)
    {
        await appDbContext.Users.AddAsync(user);
        await appDbContext.SaveChangesAsync();
        
        return user.Id;
    }

    public async Task<User?> GetNameAndPasswordAsync(string username, string password)
    {
        return await appDbContext.Users.FirstOrDefaultAsync(x => x.Username == username && 
                                                                      x.Password == password);
    }
}