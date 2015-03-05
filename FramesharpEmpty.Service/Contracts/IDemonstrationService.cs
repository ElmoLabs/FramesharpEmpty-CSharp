using System.ServiceModel;
using FramesharpEmpty.Service.DataContracts;

namespace FramesharpEmpty.Service.Contracts
{
    [ServiceContract]
    public interface IDemonstrationService
    {
        [OperationContract]
        Demonstration GetDemonstration(int demonstrationId);
    }
}
