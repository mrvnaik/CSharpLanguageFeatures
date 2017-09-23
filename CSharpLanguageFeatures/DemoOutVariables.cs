using static System.Console;
public static class MainClass
{
    public static int Main(string [] args)
    {
        WriteLine("Hello There!");
        GetTime(out int hour, out int min, out int sec);
        WriteLine($"The time is {hour}:{min}:{sec}");
        ReadKey();
        return (0);
    }

    static void GetTime(out int hour,out int min, out int sec)
    {
        hour = 10;
        min = 10;
        sec = 40;
    }
}