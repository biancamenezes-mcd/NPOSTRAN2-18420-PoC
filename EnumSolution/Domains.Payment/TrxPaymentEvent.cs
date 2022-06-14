using Library.Enums;
using Library.Models;

namespace Domains.Payment
{
    public class TrxPaymentEvent : StldBaseEvent
    {
        public string? Price { get; set; }
        public override AppDomains GetDomain() => AppDomains.TRXPAYMENT;
    }
}