# Factory Method Pattern

## Overview

The Factory Method Pattern is a creational pattern that provides an interface for creating objects but allows subclasses to alter the type of objects that will be created. It's also known as the Virtual Constructor pattern.

## Real-World Example: Payment Processing System

In our implementation, we demonstrate the Factory Method pattern using a payment processing system that can handle different payment methods (Credit Card, PayPal) while maintaining a consistent interface.

### Structure

- `IPaymentProcessor` (Product): Defines the interface for payment processors
- `CreditCardProcessor`, `PayPalProcessor` (Concrete Products): Specific implementations of payment processors
- `IPaymentProcessorFactory` (Creator): Abstract factory interface
- `CreditCardProcessorFactory`, `PayPalProcessorFactory` (Concrete Creators): Create specific payment processors

## Factory Method vs Abstract Factory Pattern

### Key Differences

1. **Purpose**

   - Factory Method: Creates a single product
   - Abstract Factory: Creates families of related products

2. **Scope**

   - Factory Method: Deals with single product hierarchy
   - Abstract Factory: Deals with multiple product hierarchies

3. **Implementation**

   - Factory Method: Uses inheritance, subclasses provide the implementation
   - Abstract Factory: Uses composition, provides implementation for a family of products

4. **Flexibility**
   - Factory Method: Easy to add new product types (e.g., new payment methods)
   - Abstract Factory: Easy to add new product families (e.g., new UI themes)

### Example Comparison

**Factory Method (Payment Processing)**

```csharp
// Single product interface
public interface IPaymentProcessor {
    bool ProcessPayment(decimal amount);
}

// Factory for creating single type of product
public interface IPaymentProcessorFactory {
    IPaymentProcessor CreateProcessor();
}
```

**Abstract Factory (UI Components)**

```csharp
// Multiple product interfaces
public interface IButton { }
public interface ITextBox { }

// Factory for creating family of products
public interface IUIFactory {
    IButton CreateButton();
    ITextBox CreateTextBox();
}
```

### When to Use Which?

Use **Factory Method** when:

- You need to delegate object creation to subclasses
- You have a single product hierarchy
- You want to add new product types easily

Use **Abstract Factory** when:

- You need to ensure products work together
- You have multiple product hierarchies
- You want to swap entire families of products

## Benefits

1. Single Responsibility Principle: Separates product creation code from usage code
2. Open/Closed Principle: Easy to add new product types without modifying existing code
3. Loose coupling: Client code works with interfaces, not concrete classes

## Additional Real-World Use Cases

Here are more practical examples where the Factory Method pattern is commonly used:

1. **Document Generation**

   - Interface: `IDocumentGenerator`
   - Concrete Types: `PDFGenerator`, `WordGenerator`, `HTMLGenerator`
   - Use Case: Creating different document formats from the same content

2. **Database Connections**

   - Interface: `IDbConnection`
   - Concrete Types: `SqlConnection`, `PostgresConnection`, `MongoConnection`
   - Use Case: Supporting multiple database types in an application

3. **Logging Systems**

   - Interface: `ILogger`
   - Concrete Types: `FileLogger`, `DatabaseLogger`, `CloudLogger`
   - Use Case: Different logging mechanisms based on environment or configuration

4. **Image Processing**

   - Interface: `IImageProcessor`
   - Concrete Types: `JpegProcessor`, `PngProcessor`, `GifProcessor`
   - Use Case: Handling different image formats with specific processing requirements

5. **Notification Services**

   - Interface: `INotificationSender`
   - Concrete Types: `EmailNotification`, `SMSNotification`, `PushNotification`
   - Use Case: Sending notifications through different channels

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
