namespace Domain.Abstractions;

public interface IRepository<T> where T : Entity
{
    Task Insert(T entity, CancellationToken cancellationToken);
    Task Delete(T entity, CancellationToken cancellationToken);
    Task Update(T entity, CancellationToken cancellationToken);
    Task<T> GetById(Guid id, CancellationToken cancellationToken);
}
