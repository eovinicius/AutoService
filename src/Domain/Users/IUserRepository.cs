namespace Domain.Users;

public interface IUserRepository
{
    Task Insert(User user);
    Task<User?> GetById(Guid id, CancellationToken cancellationToken = default);
    Task<User?> GetByEmail(string email, CancellationToken cancellationToken = default);
}
