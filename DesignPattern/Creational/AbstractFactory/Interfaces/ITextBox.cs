namespace DesignPattern.Creational.AbstractFactory.Interfaces
{
    public interface ITextBox
    {
        void Render();
        void HandleInput(string text);
        string GetValue();
    }
}
