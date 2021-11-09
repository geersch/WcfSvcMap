using System.Runtime.Serialization;

namespace AtmService
{
    [DataContract(Namespace = "http://cgeers.com/services/atm/common/types/")]
    public class Money
    {
        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public Currency Currency { get; set; }
    }
}
