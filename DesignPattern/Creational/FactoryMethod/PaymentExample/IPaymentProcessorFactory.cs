namespace DesignPattern.Creational.FactoryMethod.PaymentExample
{
    // Abstract Creator
    public interface IPaymentProcessorFactory
    {
        IPaymentProcessor CreateProcessor();
    }
}
