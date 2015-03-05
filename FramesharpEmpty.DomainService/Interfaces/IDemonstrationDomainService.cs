using Framesharp.DomainService.Interfaces;
using FramesharpEmpty.Domain;

namespace FramesharpEmpty.DomainService.Interfaces
{
    public interface IDemonstrationDomainService : ICrudDomainService<Demonstration>
    {   
        /// <summary>
        /// Creates a new demonstration record
        /// </summary>
        /// <param name="someDescription">Some random description</param>
        /// <param name="someNumber">Some random number</param>
        /// <param name="someFlag">Some random flag</param>
        /// <returns></returns>
        Demonstration CreateDemonstration(string someDescription, int someNumber, bool someFlag);

        /// <summary>
        /// Gets a demonstration by database identification number
        /// </summary>
        /// <param name="demonstrationId">Database identification number of the Demonstration instance</param>
        /// <returns>An instance of <see cref="Domain.Demonstration"/></returns>
        Demonstration GetDemonstration(int demonstrationId);
    }
}