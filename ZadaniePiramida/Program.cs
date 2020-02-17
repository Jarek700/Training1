using System;

namespace ZadaniePiramida
{
    class Program
    {
        static void Main(string[] args)
        {
            //Twoim zadaniem jest stworzenie aplikacji konsolowej, która wyświetli napis :
            //„Podaj wysokość”
            //Poczym narysuje piramide z gwiazdek.

            Console.Write("Podaj wysokość");
            String yw = Console.ReadLine();

            int y = int.Parse(yw);


            for (int i = 0; i < y; i++)             
            {
                for (int j = y-i; j > (0.5*y); j--)         
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
           

            Console.ReadLine();
        }
    }
}
