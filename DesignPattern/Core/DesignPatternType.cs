namespace DesignPattern
{
    /// <summary>
    /// Enumeration of all 23 Gang of Four (GoF) design patterns
    /// </summary>
    public enum DesignPatternType
    {
        // Creational Patterns (1-5)
        AbstractFactory = 1,
        Builder = 2,
        FactoryMethod = 3,
        Prototype = 4,
        Singleton = 5,

        // Structural Patterns (6-12)
        Adapter = 6,
        Bridge = 7,
        Composite = 8,
        Decorator = 9,
        Facade = 10,
        Flyweight = 11,
        Proxy = 12,

        // Behavioral Patterns (13-23)
        ChainOfResponsibility = 13,
        Command = 14,
        Interpreter = 15,
        Iterator = 16,
        Mediator = 17,
        Memento = 18,
        Observer = 19,
        State = 20,
        Strategy = 21,
        TemplateMethod = 22,
        Visitor = 23
    }

    /// <summary>
    /// Extension methods for DesignPatternType enum
    /// </summary>
    public static class DesignPatternTypeExtensions
    {
        /// <summary>
        /// Gets the category of the design pattern
        /// </summary>
        public static string GetCategory(this DesignPatternType pattern)
        {
            if (pattern >= DesignPatternType.AbstractFactory && pattern <= DesignPatternType.Singleton)
                return "Creational";
            if (pattern >= DesignPatternType.Adapter && pattern <= DesignPatternType.Proxy)
                return "Structural";
            return "Behavioral";
        }

        /// <summary>
        /// Gets a brief description of the design pattern
        /// </summary>
        public static string GetDescription(this DesignPatternType pattern)
        {
            return pattern switch
            {
                DesignPatternType.AbstractFactory => "Creates an instance of several families of classes",
                DesignPatternType.Builder => "Separates object construction from its representation",
                DesignPatternType.FactoryMethod => "Creates an instance of several derived classes",
                DesignPatternType.Prototype => "A fully initialized instance to be copied or cloned",
                DesignPatternType.Singleton => "Ensures a class has only one instance with global access",
                DesignPatternType.Adapter => "Match interfaces of different classes",
                DesignPatternType.Bridge => "Separates an object's interface from its implementation",
                DesignPatternType.Composite => "A tree structure of simple and composite objects",
                DesignPatternType.Decorator => "Add responsibilities to objects dynamically",
                DesignPatternType.Facade => "A single class that represents an entire subsystem",
                DesignPatternType.Flyweight => "A fine-grained instance used for efficient sharing",
                DesignPatternType.Proxy => "An object representing another object",
                DesignPatternType.ChainOfResponsibility => "A way of passing a request between a chain of objects",
                DesignPatternType.Command => "Encapsulate a command request as an object",
                DesignPatternType.Interpreter => "A way to include language elements in a program",
                DesignPatternType.Iterator => "Sequentially access the elements of a collection",
                DesignPatternType.Mediator => "Defines simplified communication between classes",
                DesignPatternType.Memento => "Capture and restore an object's internal state",
                DesignPatternType.Observer => "A way of notifying change to a number of classes",
                DesignPatternType.State => "Alter an object's behavior when its state changes",
                DesignPatternType.Strategy => "Encapsulates an algorithm inside a class",
                DesignPatternType.TemplateMethod => "Defer the exact steps of an algorithm to a subclass",
                DesignPatternType.Visitor => "Defines a new operation to a class without change",
                _ => "Unknown pattern"
            };
        }
    }
}
