using System.Runtime.Serialization;

namespace AtmService
{
    [DataContract(Namespace = "http://cgeers.com/services/atm/common/types/")]
    public enum Currency
    {
        [EnumMember]
        Euro,
        [EnumMember]
        Usd,
        [EnumMember]
        PoundSterling
    }
}
