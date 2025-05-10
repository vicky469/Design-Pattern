using System;

namespace DesignPattern.Creational.FactoryMethod.PaymentExample
{
    // Abstract Product
    public interface IPaymentProcessor
    {
        bool ProcessPayment(decimal amount);
        string GetPaymentStatus();
    }
}
