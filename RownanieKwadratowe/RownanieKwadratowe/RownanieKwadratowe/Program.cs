using System;

namespace RownanieKwadratowe
{
    class Program
    {
        static void Main(string[] args)
        {

            double A;
            double B;
            double C;
            double delta;
            double x1;
            double x2;

            Console.WriteLine("podaj parametry równania kwadratowego:");
            Azero:
            Console.WriteLine("podaj A");
            A = double.Parse(Console.ReadLine());
            
            if (A == 0)
            {
                Console.WriteLine("dla A=0 to nie jest równanie kwadratowe, spróbuj jeszcze raz");
                goto Azero;
            }
            Console.WriteLine("podaj B");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj C");
            C = double.Parse(Console.ReadLine());

            delta =B*B-4*A* C;

            if (delta < 0)
            {
                Console.WriteLine("brak rozwiązań rzeczywistych równania kwadratowego");
            }
            else
            {
                if (delta == 0)
                {
                    x1 = -B / (2 * A);
                    Console.WriteLine("rozwiązaniem równania jest jeden pierwiastek podwójny i wynosi on: "+x1);

                }
                else
                {
                    x1 = (-B - Math.Sqrt(delta)) / (2 * A);
                    x2 = (-B + Math.Sqrt(delta)) / (2 * A);
                    Console.WriteLine("rozwiązaniem równania są dwa pierwiastki podwójne i wynoszą one: " + x1 +" "+ x2);
                }
            }
            Console.ReadLine();

        }
    }
}
    
