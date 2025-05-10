using System;
using DesignPattern.Creational.AbstractFactory.Interfaces;

namespace DesignPattern.Creational.AbstractFactory.Windows
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a button in Windows style");
            Console.WriteLine("╔════════╗");
            Console.WriteLine("║ Button ║");
            Console.WriteLine("╚════════╝");
        }

        public void HandleClick()
        {
            Console.WriteLine("Windows button click handled with ripple effect");
        }
    }
}
