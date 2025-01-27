// Abhänigkeiten werden eingebunden
using System;
using System.Threading;

// Main Programm wird erstellt
class Program
{
    // Methode  Main wird aufgerufen
    static void Main()
    {

        // Ab hier konmmt die Aufgabe des Lehrers

            //27.01.2025
            //Es muss eine Zahl eingegeben werden.
            Console.WriteLine("Tipp mal eine Zahl ein");
            int zahl = Convert.ToInt32(Console.ReadLine());

            Thread.Sleep(3000);

            Console.WriteLine($"Deine Zahl lautet {zahl}");




            FrageNachFortsetzung();



            // 20.01.2025
            // Tim hat was
            Console.Write("Tim \n");
            Console.Write("\t Hallo1 \n");
            Console.Write("\t Hallo2 \n");
            Console.Write("\t Hallo3 \n");
            Console.Write("\t Hallo4 \n");
            Console.Write("\t Hallo5 \n");
            Console.Write("\t Hallo6 \n");
            Console.Write("\n\n");

            // Gustav hat noch mehr als was.
            Console.Write("Gustav \n");
            Console.Write("\t Hallo7 \n");
            Console.Write("\t Hallo8 \n");
            Console.Write("\t Hallo9 \n");
            Console.Write("\t Hallo10 \n");
            Console.Write("\t Hallo11 \n");
            Console.Write("\t Hallo12 \n");
            Console.Write("\n\n");

            Console.Write("");


            // Einfache Tabelle mit direkten Konsolen-Befehlen
            Console.WriteLine("┌───────┬───────┬────────┐");
            Console.WriteLine("│ Name  │ Alter │ Stadt  │");
            Console.WriteLine("├───────┼───────┼────────┤");
            Console.WriteLine("│ Anna  │   28  │ Berlin │");
            Console.WriteLine("│ Max   │   35  │ Hamburg│");
            Console.WriteLine("│ Lisa  │   42  │ München│");
            Console.WriteLine("└───────┴───────┴────────┘");


            FrageNachFortsetzung();


        // Ende der Aufgabe des Leheres Optional hinzugefügter Teil fängt an


        // Funktion wird aufgebaut
        static void FrageNachFortsetzung()
        {
            Console.WriteLine("Möchten Sie fortfahren? (Y/n)");

            // Es wirs 
            string eingabe = Console.ReadLine().ToLower(); // Eingabe erforderlich

            // Es wird geprüft, ob der Nutzer das Programm abbrechen will
            if (eingabe == "n" || eingabe == "n")
            {
                // Dem Nutzer wird eine Bestätigung ausgegeben
                Console.WriteLine("Abbruch...");

                // Schlafen für 3 Sekunden
                Thread.Sleep(3000);

                // Programm wird hier geschlossen
                Environment.Exit(0);
            }
            // Diese Teil wird ausgeführt wenn alles außer "n" oder "N" gedrückt wird
            else
            {
                // Dem Nutzer wird eine Bestätigung ausgegeben
                Console.WriteLine("Fortfahren...");

                // Schlafen für 3 Sekunden
                Thread.Sleep(1000);

                // Programm wird hier nun geschlossen
            }
        }

        // Prgramm wird entgültig beendet
        Console.WriteLine("Programm Ende. Programm schießt.");

        // Schlafen für 3 Sekunden
        Thread.Sleep(3000);


    }
}


