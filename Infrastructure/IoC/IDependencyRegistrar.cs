using Infrastructure.Misc;
using Autofac;

namespace Infrastructure.IoC
{
    public interface IDependencyRegistrar
    {
        void Register(ContainerBuilder builder, ITypeFinder typeFinder);

        int Order { get; }
    }
}
