
using Library.Models;

namespace Library
{
    public class StldProducer
    {
        private readonly string _domain;
        public StldProducer(string domain)
        {
            _domain = domain;
        }

        public void SendEvent<T>(T ev) where T : StldBaseEvent
        {
            if(!ev.Is(_domain)) 
                throw new ApplicationException($"{ev.GetDomain()} can not be instantiated by the {_domain}");

            Console.WriteLine($"{ev} done");
        }
    }
}