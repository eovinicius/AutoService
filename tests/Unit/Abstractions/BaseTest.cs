using Bogus;

using Domain.Abstractions;
using Domain.Abstractions.Events;


namespace Unit.Abstractions;

public abstract class BaseTest
{
    protected static readonly Faker Faker = new();

    public static T AssertDomainEventWasPublished<T>(Entity entity)
        where T : IDomainEvent
    {
        T? domainEvent = entity.DomainEvents.OfType<T>().SingleOrDefault();

        return domainEvent is null ? throw new Exception($"{typeof(T).Name} was not published") : domainEvent;
    }
}
