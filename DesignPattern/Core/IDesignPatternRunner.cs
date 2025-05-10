namespace DesignPattern.Core
{
    public interface IDesignPatternRunner
    {
        DesignPatternType PatternType { get; }
        void Execute();
    }
}