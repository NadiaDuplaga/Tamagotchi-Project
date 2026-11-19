namespace TamagotchiProject;

public class Game
{
    private bool _isRunning = false;
    private Tamagotchi _tamagotchi;

    public Tamagotchi Tamagotchi => _tamagotchi;

    private ConsoleRenderer _consoleRenderer;
    
    public Game()
    {
        string name = InputManager.ReadString("Podaj imię dla swojego Tamagotchi: ");
        _tamagotchi = new Tamagotchi(name, TamagotchiType.KITTY);
        _consoleRenderer = new ConsoleRenderer(this);
    }
    
    public void Run()
    {
        _isRunning = true;
        Update();
    }
    
    private void Update()
    {
        while (_isRunning)
        {
            _consoleRenderer.Draw();
            InputManager.Pause();
        }
    }
}