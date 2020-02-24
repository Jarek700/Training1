using System;

namespace ZadaniePiramida
{
    class Program
    {
        static void Main(string[] args)
        {
            //Twoim zadaniem jest stworzenie aplikacji konsolowej, która wyświetli napis :
            //„Podaj wysokość”
            //Poczym narysuje piramide z gwiazdek. Dla wartości ujemnych do góry nogami

            Console.Write("Podaj wysokość");
            String yw = Console.ReadLine();

            Console.Write("Podaj znak do budowy:");
            String zx = Console.ReadLine();

            char znak = char.Parse(zx);
            int wysokosc = int.Parse(yw);

            if (wysokosc >= 0)
            {           
                for (int i = 0; i < wysokosc; i++)
                {
                    for (int j = (wysokosc - i) / 2; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k <= i; k++)
                    {
                        Console.Write(znak);
                       
                    }
                    Console.WriteLine();

                }
            }
            else
            {
                
                for (int i = (wysokosc * -1) - 1; i >=0; i--)

                {

                        {
                            for (int j = ((wysokosc * -1) - i) / 2; j > 0; j--)
                            {
                                Console.Write(" ");
                            }
                            for (int k = 0; k <= i; k++)
                            {
                                Console.Write(znak);
                            }

                            Console.WriteLine();
                        }
                    }
            }
            Console.ReadLine();

        }
    }
}
