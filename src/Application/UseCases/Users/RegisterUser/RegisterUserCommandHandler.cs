using System.Runtime.CompilerServices;
using Application.Abstractions.Authentication;
using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Abstractions.Erros;
using Domain.Users;
using Domain.Users.Events;
using MediatR;

namespace Application.UseCases.Users.RegisterUser;

internal sealed class RegisterUserCommandHandler(IUserRepository _userRepository, IUnitOfWork _unitOfWork, IPasswordHasher _passwordHasher)
    : ICommandHandler<RegisterUserCommand, Guid>
{
    public async Task<Result<Guid>> Handle(RegisterUserCommand Input, CancellationToken cancellationToken)
    {
        var userAlreadyExists = await _userRepository.GetByEmail(Input.Email, cancellationToken);
        if (userAlreadyExists is not null)
        {
            return Result.Failure<Guid>(UserErrors.InvalidCredentials);
        }

        var user = User.Create(Input.Email, _passwordHasher.Hash(Input.Password), Input.FirstName, Input.LastName);

        user.Raise(new UserRegisteredDomainEvent(user.Id));

        await _unitOfWork.Commit(cancellationToken);

        return user.Id;
    }
}
