namespace TamagotchiProject;

public abstract class TamagotchiArt
{
    // 'get;' jest od tego aby można było odczytać wartość ze zmiennej.
    public abstract String NeutralArt { get; }
    public abstract String HappyArt { get; }
    public abstract String SadArt { get; }
    public abstract String SickArt { get; }
    public abstract String SleepyArt { get; }

}