using Library.Models;

namespace Domains.Order
{
    public class TrxOrderEvent: StldBaseEvent
    {
        public override string GetDomain() => "TRXORDER";
    }
}