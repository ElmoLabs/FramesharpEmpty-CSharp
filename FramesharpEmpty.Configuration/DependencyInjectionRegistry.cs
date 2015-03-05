using Framesharp.DomainService;
using Framesharp.DomainService.Interfaces;
using Framesharp.Repository;
using StructureMap.Configuration.DSL;

namespace FramesharpEmpty.Configuration
{
    /// <summary>
    /// This class is responsible for registering all other IoC registries
    ///  for scanning the application assembly for repository classes and domain services
    ///  classes.
    /// </summary>
    public class DependencyInjectionRegistry : Registry
    {
        public DependencyInjectionRegistry()
        {
            Scan(x =>
                     {
                         x.WithDefaultConventions();
                         x.Assembly("FramesharpEmpty.DomainService");
                         x.AddAllTypesOf(typeof(CrudDomainService<>));
                         x.ConnectImplementationsToTypesClosing(typeof(ICrudDomainService<>));
                         x.Assembly("FramesharpEmpty.Repository");
                         x.AddAllTypesOf(typeof(RepositoryBase<>));
                         x.ConnectImplementationsToTypesClosing(typeof(IRepository<>));
                     });
        }
    }
}
