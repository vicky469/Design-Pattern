namespace DesignPattern.Core
{
    public abstract class DesignPatternRunner : IDesignPatternRunner
    {
        public abstract DesignPatternType PatternType { get; }
        
        public void Execute()
        {
            // Show pattern information
            Console.WriteLine($"Demonstrating Pattern #{(int)PatternType}: {PatternType}");
            Console.WriteLine($"Category: {PatternType.GetCategory()}");
            Console.WriteLine($"Description: {PatternType.GetDescription()}");
            Console.WriteLine("\n------- Demo Output -------\n");

            // Execute pattern-specific implementation
            RunPattern();
        }

        protected abstract void RunPattern();
    }
}
