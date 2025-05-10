using System;
using DesignPattern.Core;
using DesignPattern.Creational.AbstractFactory.Interfaces;
using DesignPattern.Creational.AbstractFactory.MacOS;
using DesignPattern.Creational.AbstractFactory.Windows;

namespace DesignPattern.Creational.AbstractFactory
{
    public class AbstractFactoryRunner : DesignPatternRunner
    {
        public override DesignPatternType PatternType => DesignPatternType.AbstractFactory;

        protected override void RunPattern()
        {
            // Create UI for both platforms
            DemonstrateUI(new WindowsUIFactory());
            Console.WriteLine("\n-------------------\n");
            DemonstrateUI(new MacUIFactory());
        }

        private void DemonstrateUI(IUIFactory factory)
        {
            Console.WriteLine($"Creating UI using {factory.Theme}");

            // Create UI components
            var button = factory.CreateButton();
            var textBox = factory.CreateTextBox();

            // Demonstrate button
            Console.WriteLine("\nButton Demo:");
            button.Render();
            button.HandleClick();

            // Demonstrate textbox
            Console.WriteLine("\nTextBox Demo:");
            textBox.Render();
            textBox.HandleInput("Hello World!");
            textBox.Render();
        }
    }
}
