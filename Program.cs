namespace ConsoleA1
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {            
            Console.Write("Podaj liczbę osób: ");
            int n;

            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Niepoprawna wartość. Podaj dodatnią liczbę osób: ");
            }
                        
            string[] imiona = new string[n];
            int[] wieki = new int[n];

            List<string> imionaNaA = new List<string>();

            Dictionary<string, int> osobyPowyzej18 = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Podaj imię: ");
                imiona[i] = Console.ReadLine();

                Console.Write("Podaj wiek: ");
                int wiek;
                while (!int.TryParse(Console.ReadLine(), out wiek) || wiek < 0)
                {
                    Console.Write("Niepoprawny wiek. Podaj dodatnią wartość: ");
                }
                wieki[i] = wiek;

                if (imiona[i].StartsWith("A", StringComparison.OrdinalIgnoreCase))
                {
                    imionaNaA.Add(imiona[i]);
                }
                
                if (wiek > 18)
                {
                    osobyPowyzej18[imiona[i]] = wiek;
                }
            }

            Console.WriteLine("\nZawartość tablicy (imiona): " + string.Join(", ", imiona));
            Console.WriteLine("Zawartość tablicy (wieki): " + string.Join(", ", wieki));
            Console.WriteLine("Imiona zaczynające się na 'A': " + string.Join(", ", imionaNaA));
            Console.WriteLine("Osoby powyżej 18 lat (słownik):");
            foreach (var osoba in osobyPowyzej18)
            {
                Console.WriteLine($"{osoba.Key}: {osoba.Value}");
            }
        }
    }

}
