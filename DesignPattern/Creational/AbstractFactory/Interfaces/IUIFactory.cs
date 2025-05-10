namespace DesignPattern.Creational.AbstractFactory.Interfaces
{
    public interface IUIFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
        string Theme { get; }
    }
}
