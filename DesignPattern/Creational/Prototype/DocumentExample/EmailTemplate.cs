using System;
using System.Collections.Generic;

namespace DesignPattern.Creational.Prototype.DocumentExample
{
    public class EmailTemplate : IDocument
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Author { get; set; }
        public string Subject { get; set; }
        public List<string> Recipients { get; set; }

        public EmailTemplate()
        {
            Metadata = new Dictionary<string, string>();
            Recipients = new List<string>();
            CreatedDate = DateTime.Now;
        }

        public EmailTemplate(string title, string content, string author, string subject)
        {
            Title = title;
            Content = content;
            Author = author;
            Subject = subject;
            Metadata = new Dictionary<string, string>();
            Recipients = new List<string>();
            CreatedDate = DateTime.Now;
        }

        public object Clone()
        {
            var clone = new EmailTemplate
            {
                Title = this.Title,
                Content = this.Content,
                Author = this.Author,
                Subject = this.Subject,
                CreatedDate = DateTime.Now,
                Metadata = new Dictionary<string, string>(this.Metadata),
                Recipients = new List<string>(this.Recipients) // Deep copy of recipients
            };
            return clone;
        }

        public void Display()
        {
            Console.WriteLine($"\nEmail: {Title}");
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Created: {CreatedDate}");
            Console.WriteLine($"Content: {Content}");
            Console.WriteLine("Recipients: " + string.Join(", ", Recipients));
            Console.WriteLine("Metadata:");
            foreach (var item in Metadata)
            {
                Console.WriteLine($"  {item.Key}: {item.Value}");
            }
        }
    }
}
