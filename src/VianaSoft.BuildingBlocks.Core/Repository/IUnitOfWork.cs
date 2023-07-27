namespace VianaSoft.BuildingBlocks.Core.Repository
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
