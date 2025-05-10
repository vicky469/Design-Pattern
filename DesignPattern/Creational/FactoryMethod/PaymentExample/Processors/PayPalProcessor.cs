using System;

namespace DesignPattern.Creational.FactoryMethod.PaymentExample.Processors
{
    // Concrete Product
    public class PayPalProcessor : IPaymentProcessor
    {
        private string _lastPayPalTransactionId;
        private bool _lastTransactionStatus;

        public bool ProcessPayment(decimal amount)
        {
            // Simulate PayPal processing
            _lastPayPalTransactionId = $"PP-{DateTime.UtcNow.Ticks}";
            _lastTransactionStatus = amount > 0 && amount < 10000; // PayPal limit
            
            Console.WriteLine($"Processing PayPal payment of ${amount}");
            return _lastTransactionStatus;
        }

        public string GetPaymentStatus()
        {
            return _lastTransactionStatus 
                ? $"PayPal payment successful. PayPal Transaction ID: {_lastPayPalTransactionId}" 
                : "PayPal payment failed";
        }
    }
}
