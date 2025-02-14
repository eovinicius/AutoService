using Domain.Abstractions.Events;

using MediatR;

namespace Application.Abstractions.Messaging;

public interface IDomainEventHandler<TDomainEvent> : INotificationHandler<TDomainEvent>
    where TDomainEvent : IDomainEvent
{
    new Task Handle(TDomainEvent domainEvent, CancellationToken cancellationToken);
}
