using OneOf;
using SubscriptionsPlatform.Application.Errors;
using SubscriptionsPlatform.Domain.Entities.Users;

namespace SubscriptionsPlatform.Application.Services.User.Insert;

internal class UserInsert(
    IUserRepository userRepository
    ) : IUserInsert
{
    public async Task<OneOf<Guid, AppError>> InsertAsync(UserInsertModel userInsertModel)
    {
        var userDb = await userRepository.GetNameAndPasswordAsync(userInsertModel.Username, userInsertModel.Password);
        
        if (userDb != null)
            return new EntityAlreadyExists("User already exists");

        return Guid.NewGuid();
    }
}