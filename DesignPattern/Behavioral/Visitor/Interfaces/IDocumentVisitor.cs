using DesignPattern.Behavioral.Visitor.Elements;

namespace DesignPattern.Behavioral.Visitor.Interfaces
{
    /// <summary>
    /// The Visitor interface declaring Visit operations for each Element type
    /// </summary>
    public interface IDocumentVisitor
    {
        void Visit(Paragraph paragraph);
        void Visit(Image image);
        void Visit(Table table);
    }
}