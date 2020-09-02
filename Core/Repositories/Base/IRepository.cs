using Core.Entities.Base;

namespace Core.Repositories.Base
{
    public interface IRepository<T> : IRepositoryBase<T, int> where T : IEntityBase<int>
    {
    }
}
