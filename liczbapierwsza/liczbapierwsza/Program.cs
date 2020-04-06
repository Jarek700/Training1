using System;

namespace liczbapierwsza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj Liczbę:");
            String liczba = Console.ReadLine();
            int wartosc = int.Parse(liczba);


            bool czypierwsza = Czyliczbapierwsza(wartosc);


            if (czypierwsza)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(liczba+": to jest liczba pierwsza !!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(liczba + ": to NIE jest liczba pierwsza !!");
            }

            
            Console.ReadLine();
        }
        static bool Czyliczbapierwsza(int L)
        {
            for (int i = 2; i < L; i++)
            {
                if (L % i == 0)
                {
                    return false;
                }
                
              
            }
                   return true;
            }

    }
}
