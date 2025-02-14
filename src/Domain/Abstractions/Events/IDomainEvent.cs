using MediatR;

namespace Domain.Abstractions.Events;

public interface IDomainEvent : INotification
{
    Guid Id { get; }

    DateTime OccurredOnUtc { get; }
}