using System;
using Framesharp.DomainService;
using Framesharp.Persistence.Transaction;
using FramesharpEmpty.Configuration;
using FramesharpEmpty.Domain;
using FramesharpEmpty.DomainService.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FramesharpEmpty.DomainService.Test
{
    [TestClass]
    public class DemonstrationDomainServiceTest : Framesharp.Test.TestClassBase
    {
        private readonly IDemonstrationDomainService _demonstrationDomainService;

        public DemonstrationDomainServiceTest() : base(new RootApplicationSettings())
        {
            _demonstrationDomainService = DomainServiceFactory.Get<IDemonstrationDomainService>(this.OperationCallContext);
        }

        /// <summary>
        /// Creates a new Demonstration record
        /// </summary>
        [TestMethod]
        [TransactionScope(DefaultRollback = true)]
        public void CreateDemonstrationTest()
        {
            Demonstration demonstration = new Demonstration()
            {
                SomeDescription = string.Format("Test description {0}", DateTime.Now.Ticks),
                SomeNumber = (int)DateTime.Now.Ticks / 2,
                SomeFlag = true,
            };

            _demonstrationDomainService.CreateDemonstration(
                demonstration.SomeDescription, 
                demonstration.SomeNumber, 
                demonstration.SomeFlag);
        }

        /// <summary>
        /// Gets a demonstration by database identification number
        /// </summary>
        /// <returns>An instance of <see cref="Domain.Demonstration"/></returns>
        [TestMethod]
        public void GetDemonstrationTest()
        {
            Demonstration demonstration = EquivalencePartition.GetRandom<Demonstration>();

            if (demonstration == null) Assert.Inconclusive("Demonstration table is empty");

            _demonstrationDomainService.GetDemonstration(demonstration.DemonstrationId);
        }
    }
}
