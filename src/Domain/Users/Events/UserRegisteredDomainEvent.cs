using SharedKernel.Events;

namespace Domain.Users.Events;

public sealed class UserRegisteredDomainEvent(Guid userId) : DomainEvent
{
    public Guid UserId { get; init; } = userId;
}
