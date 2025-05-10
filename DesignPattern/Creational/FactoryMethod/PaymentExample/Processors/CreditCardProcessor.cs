using System;

namespace DesignPattern.Creational.FactoryMethod.PaymentExample.Processors
{
    // Concrete Product
    public class CreditCardProcessor : IPaymentProcessor
    {
        private string _lastTransactionId;
        private bool _lastTransactionStatus;

        public bool ProcessPayment(decimal amount)
        {
            // Simulate credit card processing
            _lastTransactionId = Guid.NewGuid().ToString();
            _lastTransactionStatus = amount > 0 && amount < 15000; // Simple validation
            
            Console.WriteLine($"Processing credit card payment of ${amount}");
            return _lastTransactionStatus;
        }

        public string GetPaymentStatus()
        {
            return _lastTransactionStatus 
                ? $"Credit card payment successful. Transaction ID: {_lastTransactionId}" 
                : "Credit card payment failed";
        }
    }
}
