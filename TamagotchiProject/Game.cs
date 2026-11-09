namespace TamagotchiProject;

public class Game
{
    private bool _isRunning = false;
    private Tamagotchi _tamagotchi;
    
    public Game()
    {
        _tamagotchi = new Tamagotchi(GameConstants.InitialHealth, GameConstants.InitialHappiness, GameConstants.InitialHunger,  GameConstants.InitialEnergy, GameConstants.InitialHygiene);
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
            
        }
    }
}