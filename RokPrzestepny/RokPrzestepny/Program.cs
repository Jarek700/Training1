using System;

namespace RokPrzestepny
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Podaj Rok(yyyy):");
            int Rok = int.Parse(Console.ReadLine());


            if (CzyRokPrzestepny(Rok))
            {
                Console.WriteLine("Rok Przestepny");
            }
           
            else
            {
                Console.WriteLine("Rok zwykły");
            }


            
        }
        static bool CzyRokPrzestepny(int Rok)
        {
            return ((Rok % 4 == 0) && (Rok % 100 != 0)) || (Rok % 400 == 0);
        }
    }
}
