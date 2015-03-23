using Framesharp.Core.Interfaces;
using Framesharp.DomainService;
using Framesharp.Data.Transaction;
using Framesharp.Repository;
using FramesharpEmpty.Domain;
using FramesharpEmpty.DomainService.Interfaces;
using FramesharpEmpty.Repository.Interfaces;

namespace FramesharpEmpty.DomainService
{
    public class DemonstrationDomainService : CrudDomainService<Demonstration, IDemonstrationRepository>, IDemonstrationDomainService
    {
        private readonly IDemonstrationRepository _demonstrationRepository; 

        public DemonstrationDomainService(IOperationCallContext context) : base(context)
        {
            _demonstrationRepository = RepositoryFactory.Get<IDemonstrationRepository>(context);
        }

        /// <summary>
        /// Creates a new demonstration record
        /// </summary>
        /// <param name="someDescription">Some random description</param>
        /// <param name="someNumber">Some random number</param>
        /// <param name="someFlag">Some random flag</param>
        /// <returns>A new instance of <see cref="Domain.Demonstration"/></returns>
        [TransactionScope]
        public Demonstration CreateDemonstration(string someDescription, int someNumber, bool someFlag)
        {
            Demonstration demonstration = new Demonstration()
            {
                SomeDescription = someDescription,
                SomeNumber = someNumber,
                SomeFlag = someFlag
            };

            Repository.Save(demonstration);

            return demonstration;
        }

        /// <summary>
        /// Gets a demonstration by database identification number
        /// </summary>
        /// <param name="demonstrationId">Database identification number of the Demonstration instance</param>
        /// <returns>An instance of <see cref="Domain.Demonstration"/></returns>
        [TransactionScope]
        public Demonstration GetDemonstration(int demonstrationId)
        {
            return _demonstrationRepository.Get(demonstrationId);
        }
    }
}