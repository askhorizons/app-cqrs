using Core.Entities.Base;
using Core.Repositories.Base;
using Infrastructure.Data;

namespace Infrastructure.Repository.Base
{
    public class Repository<T> : RepositoryBase<T, int>, IRepository<T>
        where T : class, IEntityBase<int>
    {
        public Repository(AspnetRunContext context)
            : base(context)
        {
        }
    }
}
