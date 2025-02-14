using Domain.Abstractions;
using Domain.Users.Events;

namespace Domain.Users;

public sealed class User : Entity
{
    public Guid Id { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    private readonly List<Role> _roles = [];
    public IReadOnlyCollection<Role> Roles => [.. _roles];

    private User() { }

    private User(Guid id, string email, string passwordHash, string firstName, string lastName)
    {
        Id = id;
        Email = email;
        PasswordHash = passwordHash;
        FirstName = firstName;
        LastName = lastName;
    }

    public static User Create(string email, string passwordHash, string firstName, string lastName)
    {
        var user = new User(Guid.NewGuid(), email, passwordHash, firstName, lastName);

        user._roles.Add(Role.Member);

        user.Raise(new UserRegisteredDomainEvent(user.Id));

        return user;
    }

    public void Update(string firstName, string lastName)
    {
        if (FirstName == firstName && LastName == lastName)
        {
            return;
        }

        FirstName = firstName;
        LastName = lastName;

        Raise(new UserProfileUpdatedDomainEvent(Id, FirstName, LastName));
    }
}
