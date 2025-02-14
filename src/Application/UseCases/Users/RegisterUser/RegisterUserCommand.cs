using Application.Abstractions.Messaging;

namespace Application.UseCases.Users.RegisterUser;

public sealed record RegisterUserCommand(string Email, string Password, string FirstName, string LastName)
    : ICommand<Guid>;