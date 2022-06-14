namespace Library.Models
{
    public abstract class StldBaseEvent
    {
        public string Id;
        public string Token;
        public string Timestamp;

        public abstract string GetDomain();
        public bool Is(string domain) => domain.Equals(GetDomain());
    }
}
