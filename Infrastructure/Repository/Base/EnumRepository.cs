using Core.Entities.Base;
using Core.Repositories.Base;
using Infrastructure.Data;

namespace Infrastructure.Repository.Base
{
    public class EnumRepository<T> : RepositoryBase<T, int>, IEnumRepository<T>
        where T : class, IEntityBase<int>
    {
        public EnumRepository(AspnetRunContext context)
            : base(context)
        {
        }
    }
}
