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
        // Um Abstürze zu verhindern benutzen wir jetzt TryParse statt Parse mit dem "!"
        // "out" speichert bei Erfolg den Wert in der Variable
        bool erfolg = int.TryParse(dauerText, out int dauer);
        if (erfolg == false)
        {
            Console.WriteLine("Das war keine gültige Zahl!");
        }
        else
        {
            Console.WriteLine("Super! Das sind  " + dauer + " Minuten " + sportart + ".");
        }
    }
}
