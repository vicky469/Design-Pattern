# Design Patterns in C#

This project contains implementations of the Gang of Four (GoF) design patterns, based on the examples from [DoFactory](https://dofactory.com/net/design-patterns).

## Creational Patterns

Create the objects in various of ways.

### 1. Abstract Factory

- **Purpose**: Creates an instance of several families of classes

### 2. Builder

- **Purpose**: Separates object construction from its representation

### 3. Factory Method

- **Purpose**: Creates an instance of several derived classes

### 4. Prototype

- **Purpose**: A fully initialized instance to be copied or cloned

### 5. Singleton

- **Purpose**: Ensures a class has only one instance and provides a global point of access to it.

## Structural Patterns

Structural patterns explain how to assemble objects and classes into larger structures while keeping these structures flexible and efficient.

### 6. Adapter

- **Purpose**: Match interfaces of different classes

### 7. Bridge

- **Purpose**: Separates an object’s interface from its implementation

### 8. Composite

- **Purpose**: A tree structure of simple and composite objects

### 9. Decorator

- **Purpose**: Attaches additional responsibilities to an object dynamically.

### 10. Facade

- **Purpose**: Provides a unified interface to a set of interfaces to represent an entire subsystem.

### 11. Flyweight

- **Purpose**: A fine-grained instance used for efficient sharing.
- **Use When**: An application uses a large number of objects that have some shared state.

### 12. Proxy

- **Purpose**: Provides a surrogate or placeholder for another object to control access to it.
- **Use When**: You need to control access to an object, or you want to provide a sophisticated reference to an object.

## Behavioral Patterns

Behavioral patterns are concerned with communication between objects, how objects interact and distribute responsibility.

### 13. Chain of Responsibility

- **Purpose**: Passes a request along a chain of handlers until one handles it.
- **Use When**: More than one object may handle a request, and the handler isn't known a priori.

### 14. Command

- **Purpose**: Encapsulates a request as an object.
- **Use When**: You want to parameterize objects with operations, queue operations, or support undoable operations.

### 15. Interpreter

- **Purpose**: A way to include language elements in a program

### 16. Iterator

- **Purpose**: Provides a way to access elements of a collection sequentially without exposing its underlying representation.

### 17. Mediator

- **Purpose**: Defines an object that encapsulates how a set of objects interact.
- **Use When**: A set of objects communicate in well-defined but complex ways.

### 18. Memento

- **Purpose**: Captures and externalizes an object's internal state.
- **Use When**: You need to save and restore an object's state without violating encapsulation.

### 19. Observer

- **Purpose**: A way of notifying change to a number of classes. Defines a one-to-many dependency between objects.

### 20. State

- **Purpose**: Allows an object to alter its behavior when its internal state changes.
- **Use When**: An object's behavior depends on its state, and it must change its behavior at runtime.

### 21. Strategy

- **Purpose**: Defines a family of algorithms and makes them interchangeable.
- **Use When**: You need different variants of an algorithm.

### 22. Template Method

- **Purpose**: Defines the skeleton of an algorithm in a method, deferring some steps to subclasses.

### 23. Visitor

- **Purpose**: Represents an operation to be performed on elements of an object structure.
- [Learn more about the Visitor Pattern](Behavioral/Visitor/readme.md)
