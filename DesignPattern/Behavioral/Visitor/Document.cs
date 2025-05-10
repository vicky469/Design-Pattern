using System.Collections.Generic;
using DesignPattern.Behavioral.Visitor.Elements;
using DesignPattern.Behavioral.Visitor.Interfaces;

namespace DesignPattern.Behavioral.Visitor
{
    /// <summary>
    /// The Object Structure class that contains all elements
    /// </summary>
    public class Document
    {
        private readonly IDocumentElement[] elements;

        public Document()
        {
            // Create a sample table
            var headers = new List<string> { "Name", "Age", "City" };
            var data = new List<List<string>>
            {
                new List<string> { "John Doe", "30", "New York" },
                new List<string> { "Jane Smith", "25", "Los Angeles" },
                new List<string> { "Bob Johnson", "35", "Chicago" }
            };

            elements = new IDocumentElement[]
            {
                new Paragraph("Hello, World!"),
                new Image("cat.jpg", "A cute cat"),
                new Table(headers, data),
                new Paragraph("This is a test document.")
            };
        }

        public void Accept(IDocumentVisitor visitor)
        {
            foreach (var element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
