using DesignPattern.Behavioral.Visitor.Interfaces;

namespace DesignPattern.Behavioral.Visitor.Elements
{
    /// <summary>
    /// Concrete Element that implements the Accept method
    /// </summary>
    public class Image : IDocumentElement
    {
        public string Source { get; }
        public string AltText { get; }

        public Image(string source, string altText)
        {
            Source = source;
            AltText = altText;
        }

        public void Accept(IDocumentVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
