using DesignPattern.Behavioral.Visitor.Interfaces;

namespace DesignPattern.Behavioral.Visitor.Interfaces
{
    /// <summary>
    /// The Element interface declaring the Accept operation
    /// </summary>
    public interface IDocumentElement
    {
        void Accept(IDocumentVisitor visitor);
    }
}