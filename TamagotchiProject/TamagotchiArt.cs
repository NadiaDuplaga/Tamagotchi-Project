namespace TamagotchiProject;

public abstract class TamagotchiArt : UIElement
{
    public abstract String NeutralArt { get; }
    public abstract String HappyArt { get; }
    public abstract String SadArt { get; }
    public abstract String SickArt { get; }
    public abstract String SleepyArt { get; }

}