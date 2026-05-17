class Program
{
    static void Main()
    {
        Console.WriteLine("Hallo zu meinem Fitnesstracker");
        
        Console.WriteLine("Welchen Sport hast du gemacht?");
        string? sportart = Console.ReadLine();
        Console.WriteLine("Du hast geantwortet: " + sportart);
    
        Console.WriteLine("Wie viele Minuten hast du trainiert?");
        string? dauerText = Console.ReadLine();
        int dauer = int.Parse(dauerText!);
        Console.WriteLine("Super! Das sind  " + dauer + " Minuten " + sportart + ".");

    
    }
}
