using DesignPattern.Behavioral.Visitor.Interfaces;

namespace DesignPattern.Behavioral.Visitor.Elements
{
    /// <summary>
    /// Concrete Element that implements the Accept method
    /// </summary>
    public class Paragraph : IDocumentElement
    {
        public string Text { get; }

        public Paragraph(string text)
        {
            Text = text;
        }

        public void Accept(IDocumentVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
