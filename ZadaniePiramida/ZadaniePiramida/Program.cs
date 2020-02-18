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

            int wysokosc = int.Parse(yw);


            for (int i = 0; i < wysokosc; i++)             
            {
                for (int j = (wysokosc-i)/2; j > 0; j--)         
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
