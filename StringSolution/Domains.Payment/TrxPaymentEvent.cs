using Library.Models;

namespace Domains.Payment
{
    public class TrxPaymentEvent : StldBaseEvent
    {
        public override string GetDomain() => "TRXPAYMENT";
    }
}