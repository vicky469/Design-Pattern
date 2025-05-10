using DesignPattern.Behavioral.Visitor;
using DesignPattern.Core;
using DesignPattern.Creational.AbstractFactory;
using DesignPattern.Creational.Builder;
using DesignPattern.Creational.FactoryMethod.PaymentExample;
using DesignPattern.Creational.Prototype;
using DesignPattern.Creational.Prototype.DocumentExample;
using DesignPattern.Structural.Bridge;

namespace DesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ExecutePattern(DesignPatternType.Prototype);
        }

        private static void ExecutePattern(DesignPatternType patternType)
        {
            IDesignPatternRunner? runner = null;
            switch (patternType)
            {
                case DesignPatternType.Visitor:
                    runner = new VisitorPatternRunner();
                    break;
                case DesignPatternType.AbstractFactory:
                    runner = new AbstractFactoryRunner();
                    break;
                case DesignPatternType.Builder:
                    runner = new BuilderPatternRunner();
                    break;
                case DesignPatternType.Bridge:
                    runner = new BridgePatternRunner();
                    break;
                case DesignPatternType.FactoryMethod:
                    runner = new FactoryMethodPatternRunner();
                    break;
                case DesignPatternType.Prototype:
                    runner = new PrototypePatternRunner();
                    break;
                default:
                    throw new ArgumentException("Invalid design pattern selected", nameof(patternType));
            }
            runner.Execute();
        }
    }
}