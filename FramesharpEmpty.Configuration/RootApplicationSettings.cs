using System.Collections.Generic;
using Framesharp.Configuration;
using StructureMap.Configuration.DSL;

namespace FramesharpEmpty.Configuration
{
    /// <summary>
    /// This class defines a common place for defining global application settings 
    ///  and for facading access to the configuration manager and .config settings
    /// </summary>
    public class RootApplicationSettings : ApplicationSettings
    {
        public RootApplicationSettings()
        {
            InitializeClass();
        }

        /// <summary>
        /// Class initialization method
        /// </summary>
        public void InitializeClass()
        {
            // Defines which IoC registry classes will be loaded.
            DependencyRegistries = new List<Registry>()
                {
                    { new Framesharp.DependencyInjection.Registry.NHibernateRegistry(DatabaseSettings.BuildSessionFactory()) },
                    { new Framesharp.DependencyInjection.Registry.CoreRegistry() },
                    { new Framesharp.DependencyInjection.Registry.DomainServiceRegistry() },
                    { new Framesharp.DependencyInjection.Registry.RepositoryRegistry() },
                    { new DependencyInjectionRegistry() }
                };
        }
    }
}