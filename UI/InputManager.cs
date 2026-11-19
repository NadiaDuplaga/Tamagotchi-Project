namespace TamagotchiProject;

public static class InputManager
{
    public static string ReadString(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
    
    public static void Pause()
    {
        Console.ReadKey();
    }
}