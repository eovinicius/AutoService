using Application.Abstractions.Messaging;

using Domain.Users.Events;
namespace Application.UseCases.Users.RegisterUser;

internal sealed class UserRegisteredDomainEventHandler : IDomainEventHandler<UserRegisteredDomainEvent>
{
    public Task Handle(UserRegisteredDomainEvent domainEvent, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
