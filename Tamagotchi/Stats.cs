namespace TamagotchiProject;

public class Stats
{

    public Stats()
    {
        _health = GameConstants.InitialHealth;
        _happiness = GameConstants.InitialHappiness;
        _hunger = GameConstants.InitialHunger;
        _energy = GameConstants.InitialEnergy;
        _hygiene = GameConstants.InitialHygiene;
        _money = GameConstants.InitialMoney;
    }
    
    private int _health;
    private int _happiness;
    private int _hunger;
    private int _energy;
    private int _hygiene;
    private int _money;

    public int Money
    {
        get => _money;
        set => _money = value;
    }

    public int Health
    {
        get => _health;
        set => _health = value;
    }

    public int Happiness
    {
        get => _happiness;
        set => _happiness = value;
    }

    public int Hunger
    {
        get => _hunger;
        set => _hunger = value;
    }

    public int Energy
    {
        get => _energy;
        set => _energy = value;
    }

    public int Hygiene
    {
        get => _hygiene;
        set => _hygiene = value;
    }

    public TamagotchiMood GetMood()
    {
        return TamagotchiMood.NEUTRAL;
    }
}