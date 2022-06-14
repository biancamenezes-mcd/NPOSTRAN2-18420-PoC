using Library.Models;
using Library.Models.Settings;

namespace Library
{
    public class StldProducer
    {
        private readonly DomainSettings _settings;

        public StldProducer(DomainSettings settings)
        {
            _settings = settings;
        }

        public void SendEvent<T>(T ev) where T : StldBaseEvent
        {
            if(!ev.IsEqual(typeof(T).Namespace, _settings!.Name) )
                throw new ApplicationException($"{typeof(T).Namespace} can not be instantiated by the {_settings!.Name}");

            Console.WriteLine($"{ev} done"); //in the real library will be send to database.
        }
    }
}