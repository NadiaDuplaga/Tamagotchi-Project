namespace TamagotchiProject;

public class Tamagotchi
{
    public Stats Stats;
    public readonly TamagotchiType Type;
    
    
    private string _name;

    public string Name => _name;

    private TamagotchiArt _tamagotchiArt;

    public Tamagotchi(string name, TamagotchiType type)
    {
       Stats = new Stats();
       _name = name;
       Type = type;

       switch (Type)
       {
           case TamagotchiType.KITTY:
               _tamagotchiArt = new Kitty();
               break;
           default:
               break;
       }
    }

    public string TamagotchiArt()
    {
        switch (Stats.GetMood())
        {
            case TamagotchiMood.NEUTRAL:
                return _tamagotchiArt.NeutralArt;
            case TamagotchiMood.HAPPY:
                return _tamagotchiArt.HappyArt;
            case TamagotchiMood.SLEEPY:
                return _tamagotchiArt.SleepyArt;
            case TamagotchiMood.SAD:
                return _tamagotchiArt.SadArt;
            case TamagotchiMood.SICK:
                return _tamagotchiArt.SickArt;
            default:
                throw new ArgumentOutOfRangeException();
            // Zrobić własny exeption w tym miejscu
        }
    }
    
    
}