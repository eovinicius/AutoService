using Application.Abstractions.Messaging;

namespace Application.UseCases.Users.GetUser;

public sealed record GetUserQuery(Guid UserId) : IQuery<UserResponse>;
