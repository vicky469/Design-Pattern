using System;
using DesignPattern.Creational.AbstractFactory.Interfaces;

namespace DesignPattern.Creational.AbstractFactory.MacOS
{
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a button in macOS style");
            Console.WriteLine("╭────────╮");
            Console.WriteLine("│ Button │");
            Console.WriteLine("╰────────╯");
        }

        public void HandleClick()
        {
            Console.WriteLine("macOS button click handled with smooth animation");
        }
    }
}
