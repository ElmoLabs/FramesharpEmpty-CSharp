using Framesharp.Repository;
using FramesharpEmpty.Domain;

namespace FramesharpEmpty.Repository.Interfaces
{
    public interface IDemonstrationRepository : IRepository<Demonstration>
    {
        /// <summary>
        /// Gets a demonstration by database identification number
        /// </summary>
        /// <param name="demonstrationId">Database identification number of the Demonstration instance</param>
        /// <returns>An instance of <see cref="Domain.Demonstration"/></returns>
        Demonstration GetDemonstration(int demonstrationId);
    }
}