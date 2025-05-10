using System;
using DesignPattern.Creational.AbstractFactory.Interfaces;

namespace DesignPattern.Creational.AbstractFactory.Windows
{
    public class WindowsTextBox : ITextBox
    {
        private string _currentValue = string.Empty;

        public void Render()
        {
            Console.WriteLine("Rendering a textbox in Windows style");
            Console.WriteLine("┌──────────────────┐");
            Console.WriteLine($"│ {_currentValue.PadRight(14)} │");
            Console.WriteLine("└──────────────────┘");
        }

        public void HandleInput(string text)
        {
            _currentValue = text;
            Console.WriteLine($"Windows textbox handling input: {text}");
        }

        public string GetValue()
        {
            return _currentValue;
        }
    }
}
