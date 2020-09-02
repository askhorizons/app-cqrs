using Infrastructure.IoC;
using Infrastructure.Misc;
using Autofac;

namespace Application.IoC
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            // services
            // builder.RegisterType<ProductService>().As<IProductService>().InstancePerLifetimeScope();
        }

        public int Order => 2;
    }
}
