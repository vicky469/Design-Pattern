using DesignPattern.Creational.AbstractFactory.Interfaces;

namespace DesignPattern.Creational.AbstractFactory.Windows
{
    public class WindowsUIFactory : IUIFactory
    {
        public string Theme => "Windows 11 Light";

        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ITextBox CreateTextBox()
        {
            return new WindowsTextBox();
        }
    }
}
