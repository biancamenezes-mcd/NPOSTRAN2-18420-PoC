// See https://aka.ms/new-console-template for more information

using Domains.Order;
using Domains.Payment;
using Library;
using Library.Enums;

Console.WriteLine("Calling SaveEvent");

var order = new TrxOrderEvent
{

};

var payment = new TrxPaymentEvent()
{

};

var prod = new StldProducer(AppDomains.TRXPAYMENT);
try
{
    prod.SendEvent(payment);
    prod.SendEvent(order);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
