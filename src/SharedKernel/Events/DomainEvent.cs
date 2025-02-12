namespace SharedKernel.Events;

public abstract class DomainEvent : IDomainEvent
{
    public DateTime OccurredOnUtc { get; init; }
    public Guid Id { get; init; }

    protected DomainEvent()
    {
        Id = Guid.NewGuid();
        OccurredOnUtc = DateTime.UtcNow;
    }

    protected DomainEvent(Guid id, DateTime occurredOnUtc)
    {
        Id = id;
        OccurredOnUtc = occurredOnUtc;
    }
}
