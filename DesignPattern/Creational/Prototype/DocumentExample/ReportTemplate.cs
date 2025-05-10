using System;
using System.Collections.Generic;

namespace DesignPattern.Creational.Prototype.DocumentExample
{
    public class ReportTemplate : IDocument
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Author { get; set; }

        public ReportTemplate()
        {
            Metadata = new Dictionary<string, string>();
            CreatedDate = DateTime.Now;
        }

        public ReportTemplate(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
            Metadata = new Dictionary<string, string>();
            CreatedDate = DateTime.Now;
        }

        public object Clone()
        {
            var clone = new ReportTemplate
            {
                Title = this.Title,
                Content = this.Content,
                Author = this.Author,
                CreatedDate = DateTime.Now, // New timestamp for the clone
                Metadata = new Dictionary<string, string>(this.Metadata) // Deep copy of metadata
            };
            return clone;
        }

        public void Display()
        {
            Console.WriteLine($"\nReport: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Created: {CreatedDate}");
            Console.WriteLine($"Content: {Content}");
            Console.WriteLine("Metadata:");
            foreach (var item in Metadata)
            {
                Console.WriteLine($"  {item.Key}: {item.Value}");
            }
        }
    }
}
