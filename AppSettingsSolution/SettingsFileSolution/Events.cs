using Domains.Order;
using Domains.Payment;
using Library;

namespace Payment.App
{
    public class Events
    {
        private readonly StldProducer _producer;
        public Events(StldProducer libSettings)
        {
            _producer = libSettings;
        }
        public void GenerateEvent()
        {
            Console.WriteLine("Calling SaveEvent");

            var order = new TrxOrderEvent
            {
                Id = "1",
                Token = "1"
            };

            var payment = new TrxPaymentEvent()
            {
                Id = "2",
                Token = "2"
            };

            try
            {
                _producer.SendEvent(payment);
                _producer.SendEvent(order);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
