using OneOf;
using SubscriptionsPlatform.Application.Errors;

namespace SubscriptionsPlatform.Application.Services.User.Insert;

public interface IUserInsert
{
    Task<OneOf<Guid, AppError>> InsertAsync(UserInsertModel userInsertModel);
}