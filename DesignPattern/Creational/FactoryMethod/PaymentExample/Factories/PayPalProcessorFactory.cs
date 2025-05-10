using DesignPattern.Creational.FactoryMethod.PaymentExample.Processors;

namespace DesignPattern.Creational.FactoryMethod.PaymentExample.Factories
{
    // Concrete Creator
    public class PayPalProcessorFactory : IPaymentProcessorFactory
    {
        public IPaymentProcessor CreateProcessor()
        {
            return new PayPalProcessor();
        }
    }
}
