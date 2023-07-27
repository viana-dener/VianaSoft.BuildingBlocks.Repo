using VianaSoft.BuildingBlocks.Core.DomainObjects;

namespace VianaSoft.BuildingBlocks.Core.Repository
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
    }
}
