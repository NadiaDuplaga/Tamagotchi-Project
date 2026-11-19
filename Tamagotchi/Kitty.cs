namespace TamagotchiProject;

public class Kitty : TamagotchiArt
{
    public override string NeutralArt { get; } = """
                                                     /\_____/\
                                                    /  o   o  \
                                                   ( ==  ^  == )
                                                    )         (
                                                   (           )
                                                  ( (  )   (  ) )
                                                 (__(__)___(__)__)
                                                 """;
    public override string HappyArt { get; } = """
                                                ❤ /\_____/\
                                                  /  ^   ^  \
                                                 ( ==  ^  == )
                                                  )         (
                                                 (           )
                                                ( (  )   (  ) )
                                               (__(__)___(__)__)
                                               """;
    public override string SadArt { get; } = """
                                                 /\_____/\
                                                /  T   T  \
                                               ( ==| ^ |== )
                                                )  |   |  (
                                               (           )
                                              ( (  )   (  ) )
                                             (__(__)___(__)__)
                                             """;
    public override string SickArt { get; } = """
                                                  /\_____/\
                                                 /  @   @  \
                                                ( ==  ^  == )
                                                 )         (
                                                (           )
                                               ( (  )   (  ) )
                                              (__(__)___(__)__)
                                              """;
    public override string SleepyArt { get; } = """
                                                 z  /\_____/\
                                                  z/  ~   ~  \
                                                  ( ==  ^  == )
                                                   )         (
                                                  (           )
                                                 ( (  )   (  ) )
                                                (__(__)___(__)__)
                                                """;
}