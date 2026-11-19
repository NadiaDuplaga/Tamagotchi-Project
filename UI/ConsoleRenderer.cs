namespace TamagotchiProject;

public class ConsoleRenderer
{
    private Game _game;
    public ConsoleRenderer(Game game)
    {
        _game = game;
    }

    public void Draw()
    {
        Console.Clear();
        DrawTamagotchiIndicator();
        DrawTamagotchi();
    }
    
    private void DrawTamagotchiIndicator()
    {
        Console.WriteLine("Tamagotchi " + _game.Tamagotchi.Name);
    }

    private void DrawTamagotchi()
    {
        Console.WriteLine(_game.Tamagotchi.TamagotchiArt());
    }
}