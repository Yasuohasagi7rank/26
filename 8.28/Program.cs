using System;

namespace _8._28
{
    class Program
    {
        static bool TrySimple(int Num)
        {
            bool a = true;
            for (int i = 2; i <= Math.Sqrt(Num); i++)
            {
                if (Num % i == 0) a = false;
            }
            return a;
        }
        static void Main(string[] args)
        {
            for (int a = 200; a <= 500; a++)
            {
                int c = 0;
                for (int b = 2; b < a; b++)
                {
                    if (a % b == 0)
                        if (TrySimple(b))
                            c++;
                }
                if (c == 4) Console.Write(a + " ");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
