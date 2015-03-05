using Framesharp.Core.Interfaces;
using Framesharp.Repository;
using FramesharpEmpty.Domain;
using FramesharpEmpty.Repository.Interfaces;

namespace FramesharpEmpty.Repository
{
    public class DemonstrationRepository : RepositoryBase<Demonstration>, IDemonstrationRepository
    {
        public DemonstrationRepository(IOperationCallContext context) : base(context)
        {
        }

        /// <summary>
        /// Gets a demonstration by database identification number
        /// </summary>
        /// <param name="demonstrationId">Database identification number of the Demonstration instance</param>
        /// <returns>An instance of <see cref="Domain.Demonstration"/></returns>
        public Demonstration GetDemonstration(int demonstrationId)
        {
            return Get(demonstrationId);
        }
    }
}