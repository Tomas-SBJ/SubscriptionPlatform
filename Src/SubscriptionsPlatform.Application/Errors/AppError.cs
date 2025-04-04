namespace SubscriptionsPlatform.Application.Errors;

public record AppError(string Detail, EnumErrorType EnumErrorType);

public record EntityNotFoundError(string ErrorMessage) : AppError(ErrorMessage, EnumErrorType.EntityNotFound);
public record EntityAlreadyExists(string ErrorMessage) : AppError(ErrorMessage, EnumErrorType.EntityNotFound);