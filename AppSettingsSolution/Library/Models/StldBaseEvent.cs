namespace Library.Models
{
    public abstract class StldBaseEvent
    {

        public string Id;
        public string Token;
        public string Timestamp;

        public bool IsEqual(string? objectDomain, string appSettingsDomain) 
            => appSettingsDomain.Equals(objectDomain);

    }
}
