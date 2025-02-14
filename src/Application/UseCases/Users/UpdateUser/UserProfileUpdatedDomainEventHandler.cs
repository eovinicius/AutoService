using Application.Abstractions.Messaging;
using Domain.Users.Events;

namespace Application.UseCases.Users.UpdateUser;

internal sealed class UserProfileUpdatedDomainEventHandler()
    : IDomainEventHandler<UserProfileUpdatedDomainEvent>
{
    public Task Handle(UserProfileUpdatedDomainEvent domainEvent, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
