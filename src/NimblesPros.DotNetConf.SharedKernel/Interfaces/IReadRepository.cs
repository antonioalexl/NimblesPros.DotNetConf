using Ardalis.Specification;

namespace NimblesPros.DotNetConf.SharedKernel.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
