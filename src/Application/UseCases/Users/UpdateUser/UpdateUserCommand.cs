using Application.Abstractions.Messaging;

namespace Application.UseCases.Users.UpdateUser;

public sealed record UpdateUserCommand(Guid UserId, string FirstName, string LastName) : ICommand;
