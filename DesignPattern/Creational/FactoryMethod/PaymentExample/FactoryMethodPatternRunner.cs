using System;
using DesignPattern.Core;
using DesignPattern.Creational.FactoryMethod.PaymentExample.Factories;

namespace DesignPattern.Creational.FactoryMethod.PaymentExample
{
    public class FactoryMethodPatternRunner : DesignPatternRunner
    {
        public override DesignPatternType PatternType => DesignPatternType.FactoryMethod;

        protected override void RunPattern()
        {
            // Process payment using Credit Card
            IPaymentProcessorFactory creditCardFactory = new CreditCardProcessorFactory();
            IPaymentProcessor creditCardProcessor = creditCardFactory.CreateProcessor();
            
            Console.WriteLine("\nTesting Credit Card Payment:");
            creditCardProcessor.ProcessPayment(500.00m);
            Console.WriteLine(creditCardProcessor.GetPaymentStatus());

            // Process payment using PayPal
            IPaymentProcessorFactory payPalFactory = new PayPalProcessorFactory();
            IPaymentProcessor payPalProcessor = payPalFactory.CreateProcessor();
            
            Console.WriteLine("\nTesting PayPal Payment:");
            payPalProcessor.ProcessPayment(750.50m);
            Console.WriteLine(payPalProcessor.GetPaymentStatus());

            // Test a failed payment (amount too high)
            Console.WriteLine("\nTesting Failed Payment:");
            creditCardProcessor.ProcessPayment(20000.00m);
            Console.WriteLine(creditCardProcessor.GetPaymentStatus());
        }
    }
}
