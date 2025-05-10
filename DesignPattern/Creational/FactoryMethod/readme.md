# Factory Method Pattern

## Overview

The Factory Method Pattern is a creational pattern that provides an interface for creating objects but allows subclasses to alter the type of objects that will be created. It's also known as the Virtual Constructor pattern.

## Examples

This project includes an implementation of the Factory Method pattern:

1. [Payment Processing System](PaymentExample/readme.md)
   - Demonstrates factory method with payment processors
   - Shows how to handle multiple payment methods
   - Includes concrete factories and products

## Factory Method vs Abstract Factory

While both patterns are creational and deal with object creation through abstraction, they serve different purposes and have distinct characteristics:

### Key Differences

1. **Scope and Purpose**

   - **Factory Method**: Creates a single type of product (e.g., just payment processors)
   - **Abstract Factory**: Creates families of related products (e.g., entire payment system components)

2. **Real-World Analogy**

   - **Factory Method**: Like a specialized machine that makes one type of product (e.g., a machine that only makes credit card processors)
   - **Abstract Factory**: Like a factory that produces complete systems (e.g., a factory that makes all VISA payment components)

3. **Implementation Example**

   ```csharp
   // Factory Method - Focused on one product type
   public interface IPaymentProcessorFactory {
       IPaymentProcessor CreateProcessor();  // Creates just processors
   }

   // Abstract Factory - Creates complete system
   public interface IPaymentSystemFactory {
       IPaymentProcessor CreateProcessor();  // Creates processor
       IPaymentValidator CreateValidator();  // Creates validator
       IPaymentLogger CreateLogger();       // Creates logger
   }
   ```

### When to Choose Which

Choose **Factory Method** when:

- You need to create a single type of object (e.g., just payment processors)
- Different subclasses need to create variations of that object
- Example: Creating different types of payment processors (Credit Card, PayPal, etc.)

Choose **Abstract Factory** when:

- You need multiple related objects that must work together
- You want to ensure product compatibility
- Example: Creating complete payment systems where processor, validator, and logger must be compatible

## Common Use Cases

1. **Database Connections**

   - Interface: `IDbConnection`
   - Concrete Types: `SqlConnection`, `MySqlConnection`, `PostgresConnection`
   - Use Case: Database-agnostic data access layer

2. **UI Components**

   - Interface: `IButton`
   - Concrete Types: `WindowsButton`, `MacButton`, `WebButton`
   - Use Case: Cross-platform UI development

3. **Document Generators**

   - Interface: `IDocumentGenerator`
   - Concrete Types: `PdfGenerator`, `WordGenerator`, `HtmlGenerator`
   - Use Case: Multi-format document generation

4. **Payment Processing**

   - Interface: `IPaymentProcessor`
   - Concrete Types: `CreditCardProcessor`, `PayPalProcessor`
   - Use Case: Multi-payment gateway support

5. **Notification Services**

   - Interface: `INotificationService`
   - Concrete Types: `EmailNotification`, `SMSNotification`, `PushNotification`
   - Use Case: Multi-channel notification system

6. **Transport Services**

   - Interface: `ITransportProvider`
   - Concrete Types: `TruckTransport`, `ShipTransport`, `AirTransport`
   - Use Case: Logistics system with different shipping methods

7. **Authentication Methods**

   - Interface: `IAuthenticator`
   - Concrete Types: `OAuth2Authenticator`, `JWTAuthenticator`, `BasicAuthenticator`
   - Use Case: Supporting multiple authentication strategies

8. **File Storage**
   - Interface: `IStorageProvider`
   - Concrete Types: `AWSStorage`, `AzureStorage`, `LocalStorage`
   - Use Case: Managing file storage across different platforms

Each example demonstrates the pattern's strength in handling a single product type with multiple implementations, where the object creation logic is encapsulated in corresponding factory classes.
