using System.ServiceModel;

namespace AtmService
{     
    [ServiceContract(Namespace = "http://cgeers.com/services/atm/")]
    public interface IWithdrawalService
    {
        [OperationContract]
        bool Withdraw(string cardNumber, string securityCode, Money amount);
    }    
}
