namespace TamagotchiProject;

public abstract class UIElement
{
    public String DisplayString { get; set; } = String.Empty;

    public void DrawEnelemt()
    {
        Console.WriteLine($"{DisplayString}");
    }
}