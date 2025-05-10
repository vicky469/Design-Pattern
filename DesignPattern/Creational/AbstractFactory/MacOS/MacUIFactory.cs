using DesignPattern.Creational.AbstractFactory.Interfaces;

namespace DesignPattern.Creational.AbstractFactory.MacOS
{
    public class MacUIFactory : IUIFactory
    {
        public string Theme => "macOS Monterey";

        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MacTextBox();
        }
    }
}
