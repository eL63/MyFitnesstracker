class Program
{
    static void Main()
    {
        bool laufendesProgramm = true;
        List<int> trainingsListe = new List<int>();
        
        Console.WriteLine("Hallo zu meinem Fitnesstracker");
        Console.WriteLine("Tippe 'exit' bei der Sportart ein, um das Programm zu beenden.");
        
        
        while(laufendesProgramm)
        {
            Console.WriteLine("Welchen Sport hast du gemacht?");
            string? sportart = Console.ReadLine();
            if (sportart.ToLower() == "exit")
            {
                laufendesProgramm = false;
                continue;
            }
            
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
                // Wert zur Liste hinzufügen
                trainingsListe.Add(dauer);
                
                Console.WriteLine("Super! Das sind  " + dauer + " Minuten " + sportart + ".");
                Console.WriteLine("Eintrag wurde in der Liste gespeichert! (Einträge aktuell: " + trainingsListe.Count + ")");
            }
        }

        Console.WriteLine("\n DEINE TRAININGSÜBERSICHT");

        if (trainingsListe.Count == 0)
        {
            Console.WriteLine("Du hast heute keine Einheiten eingetragen.");
        }
        else
        {
            int gesamtMinuten = 0;

            foreach (int minuten in trainingsListe)
            {
                Console.WriteLine(">> " + minuten + "Minuten");
                gesamtMinuten += minuten;
            }

            Console.WriteLine("Programm beendet. Drücke eine beliebige Tast...");
            Console.ReadKey();
        }
    }
}
