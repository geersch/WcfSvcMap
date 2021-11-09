using System.ServiceModel;

namespace AtmService
{
    [ServiceContract(Namespace = "http://cgeers.com/services/atm/")]
    public interface IDepositService
    {
        [OperationContract]
        bool Deposit(string cardNumber, string securityCode, Money amount);
    }
}
