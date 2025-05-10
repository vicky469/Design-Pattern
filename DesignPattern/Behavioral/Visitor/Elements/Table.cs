using System.Collections.Generic;
using DesignPattern.Behavioral.Visitor.Interfaces;

namespace DesignPattern.Behavioral.Visitor.Elements
{
    /// <summary>
    /// Concrete Element that implements the Accept method
    /// </summary>
    public class Table : IDocumentElement
    {
        public List<List<string>> Data { get; }
        public List<string> Headers { get; }

        public Table(List<string> headers, List<List<string>> data)
        {
            Headers = headers;
            Data = data;
        }

        public void Accept(IDocumentVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
