using Library.Enums;
using Library.Models;

namespace Library
{
    public class StldProducer
    {
        private readonly AppDomains _domain;
        public StldProducer(AppDomains domain)
        {
            _domain = domain;
        }

        public void SendEvent<T>(T ev) where T : StldBaseEvent
        {
            if(!ev.IsEqual(_domain)) 
                throw new ApplicationException($"{ev.GetDomain()} can not be instantiated by the {_domain}");

            Console.WriteLine($"{ev} done");
        }
    }
}