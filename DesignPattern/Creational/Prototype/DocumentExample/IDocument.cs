using System;
using System.Collections.Generic;

namespace DesignPattern.Creational.Prototype.DocumentExample
{
    public interface IDocument : ICloneable
    {
        string Title { get; set; }
        string Content { get; set; }
        Dictionary<string, string> Metadata { get; set; }
        DateTime CreatedDate { get; set; }
        string Author { get; set; }
        void Display();
    }
}
