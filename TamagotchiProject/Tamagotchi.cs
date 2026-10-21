namespace TamagotchiProject;

public class Tamagotchi
{
    private int _health;
    private int _happiness;
    private int _hunger;
    private int _energy;
    private int _hygiene;

    public Tamagotchi(int health, int happiness, int hunger, int energy, int hygiene)
    {
        _health = health;
        _happiness = happiness;
        _hunger = hunger;
        _energy = energy;
        _hygiene = hygiene;
    }
}