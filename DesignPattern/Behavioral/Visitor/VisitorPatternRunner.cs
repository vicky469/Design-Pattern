using DesignPattern.Core;
using DesignPattern.Behavioral.Visitor.Visitors;

namespace DesignPattern.Behavioral.Visitor
{
    public class VisitorPatternRunner : DesignPatternRunner
    {
        public override DesignPatternType PatternType => DesignPatternType.Visitor;

        protected override void RunPattern()
        {
            // Create the object structure
            var document = new Document();

            // Use HTML Export visitor
            Console.WriteLine("HTML Export:");
            var htmlVisitor = new HtmlExportVisitor();
            document.Accept(htmlVisitor);

            Console.WriteLine("\nDocument Statistics:");
            var statsVisitor = new StatisticsVisitor();
            document.Accept(statsVisitor);
            Console.WriteLine(statsVisitor.ToString());
        }
    }
}
