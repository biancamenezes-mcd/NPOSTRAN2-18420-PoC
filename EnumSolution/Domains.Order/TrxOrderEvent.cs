using Library.Enums;
using Library.Models;

namespace Domains.Order
{
    public class TrxOrderEvent: StldBaseEvent
    {
        public override AppDomains GetDomain() => AppDomains.TRXORDER;
    }
}