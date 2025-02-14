using Application.Abstractions.Data;
using Application.Abstractions.Messaging;

using Domain.Abstractions.Erros;
using Domain.Users;


namespace Application.UseCases.Users.UpdateUser;

internal sealed class UpdateUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
    : ICommandHandler<UpdateUserCommand>
{
    public async Task<Result> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        User? user = await userRepository.GetById(request.UserId, cancellationToken);

        if (user is null)
        {
            return Result.Failure(UserErrors.NotFound(request.UserId));
        }

        user.Update(request.FirstName, request.LastName);

        await unitOfWork.Commit(cancellationToken);

        return Result.Success();
    }
}
