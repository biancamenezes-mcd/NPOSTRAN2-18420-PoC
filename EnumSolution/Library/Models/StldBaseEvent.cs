using Library.Enums;

namespace Library.Models
{
    public abstract class StldBaseEvent
    {
        public string Id;
        public string Token;
        public string Timestamp;

        public abstract AppDomains GetDomain();
        public bool IsEqual(AppDomains domain) => domain.Equals(GetDomain());
    }
}
