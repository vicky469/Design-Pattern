using System;
using DesignPattern.Behavioral.Visitor.Elements;
using DesignPattern.Behavioral.Visitor.Interfaces;

namespace DesignPattern.Behavioral.Visitor.Visitors
{
    /// <summary>
    /// Concrete Visitor that converts elements to HTML
    /// </summary>
    public class HtmlExportVisitor : IDocumentVisitor
    {
        public void Visit(Paragraph paragraph)
        {
            Console.WriteLine($"<p>{paragraph.Text}</p>");
        }

        public void Visit(Image image)
        {
            Console.WriteLine($"<img src='{image.Source}' alt='{image.AltText}' />");
        }

        public void Visit(Table table)
        {
            Console.WriteLine("<table border='1'>");
            
            // Write headers
            Console.WriteLine("  <tr>");
            foreach (var header in table.Headers)
            {
                Console.WriteLine($"    <th>{header}</th>");
            }
            Console.WriteLine("  </tr>");

            // Write data rows
            foreach (var row in table.Data)
            {
                Console.WriteLine("  <tr>");
                foreach (var cell in row)
                {
                    Console.WriteLine($"    <td>{cell}</td>");
                }
                Console.WriteLine("  </tr>");
            }

            Console.WriteLine("</table>");
        }
    }
}
