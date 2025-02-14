using Application.Abstractions.Messaging;
using Domain.Abstractions.Erros;
using Domain.Users;

namespace Application.UseCases.Users.Login;

internal sealed class LoginCommandHandler(IUserRepository userRepository) : ICommandHandler<LoginCommand, string>
{
    public async Task<Result<string>> Handle(LoginCommand input, CancellationToken cancellationToken)
    {
        var user = await userRepository.GetByEmail(input.Email, cancellationToken);
        if (user is null)
        {
            return Result.Failure<string>(UserErrors.InvalidCredentials);
        }

        if (!user.PasswordHash.Equals(input.Password))
        {
            return Result.Failure<string>(UserErrors.InvalidCredentials);
        }

        return user.Id.ToString();
    }
}
